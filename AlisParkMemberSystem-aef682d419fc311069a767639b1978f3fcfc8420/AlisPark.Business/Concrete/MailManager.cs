using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AlisPark.Business.Abstract;
using AlisPark.DataAccess.Abstract;
using AlisPark.DataAccess.Concrete;
using AlisPark.Entities.Concrete;

namespace AlisPark.Business.Concerete
{
    public class MailManager : IMailSenderService
    {
        private IMailSenderDal _mailSenderDal;
        public MailManager(IMailSenderDal mailSenderDal)
        {
            _mailSenderDal = mailSenderDal;
        }

        public List<Mail> GetAll()
        {
            return _mailSenderDal.GetAll();
        }

        public void LogMail(Mail mail)
        {
            mail.SenderMail  = "ZhSoftware@outlook.com";
            mail.Subject = "Product";

            _mailSenderDal.Add(mail);
        }

        public void LogMailForAdd(Mail mail)
        {
            mail.SenderMail = "ZhSoftware@outlook.com";
            mail.Subject = "Product";

            _mailSenderDal.Add(mail);
        }

        public Task SendMailAsync(string email, string message)
        {

            var mail = "ZhSoftware@outlook.com";
            var pw = "Test.0998";
            var subject = "Product";

            var client = new SmtpClient("smtp-mail.outlook.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, pw)
            };
            return client.SendMailAsync(
                new MailMessage(from: mail,
                                to: email,
                                subject,
                                message));

        }


    }
}
