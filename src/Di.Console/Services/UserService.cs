using Di.Console.Models.Accounts;
using Di.Console.Services.Interfaces;

namespace Di.Console.Services;

public class UserService : IUserService
{
    public ValueTask<User> CreateAsync(User user)
    {
        throw new NotImplementedException();
    }
}