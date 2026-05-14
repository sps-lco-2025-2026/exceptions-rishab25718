// exercise 3

Console.WriteLine("Enter an integer:");
var input = Console.ReadLine();

try
{
    int num = int.Parse(input);
}

catch (FormatException e)
{
    Console.WriteLine($"That is not an integer: {e.Message}");
}

if (num % 2 == 0)
{
    Console.WriteLine("Even");
}

else if (num % 2 == 1)
{
    Console.WriteLine("Odd");
}

