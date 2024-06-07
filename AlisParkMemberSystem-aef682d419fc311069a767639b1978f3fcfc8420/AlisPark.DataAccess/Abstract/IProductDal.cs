using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlisPark.Entities.Concrete;

namespace AlisPark.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        void ChangeStock(Product product);
        void ChangeUnitPrice(Product product);
        void CheckStock();
    }
}
