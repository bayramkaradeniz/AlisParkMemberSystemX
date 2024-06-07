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
        void CreateTable(string x);
        void StartTable(Table table);
        List<Table> GetStartedTables();
        void CloseTable(Table table);
        Table GetStartedTableWithId(int tableId);
        void RemoveTable(int tableId);
    }
}
