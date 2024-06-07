using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlisPark.Entities.Abstract;

namespace AlisPark.Entities.Concrete
{
    public class TableEvent : IEntity
    {

        public int Id { get; set; }
        public DateTime EventTime { get; set; }
        public string EventDescription { get; set; }=null;
        public DateTime OpeningTime { get; set; }
        public DateTime? ClosingTime { get; set; }
        public string Duration { get; set; } = null;

        public int TableId { get; set; }
        public Table Table { get; set; } // Bir olay sadece bir tablo ile ilişkilendirilmiştir
       
    }

}
