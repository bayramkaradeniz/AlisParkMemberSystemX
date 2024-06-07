using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlisPark.Entities.Concrete;

namespace AlisPark.Business.Abstract
{
    public interface IMailSenderService
    {
        List<Mail> GetAll();
        void LogMail(Mail mail);
        void LogMailForAdd(Mail mail);
        Task SendMailAsync(string email, string message);
    }
}
