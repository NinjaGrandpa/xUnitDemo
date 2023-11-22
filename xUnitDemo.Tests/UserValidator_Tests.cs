using Xunit.Abstractions;

namespace xUnitDemo.Tests;

public class UserValidator_Tests
{
    private readonly ITestOutputHelper _output;

    public UserValidator_Tests(ITestOutputHelper output)
    {
        _output = output;
    }

    public static IEnumerable<object[]> UserTestData => new List<object[]>
    {
        new object[]{"max@gmail.se", "274!Hejhej", true},
        new object[]{"dojman@hotmail.com", "Doj458dingo_", true},
        new object[]{"tjoff", "c", false},
        new object[]{"tjoff@hotmail", "c",false},
        new object[]{"tjoff@hotmail.", "c",false},
        new object[]{"@tjoff@hotmail.com", "c",false},
        new object[]{".tjoff@hotmail.com", "c",false},
        new object[]{".tjoffhotmail.com", "c",false},
        new object[]{"_tjoff@hotmail.com", "c",true},
        new object[]{"(tjoff@hotmail.com", "c",false},
        new object[]{"\"tjoff@hotmail.com", "c",false},
        new object[]{")tjoff@hotmail.com", "c",false},
        new object[]{",tjoff@hotmail.com", "c",false},
        new object[]{":tjoff@hotmail.com", "c",false},
        new object[]{";tjoff@hotmail.com", "c",false},
        new object[]{"<>@[]tjoff@hotmail.com", "c",false},
        new object[]{"tjoff@hotmail..com", "c",false},
        new object[]{"tjoff@@hotmail.com", "c",false},
    };

    [Theory]
    [MemberData(nameof(UserTestData))]
    public void UserValidator_IsValid_ReturnsTrue_WhenUserIsValid(string email, string password, bool expected)
    {
        // Arrange
        var sut = new UserValidator();

        // Act
        var result = sut.IsValid(email, password);

        // Assert
        Assert.Equal(expected, result);
    }
}