using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlisPark.Entities.Abstract;

namespace AlisPark.Entities.Concrete
{
    public class Mail : IEntity
    {
        [Key]
        public int MailId { get; set; }
        public string SenderMail { get; set; }
        public string Subject { get; set; }
        public string ReceiverMail { get; set; }
        public string MailBody { get; set; }
    }
}
