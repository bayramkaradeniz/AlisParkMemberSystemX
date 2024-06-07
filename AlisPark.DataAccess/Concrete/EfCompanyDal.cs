using AlisPark.DataAccess.Abstract;
using AlisPark.Entities.Abstract;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.DataAccess.Concrete
{
    public class EfCompanyDal : EfEntityRepositoryBase<Company, AlisParkContext>, ICompanyDal
    {
        public void Save(AlisParkContext context)
        {
            context.SaveChanges();
        }
    }
}
