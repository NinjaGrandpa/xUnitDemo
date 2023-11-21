namespace xUnitDemo.Interfaces;

public interface IUserValidator
{
    public bool IsValid(string email, string password);
}