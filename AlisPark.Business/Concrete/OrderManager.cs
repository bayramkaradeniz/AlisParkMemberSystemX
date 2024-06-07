using AlisPark.Business.Abstract;
using AlisPark.Business.Utilities;
using AlisPark.Business.ValidationRules.FluentValidation;
using AlisPark.DataAccess.Abstract;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public List<Order> GetAll()
        {
            //Business code            
            return _orderDal.GetAll(); 
        }
         
        public List<Order> GetOrdersById(int orderId)
        {
            return _orderDal.GetAll(p => p.OrderId == orderId);
        }

        public List<Order> GetOrdersByName(string orderName)
        {
            return _orderDal.GetAll(p => p.OrderName.ToLower().Contains(orderName.ToLower()));
        }

        public List<Order> GetOrdersByDelivered()
        {
            return _orderDal.GetAll(p => p.Delivered == false);
        }

        public void Add(Order order)
        {
            //    ValidationTools.FluentValidate(new ProductValidator(), member);
            _orderDal.Add(order);
        }

        public void Update(Order order)
        {
            //    ValidationTools.FluentValidate(new ProductValidator(), product);
            _orderDal.Update(order);
        }

        public void Delete(Order order)
        {
            try
            {
                _orderDal.Delete(order);
            }
            catch
            {
                throw new Exception("Couldn't delete.");
            }
        }
    }
}
