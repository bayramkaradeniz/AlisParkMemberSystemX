using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.Abstract
{
    public interface IMessageSenderService
    {
        Task SendMessageAsync(string description, Member member);
    }
}
