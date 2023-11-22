using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text.RegularExpressions;
using xUnitDemo.Interfaces;

namespace xUnitDemo;

public class UserValidator : IUserValidator
{
    public bool IsValid(string email, string password)
    {
        var splitEmail = email.Split("@");
        var localPart = splitEmail.First();
        var domainPart = splitEmail.Last();

        var splitDomain = domainPart.Split(".");
        var hostName = splitDomain.First();
        var domainName = splitDomain.Last();

        if (splitEmail.Length != 2
            && splitEmail.Any(c => c.Contains(""))
            || splitDomain.Length != 2
            && splitDomain.Any(c => c.Contains(""))
            )
        {
            return false;
        }

        var mustContainChars = new[] { "@", "." };
        var forbiddenChars = new[] { "(", "\"", ")", ",", ":", ";", "<", ">", "[", "]", "\\" };
        var forbiddenStartChar = new[] { "@", "." };
        var forbiddenEndChars = new[] { "@", "." };

        return mustContainChars.All(email.Contains)
               && !forbiddenStartChar.Any(email.StartsWith)
               && !forbiddenEndChars.Any(email.EndsWith)
               && !forbiddenChars.Any(email.Contains);
    }
}