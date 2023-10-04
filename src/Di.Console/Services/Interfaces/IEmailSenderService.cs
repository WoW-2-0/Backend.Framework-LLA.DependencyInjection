namespace Di.Console.Services.Interfaces;

public interface IEmailSenderService
{
    ValueTask<bool> SendEmailAsync(string email, string subject, string message);
}