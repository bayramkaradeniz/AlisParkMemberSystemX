using System.Collections.Generic;
using AlisPark.Entities.Concrete;

namespace AlisPark.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        List<Product> GetAll();

        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetProductsByProductName(string productName);
        void ChangeStock(Product product);

        void Delete(Product product);
        void ChangeUnitPrice(Product product);
        void ChangeStock();
    }
}
