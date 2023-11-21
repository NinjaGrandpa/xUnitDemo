namespace xUnitDemo.Tests;

public class UserValidator_Tests
{
    public static IEnumerable<object[]> UserTestData => new List<object[]>
    {
        new object[]{"max@gmail.se", "274!Hejhej", true},
        new object[]{"dojman@hotmail.com", "Doj458dingo_", true},
        new object[]{"tjoff", "c", false},
        new object[]{"tjoff@hotmail", "c",false},
        new object[]{"tjoff@hotmail.", "c",false}
    };

    [Theory]
    [MemberData(nameof(UserTestData))]
    public static void UserValidator_IsValid_ReturnsTrue_WhenUserIsValid(string email, string password, bool expected)
    {
        // Arrange
        var sut = new UserValidator();

        // Act
        var result = sut.IsValid(email, password);

        // Assert
        Assert.Equal(expected, result);

    }
}