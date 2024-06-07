using AlisPark.Business.Abstract;
using AlisPark.DataAccess.Abstract;
using AlisPark.DataAccess.Concrete;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.TwiML.Voice;

namespace AlisPark.Business.Concrete
{
    public class WorkerManager : IWorkerService
    {
        private IWorkerDal _workerDal;

        public WorkerManager(IWorkerDal workerDal)
        {
            _workerDal = workerDal;
        }

        public void Add(Worker worker)
        {
            _workerDal.Add(worker);
        }

        public void Delete(Worker worker)
        {
            _workerDal.Delete(worker);
        }

        public List<Worker> GetAll()
        {
            return _workerDal.GetAll();
        }

        public void Update(Worker worker)
        {
            _workerDal.Update(worker);
        }
    }
}
