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

namespace AlisPark.DataAccess.Concrete
{
    public class EfMailSender : EfEntityRepositoryBase<Mail, AlisParkContext>, IMailSenderDal
    {
       
    }
}
