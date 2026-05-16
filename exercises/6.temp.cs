using System;

class TemperatureException : Exception
{
    public TemperatureException()
    {
    }

    public TemperatureException(string message)
        : base(message)
    {
    }

    public TemperatureException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

class AbsoluteZeroError : TemperatureException
{
    public decimal temperature { get; }
}

// program below...

Console.WriteLine("Enter temperature in Celcius: ");

try
{
    double TemperatureCelcius = double.Parse(Console.ReadLine()!);

    if (TemperatureCelcius < -273.15)
    {
        throw new TemperatureException("Temperature is below absolute zero");
    }

    double TemperatureFarenheit = TemperatureCelcius * 9 / 5 + 32;

    Console.WriteLine($"{TemperatureCelcius}°C = {TemperatureFarenheit}°F");
}
catch (TemperatureException e)
{
    Console.WriteLine($"Temperature error: {e.Message}");
}
catch (FormatException)
{
    Console.WriteLine("Enter a valid temperature");
}