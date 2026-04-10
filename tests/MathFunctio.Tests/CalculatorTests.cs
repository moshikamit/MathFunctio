using MathFunctio;
using Xunit;

namespace MathFunctio.Tests;

public sealed class CalculatorTests
{
    [Theory]
    [InlineData(5, 7, "addition", 12)]
    [InlineData(9, 4, "subtraction", 5)]
    [InlineData(6, 3, "multiplication", 18)]
    [InlineData(20, 5, "division", 4)]
    public void Calculate_ReturnsExpectedResult(int firstNumber, int secondNumber, string operation, int expected)
    {
        var result = Calculator.Calculate(firstNumber, secondNumber, operation);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Calculate_ThrowsForDivisionByZero()
    {
        Assert.Throws<DivideByZeroException>(() => Calculator.Calculate(10, 0, "division"));
    }

    [Fact]
    public void Calculate_ThrowsForUnsupportedOperation()
    {
        Assert.Throws<ArgumentException>(() => Calculator.Calculate(10, 5, "modulo"));
    }
}
