using Di.Console.Services.Interfaces;

namespace Di.Console.Services;

public class EmailSenderService : IEmailSenderService
{
    public ValueTask<bool> SendEmailAsync(string email, string subject, string message)
    {
        return new(true);
    }
}