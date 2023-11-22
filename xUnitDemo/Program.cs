var email = "_tjoff@hotmail.se";

var splitEmail = email.Split("@");
var localPart = splitEmail.First();
var domainPart = splitEmail.Last();

var splitDomain = domainPart.Split(".");
var hostName = splitDomain.First();
var domainName = splitDomain.Last();

foreach (var part in splitEmail)
{
    Console.WriteLine("Part: " + part);
    Console.WriteLine("Length: " + splitEmail.Length);
}

foreach (var part in splitDomain)
{
    Console.WriteLine("Domain Part: " + part);
    Console.WriteLine("Length: " + splitDomain.Length);
}

if (splitEmail.Length != 2
    || splitEmail.Any(c => c.Contains(""))
    || splitDomain.Length != 2
    || splitDomain.Any(c => c.Contains(""))
   )
{
    Console.WriteLine("Passed");
}
else Console.WriteLine("Failed");