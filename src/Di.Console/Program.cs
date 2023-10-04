// using Di.Console.Models.Accounts;
// using Di.Console.Services;
// using Di.Console.Services.Interfaces;
// using Microsoft.Extensions.DependencyInjection;

// Create dependency injection container

using Di.Console.Models.Accounts;
using Di.Console.Services;
using Di.Console.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

// Register services
services
    .AddSingleton<IAccountService, AccountService>()
    .AddSingleton<IUserService, UserService>()
    .AddSingleton<IEmailSenderService, EmailSenderService>();

// Build service provider
var provider = services.BuildServiceProvider();

// Requesting service
var accountService = provider.GetRequiredService<IAccountService>();

var result = await accountService.RegisterAsync(new RegisterDetails
{
    EamilAddress = "sultonbek.rakhimov@gmail.com",
    Password = "Testtest_1"
});

Console.WriteLine(result);