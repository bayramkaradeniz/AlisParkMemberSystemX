using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.Abstract
{
    public interface ICompanyService
    {
        void Add(Company company);
        void AddWorker(Worker worker);
        void Update(Company company);
        string CheckLogin(string username, string password);
    }
}
