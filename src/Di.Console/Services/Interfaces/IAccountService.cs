using Di.Console.Models.Accounts;

namespace Di.Console.Services.Interfaces;

public interface IAccountService
{
    ValueTask<bool> RegisterAsync(RegisterDetails registerDetails);
}