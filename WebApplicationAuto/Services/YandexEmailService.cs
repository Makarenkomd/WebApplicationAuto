using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAuto.Services
{
    public class YandexEmailService : IEmailSender
    {
        public string getText()
        {
            return "yandex";
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            throw new NotImplementedException();
        }
    }
}
