using Application.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Application.Web.Infrastructure.Email;

public class IdentityMailSender : IEmailSender<ApplicationUser>
{
    private readonly IEmailSender _emailSender;

    public IdentityMailSender(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }


    public Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink)
    {
        throw new NotImplementedException();
    }

    public Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink)
    {
        throw new NotImplementedException();
    }

    public Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode)
    {
        throw new NotImplementedException();
    }
}
