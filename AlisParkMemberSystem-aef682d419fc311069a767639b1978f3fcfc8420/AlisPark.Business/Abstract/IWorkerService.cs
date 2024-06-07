using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.Abstract
{
    public interface IWorkerService
    {
        List<Worker> GetAll();
        void Add(Worker worker);
        void Update(Worker worker);
        void Delete(Worker worker);
    }
}
