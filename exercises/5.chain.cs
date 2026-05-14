
int Divide(int a, int b)
{
    try
    {
        return a / b;
    }

    catch (DivideByZeroException)
    {
        throw new ArgumentException("Denominator cannot be zero.", ex);
    }
}

int ReadAndDivide()
{
    Console.Write("Numerator: ");
    int a = int.Parse(Console.ReadLine()!);
    Console.Write("Denominator: ");
    int b = int.Parse(Console.ReadLine()!);
    return Divide(a, b);
}

Console.WriteLine(ReadAndDivide());