using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AlisPark.DataAccess.Abstract;
using AlisPark.Entities.Concrete;
//using System.Windows.Forms;

namespace AlisPark.DataAccess.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product, AlisParkContext>, IProductDal
    {
        public void ChangeStock(Product product)
        {
            using (var context = new AlisParkContext())
            {
                var productOne = context.Products.FirstOrDefault(u => u.ProductId == product.ProductId);

                productOne.StockAmount = product.StockAmount;
                context.SaveChanges();
            }
        }

        public void ChangeUnitPrice(Product product)
        {
            using (var context = new AlisParkContext())
            {
                var productOne = context.Products.FirstOrDefault(u => u.ProductId == product.ProductId);

                productOne.UnitPrice = product.UnitPrice;
                context.SaveChanges();
            }
        }

        public void CheckStock()
        {
            using (var dbContext = new AlisParkContext())
            {
                var products = dbContext.Products.ToList(); // Tüm ürünleri al

                foreach (var product in products)
                {
                    if (product.StockAmount < 20 && !product.StockWarningSent)
                    {
                        // Uyarı gönderme işlemi burada yapılır (örneğin, e-posta gönderimi).
                        Console.WriteLine($"Ürün stok sayısı 20'nin altına düştü: {product.ProductName}");

                        // Uyarı gönderildi olarak işaretlenir.
                        product.StockWarningSent = true;
                    }
                    else if (product.StockAmount >= 20 && product.StockWarningSent)
                    {
                        // Stok sayısı 20'yi geçtiğinde StockWarningSent'i false yap
                        product.StockWarningSent = false;
                    }
                }
            }
        }
    }
}
