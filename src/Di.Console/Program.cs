using Di.Console.Models.Accounts;
using Di.Console.Services;
using Di.Console.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

// Create dependency injection container
var services = new ServiceCollection();

// Register services
services.AddScoped<IUserService, UserService>().AddScoped<IAccountService, AccountService>().AddScoped<IEmailSenderService, EmailSenderService>();

// Build service provider
var provider = services.BuildServiceProvider();

var accountService = provider.GetRequiredService<IAccountService>();
var result = await accountService.RegisterAsync(new RegisterDetails
{
    EamilAddress = "sultonbek.rakhimov@gmail.com",
    Password = "Testtest_1"
});