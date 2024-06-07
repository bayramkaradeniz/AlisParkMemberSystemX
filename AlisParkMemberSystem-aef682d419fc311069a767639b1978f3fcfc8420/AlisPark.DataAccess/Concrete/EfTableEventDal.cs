using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AlisPark.DataAccess.Abstract;
using AlisPark.Entities.Concrete;

namespace AlisPark.DataAccess.Concrete
{
    public class EfTableEventDal : EfEntityRepositoryBase<TableEvent, AlisParkContext>, ITableEventDal
    {
        public void CloseSession(int ıd)
        {
            using (var context = new AlisParkContext())
            {
                var tableEvent = context.TableEvents.FirstOrDefault(u => u.Id == ıd);
                
                TimeSpan fark = (DateTime.Now) - (tableEvent.OpeningTime);
                double timeDifferen = fark.TotalMinutes;
                tableEvent.ClosingTime = DateTime.Now;
                tableEvent.TableId = ıd;
                tableEvent.EventTime = DateTime.Now;
                string Desc = $"{tableEvent.TableId}'li Masa, {tableEvent.OpeningTime} ile {tableEvent.ClosingTime} arasında " +
                    $"{timeDifferen} Dakika Oturum Sürdürdü. ";
                tableEvent.EventDescription = Desc;
                context.SaveChanges();
            }
        }
    }
}
