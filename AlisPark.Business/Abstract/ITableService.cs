using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlisPark.Entities.Concrete;

namespace AlisPark.Business.Abstract
{
    public interface ITableService
    {
        List<Table> GetAll();
        void CreateTable();
        void StartTable(Table table);
        List<Table> GetStartedTables();
        void CloseSession(Table table);
        void CloseTable(Table table);
        Table GetStartedTableWithId(int tableId);
    }
}
