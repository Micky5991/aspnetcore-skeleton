using Microsoft.AspNetCore.Identity.UI.Services;

namespace Application.Web.Infrastructure.Email;

public class SmtpMailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        throw new NotImplementedException();
    }
}
