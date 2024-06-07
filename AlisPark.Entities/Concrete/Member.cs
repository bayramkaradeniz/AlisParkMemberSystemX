using AlisPark.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Entities.Concrete
{
    public  class Member : IEntity
    {
        public int MemberId { get; set; }
        public string  MemberName { get; set; }
        public string MemberSurname { get; set; }
        public string MemberPhone { get; set; }
        public string MemberMail { get; set; }
        public int CategoryId { get; set; }
        public decimal Balance { get; set; }

    }
}
