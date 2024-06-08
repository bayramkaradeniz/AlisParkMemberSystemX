using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.Abstract
{
    public interface ITableCategoryService
    {
        void Add(TableCategory tableCategory);
        List<TableCategory> GetAll();
        void Update(TableCategory tableCategory);
    }
}
