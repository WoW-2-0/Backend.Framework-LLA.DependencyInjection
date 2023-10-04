using Di.Console.Models.Accounts;
using Di.Console.Services.Interfaces;

namespace Di.Console.Services;

public class AccountService : IAccountService
{
    public ValueTask<bool> RegisterAsync(RegisterDetails registerDetails)
    {
        throw new NotImplementedException();
    }
}