using AlisPark.Business.Abstract;
using AlisPark.Business.Utilities;
using AlisPark.Business.ValidationRules.FluentValidation;
using AlisPark.DataAccess.Abstract;
using AlisPark.DataAccess.Concrete;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio.TwiML.Voice;

namespace AlisPark.Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private ICompanyDal _companyDal;
        private IWorkerDal _workerDal;

        public CompanyManager(ICompanyDal companyDal, IWorkerDal workerDal)
        {
            _companyDal = companyDal;
            _workerDal = workerDal;
        }

        public void Add(Company company)
        {
            _companyDal.Add(company);
        }

        public void AddWorker(Worker worker)
        {
            _workerDal.Add(worker);
        }

        public string CheckLogin(string username, string UserPassword)
        {
            using (var context = new AlisParkContext())
            {
                
                var UserOne = context.CompanyUsers.FirstOrDefault(k => k.CompanyAdminUsername == username);


                if (UserOne != null)
                {
                    
                    if (VerifyPassword(UserPassword, UserOne.CompanyAdminPassword))
                    {

                        UserOne.CurrentWorker = username;
                        context.SaveChanges();

                        return "A";
                    }
                    else
                    {
                        return "B";
                    }
                }
                else
                {
                    return "C";
                }
               

                bool VerifyPassword(string password, string workerPassword)
                {
                    return password == workerPassword;
                }
            }
            
        }

            public void Update(Company company)
            {
                _companyDal.Update(company);
            }
       

        
    }
}
