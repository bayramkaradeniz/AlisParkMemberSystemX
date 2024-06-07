using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlisPark.Business.Abstract;
using AlisPark.Business.Utilities;
using AlisPark.Business.ValidationRules.FluentValidation;
using AlisPark.DataAccess.Abstract;
using AlisPark.Entities.Concrete;

namespace AlisPark.Business.Concerete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTools.FluentValidate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void ChangeStock(Product product)
        {
            ValidationTools.FluentValidate(new ProductValidator(), product);
            _productDal.ChangeStock(product);
        }

        public void ChangeStock()
        {
            _productDal.CheckStock();
        }

        public void ChangeUnitPrice(Product product)
        {
            ValidationTools.FluentValidate(new ProductValidator(), product);
            _productDal.ChangeUnitPrice(product);
        }

        public void Delete(Product product)
        {

            _productDal.Delete(product);
        }
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}

