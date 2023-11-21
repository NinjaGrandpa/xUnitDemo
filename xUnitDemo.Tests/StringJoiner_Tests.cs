namespace xUnitDemo.Tests;

public class StringJoiner_Tests
{
    // Uppgift: Skriv en metod JoinStrings som sammanfogar en array av strängar med ett specifikt avskiljtecken.

    // Tester: Använd xUnit för att skapa tester som verifierar att metoden korrekt hanterar olika scenarier, inklusive tomma arrays och null-värden.

    public static IEnumerable<object[]> InputStringArrays => new List<object[]>
    {
        new object[] { "Hello, World!", new string("Hello, World!").ToCharArray().Select(c => c.ToString()).ToArray() },
        new object[]{ "Hejsan världen!", new string("Hejsan världen!").ToCharArray().Select(c => c.ToString()).ToArray() },
        new object[]{ "", new string("").ToCharArray().Select(c => c.ToString()).ToArray() }
    };

    [Theory]
    [MemberData(nameof(InputStringArrays))]
    public void StringJoiner_JoinStrings_ReturnsJoinedString_FromStringArray(string expectedJoinedString, string[] inputStringArray)
    {
        // Arrange
        var sut = new StringJoiner();

        // Act
        var joinedString = sut.JoinStrings(inputStringArray);

        // Assert
        Assert.Equal(expectedJoinedString, joinedString);
    }

    [Theory]
    [InlineData(null)]
    public void StringJoiner_JoinStrings_ThrowsException_WhenStringArrayIsNull(string[] inputStringArray)
    {
            // Arrange
            var sut = new StringJoiner();

            // Act
            Action act = () => sut.JoinStrings(inputStringArray);

            // Assert
            Assert.Throws<NullReferenceException>(act);
    }
}
