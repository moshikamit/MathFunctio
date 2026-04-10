namespace MathFunctio;

public static class Calculator
{
    public static int Calculate(int firstNumber, int secondNumber, string operation)
    {
        return operation.Trim().ToLowerInvariant() switch
        {
            "addition" or "+" => firstNumber + secondNumber,
            "subtraction" or "-" => firstNumber - secondNumber,
            "multiplication" or "*" => firstNumber * secondNumber,
            "division" or "/" => secondNumber != 0
                ? firstNumber / secondNumber
                : throw new DivideByZeroException("Cannot divide by zero."),
            _ => throw new ArgumentException("Unsupported operation.", nameof(operation))
        };
    }
}
