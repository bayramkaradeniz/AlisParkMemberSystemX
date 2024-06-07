using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using AlisPark.DataAccess.Abstract;
using AlisPark.Entities.Concrete;

namespace AlisPark.DataAccess.Concrete
{
    public class EfTableEventDal : EfEntityRepositoryBase<TableEvent, AlisParkContext>, ITableEventDal
    {
        public void CloseSession(int id)
        {
            using (var context = new AlisParkContext())
            {
                var tableEvent = context.TableEvents.FirstOrDefault(u => u.TableId == id);

                if (tableEvent != null)
                {
                    TimeSpan duration = DateTime.Now - tableEvent.OpeningTime;
                    double totalMinutes = duration.TotalMinutes;

                    tableEvent.ClosingTime = DateTime.Now;
                    tableEvent.EventTime = DateTime.Now;

                    tableEvent.Duration = totalMinutes.ToString();

                    string description = $"{tableEvent.TableId} numaralı masa, {tableEvent.OpeningTime} ile {tableEvent.ClosingTime} arasında " +
                                         $"{totalMinutes:F2} dakika oturum sürdürdü.";
                    tableEvent.EventDescription = description;

                    context.SaveChanges();
                }
            }
        }


        public TableEvent GetLatestTableEvent(int id)
        {
            using (var context = new AlisParkContext())
            {
                var list = context.TableEvents
                         .Where(te => te.TableId == id)
                                          .ToList();

                return list.Where(te => te.TableId == id && te.OpeningTime <= DateTime.Now)
    .OrderByDescending(te => te.OpeningTime)
    .FirstOrDefault();

            }
        }

        public void StartSession(Table table)
        {
            using (var context = new AlisParkContext())
            {
                context.TableEvents.Add(new TableEvent
                {
                    TableId = table.Id,
                    OpeningTime = DateTime.Now,
                    EventTime = DateTime.Now,
                });
            }

        }
    }
}
