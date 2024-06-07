using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlisPark.Entities.Concrete;

namespace AlisPark.Business.Abstract
{
    public interface ITableEventService
    {
        void CloseSession(Table table);
        List<TableEvent> GetAll();
        List<TableEvent> GetByTableId(int x);
        void StartSession(Table table);
    }
}
