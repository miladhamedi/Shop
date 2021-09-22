using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.ServiceSender
{
    public interface IEmailSender
    {
        Task EmailSenderAsync(string email, string subject, string message);
    }
}
