namespace xUnitDemo.Tests;

public class Calculator_Tests
{
    [Fact]
    public void Calculator_Add_ReturnsThree_FromOneAndTwo()
    {
        // Arrange
        
        var sut = new Calculator(); // SUT - System Under Test

        // Act

        var result = sut.Add(1, 2);

        // Assert

        Assert.Equal(3, result);
    }
}
