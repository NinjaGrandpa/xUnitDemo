namespace xUnitDemo;

public class Rectangle(ICalculator calculator)
{
    private readonly ICalculator _calculator = calculator;
    public decimal SideA { get; set; }
    public decimal SideB { get; set; }

    public decimal Circumferance(decimal sideA, decimal sideB)
    {
        var sumOfSideA = _calculator.Multiply(sideA, 2);
        var sumOfSideB = _calculator.Multiply(sideB,2);

        var circumferance = _calculator.Add(sumOfSideA, sumOfSideB);

        return circumferance;
    }
}