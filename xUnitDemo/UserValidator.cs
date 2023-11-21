using xUnitDemo.Interfaces;

namespace xUnitDemo;

public class UserValidator : IUserValidator
{
    public bool IsValid(string email, string password)
    {
        return email.Contains("@") && email.Contains(".");
    }
}