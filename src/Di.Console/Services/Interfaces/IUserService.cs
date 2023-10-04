using Di.Console.Models.Accounts;

namespace Di.Console.Services.Interfaces;

public interface IUserService
{
    ValueTask<User> CreateAsync(User user);
}