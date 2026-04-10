using MathFunctio;

Console.Write("Enter the first whole number: ");
if (!int.TryParse(Console.ReadLine(), out var firstNumber))
{
    Console.WriteLine("The first value must be a whole number.");
    return;
}

Console.Write("Enter the second whole number: ");
if (!int.TryParse(Console.ReadLine(), out var secondNumber))
{
    Console.WriteLine("The second value must be a whole number.");
    return;
}

Console.Write("Enter the operation (addition, subtraction, multiplication, division): ");
var operation = Console.ReadLine();

if (string.IsNullOrWhiteSpace(operation))
{
    Console.WriteLine("You must enter a supported operation.");
    return;
}

try
{
    var result = Calculator.Calculate(firstNumber, secondNumber, operation);
    Console.WriteLine($"Result: {result}");
}
catch (Exception exception) when (exception is ArgumentException or DivideByZeroException)
{
    Console.WriteLine(exception.Message);
}
