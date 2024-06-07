using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlisPark.Business.Abstract;
using AlisPark.DataAccess.Abstract;
using AlisPark.DataAccess.Concrete;
using AlisPark.Entities.Concrete;

namespace AlisPark.Business.Concerete
{
    public class TableEventManager : ITableEventService
    {
        private ITableEventDal _tableEventDal;

        public TableEventManager(ITableEventDal tableEventDal)
        {
            _tableEventDal = tableEventDal;
            
        }

        public void CloseSession(Table table)
        {
            _tableEventDal.CloseSession(table.Id);
        }

        public List<TableEvent> GetAll()
        {
            return _tableEventDal.GetAll();
        }


        public List<TableEvent> GetByTableId(int x)
        {
            return _tableEventDal.GetAll(p => p.TableId == x)
        .ToList();
        }

        

        public TableEvent GetLatestTableEvent(int ıd)
        {
            return _tableEventDal.GetLatestTableEvent(ıd);
        }

        public void StartSession(Table table)
        {
            _tableEventDal.StartSession(table);
        }
    }
}
