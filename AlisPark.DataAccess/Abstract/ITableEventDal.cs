using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AlisPark.Entities.Concrete;

namespace AlisPark.DataAccess.Abstract
{
    public interface ITableEventDal : IEntityRepository<TableEvent>
    {
        void CloseSession(int ıd);
        TableEvent GetLatestTableEvent(int ıd);
        void StartSession(Table table);
    }
}
