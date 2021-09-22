using Shop.Core.Contract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.ServiceSender
{
    public class MessageSender : IEmailSender
    {
        private readonly ISettingRepository settingRepository;

        public MessageSender(ISettingRepository settingRepository)
        {
            this.settingRepository = settingRepository;
        }
        public Task EmailSenderAsync(string email, string subject, string message)
        {
            var setting =  settingRepository.GetSetting();

            MailMessage mailMessage = new MailMessage();
            mailMessage.Body = message;
            mailMessage.BodyEncoding = Encoding.UTF8;
            mailMessage.IsBodyHtml = true;
            mailMessage.From = new MailAddress(setting.Email, "لوازم خانگی ", Encoding.UTF8);
            mailMessage.Priority = MailPriority.Normal;
            mailMessage.Sender = mailMessage.From;
            mailMessage.Subject = subject;
            mailMessage.SubjectEncoding = Encoding.UTF8;
            mailMessage.To.Add(new MailAddress(email, "گیرنده", Encoding.UTF8));

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = setting.Smtp;
            smtpClient.Port = 25;
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(setting.Email, setting.PassWordEmail);

            smtpClient.Send(mailMessage);

            return Task.FromResult(0);
        }
    }
}
