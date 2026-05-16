string[] names = { "Alice", "Bob", "Charlie" };
Console.Write("Enter an index: ");

try
{
    int i = int.Parse(Console.ReadLine()!);
    Console.WriteLine(names[i]);
}

catch (FormatException e)
{
    Console.WriteLine($"That is not an integer:  {e.Message}");
}

catch (IndexOutOfRangeException e)
{
    Console.WriteLine($"That index is too big: {e.Message}");
}
