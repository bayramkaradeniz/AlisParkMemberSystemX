using AlisPark.Business.Abstract;
using AlisPark.DataAccess.Abstract;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.Concrete
{
    public class TableCategoryManager : ITableCategoryService
    {
        private ITableCategoryDal _tableCategoryDal;
        public TableCategoryManager(ITableCategoryDal tableCategoryDal)
        {
            _tableCategoryDal = tableCategoryDal;
        }

        public void Add(TableCategory tableCategory)
        {
            _tableCategoryDal.Add(tableCategory);
        }


        public List<TableCategory> GetAll()
        {
            return _tableCategoryDal.GetAll();
        }

        public void Update(TableCategory tableCategory)
        {
            _tableCategoryDal.Update(tableCategory);
        }
    }
}
