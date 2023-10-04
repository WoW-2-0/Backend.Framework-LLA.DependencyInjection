namespace Di.Console.Models.Accounts;

public class User
{
    public Guid Id { get; set; }
    public string EmailAddress { get; set; }
    public string Password { get; set; }
}