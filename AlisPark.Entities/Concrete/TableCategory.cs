using AlisPark.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Entities.Concrete
{
    public class TableCategory : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PriceForHour { get; set; }

    }
}
