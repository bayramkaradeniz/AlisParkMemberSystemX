using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.Abstract
{
    public interface ILogEntryService
    {

        List<LogEntry> GetAll();
        List<LogEntry> GetLogsByWord(string word);
        void LogForLogIn(Worker worker);
        void LogForChange(string worker);
        void LogForAdd(Worker worker,Member member);
        void LogForUpdate(Worker worker, Member member);
        void Delete(LogEntry logEntry);
    }
}
