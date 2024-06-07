using AlisPark.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace AlisPark.Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string CategoryDescription { get; set; } = string.Empty;
        public int ProductStock { get; set; } = 0;
        public int OrderAmount { get; set; } = 0;
        public decimal OrderPrice { get; set; } = 0.0m;
        public DateTime OrderDate { get; set; } = DateTime.MinValue;
        public int TableId { get; set; }
        public bool Delivered { get; set; } = false;
        public Table Table { get; set; }
    }
}
