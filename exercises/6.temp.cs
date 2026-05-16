using System;


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
    Console.WriteLine($"Attempted value: {e.AttemptedValue}");
}
catch (FormatException)
{
    Console.WriteLine("Enter a valid temperature");
}

//exception classes
class TemperatureException : Exception
{

    public double AttemptedValue { get;}
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


