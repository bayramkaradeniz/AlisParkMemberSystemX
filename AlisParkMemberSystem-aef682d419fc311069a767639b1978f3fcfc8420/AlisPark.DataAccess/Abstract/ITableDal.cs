using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlisPark.Entities.Concrete;

namespace AlisPark.DataAccess.Abstract
{
    public interface ITableDal : IEntityRepository<Table>
    {
        void CloseTable(Table table);
        void CreateTable();
        List<Table> GetStartedTables();
        void StartTable(Table table);
    }
}
