using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace How_to_website.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
