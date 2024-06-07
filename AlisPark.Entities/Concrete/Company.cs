using AlisPark.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Entities.Concrete
{
    public class Company:IEntity
    {
        public int AdminId { get; set; }
        public String CompanyAdminUsername { get; set; }
        public string CompanyAdminPassword { get; set; }
        public String CompanyAdminPhone { get; set; }
        public String CompanyAdminMail { get; set; }
        public string AdminFullName { get; set; }
        public Decimal? BalanceIncreaseRateForVipMember { get; set; }
        public Decimal? BalanceIncreaseRateForMember { get; set; }
        public string CurrentWorker { get; set; }


    }
}
