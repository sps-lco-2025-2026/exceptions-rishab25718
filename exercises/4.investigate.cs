// Snippet A
try
{
    int[] arr = new int[3];
    arr[10] = 5;
}


catch (IndexOutOfRangeException e)
{
    Console.WriteLine($"{e.Message}");
}

// Snippet B
try
{
    string s = null!;
    Console.WriteLine(s.Length);
}

catch (ArgumentNullException e)
{
    Console.WriteLine($"The string is null: {e.Message}");
}

// Snippet C
try
{
    int x = int.MaxValue;
    checked { x = x + 1; }   // checked enforces overflow detection
}

catch (OverflowException e)
{
    Console.WriteLine($"Too large: {e.Message}");
}
