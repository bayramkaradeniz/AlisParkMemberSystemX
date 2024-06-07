//using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlisPark.Entities.Abstract;

namespace AlisPark.Entities.Concrete
{
    public class Table : IEntity
    {

        public int Id { get; set; }
        public int TableNumber { get; set; }
        public string TableName { get; set; }
        public bool IsOccupied { get; set; } = false;
        public DateTime? OpeningTime { get; set; } 
        public int TableType { get; set; } = 0;
        public List<TableEvent> Events { get; set; } // Bir tablo birden çok olaya sahip olabilir
        public List<Order> Orders { get; set; } = null;

        public Table()
        {
            Events = new List<TableEvent>();
        }
    }
}


