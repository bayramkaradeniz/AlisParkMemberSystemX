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
    public class LogEntryManager : ILogEntryService
    {
        private ILogEntryDal _logEntryDal;
        public LogEntryManager(ILogEntryDal logEntryDal)
        {
            _logEntryDal = logEntryDal;
        }

        public void LogForAdd(Worker worker, Member member)
        {
            using (var context = new AlisParkContext())
            {
                LogEntry logEntry = new LogEntry();
                {
                    logEntry.Timestamp = DateTime.Now;
                    logEntry.Description = $"{worker.WorkerUserName}"+" "+$"{member.MemberName}"+" "+$"{member.MemberSurname}" +
                        $" İsimli Yeni Bir Üye Oluşturdu ve " +
                        $"Yeni Üyenin Hesap Bakiyesini {member.Balance} tl Olarak Belirledi.";
                };
                _logEntryDal.Add(logEntry);
            }
        }
        
        public List<LogEntry> GetAll()
        {
            var currentDate = DateTime.Now;
            var oneWeekAgo = currentDate.AddDays(-7); // Şuanki tarihten bir hafta önceki tarih

            var records = _logEntryDal.GetAll()
                .Where(member => member.Timestamp >= oneWeekAgo && member.Timestamp <= currentDate)
                .OrderByDescending(member => member.Timestamp)
                .ToList();

            return records;
        }

        public void Delete(LogEntry logEntry)
        {
            try
            {
                _logEntryDal.Delete(logEntry);
            }
            catch
            {
                throw new Exception("Silme gerçekleşemedi");
            }
        }

        public void LogForUpdate(Worker worker, Member member)
        {
            using (var context = new AlisParkContext())
            {
                LogEntry logEntry = new LogEntry();
                {
                    logEntry.Timestamp = DateTime.Now;
                    logEntry.Description = $"{worker.WorkerUserName} İsimli Çalışan Tarafından"+" "+$"{member.MemberName}"+ " " +" "+$"{member.MemberSurname}" +
                        $"İsimli Kullanıcının Hesap Bakiyesi {member.Balance} tl Olarak Belirlendi.";
                };
                _logEntryDal.Add(logEntry);
            }
        }

        public void LogForLogIn(Worker worker)
        {
            using (var context = new AlisParkContext())
            {
                LogEntry logEntry = new LogEntry();
                {
                    logEntry.Timestamp = DateTime.Now;
                    logEntry.Description = $"Sistem {worker.WorkerUserName} Adlı Çalışan Tarafından Başlatıldı.";
                };
                _logEntryDal.Add(logEntry);
            }
        }

        public List<LogEntry> GetLogsByWord(string word)
        {
            return _logEntryDal.GetAll(p => p.Description.Contains(word.ToLower()));
        }

        public void LogForChange(string worker)
        {
            using (var context = new AlisParkContext())
            {
                LogEntry logEntry = new LogEntry();
                {
                    logEntry.Timestamp = DateTime.Now;
                    logEntry.Description = $"Yetkili {worker} olarak değiştirildi.";
                };
                _logEntryDal.Add(logEntry);
            }
        }
    }
}
