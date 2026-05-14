Console.Write("Enter a number: ");

try
{
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine(100 / n);
}

catch (FormatException e)
{
    Console.WriteLine($"That is not an integer: {e.Message}");
}

catch (DivideByZeroException)
{
    Console.WriteLine("You can't divide by zero");
}
