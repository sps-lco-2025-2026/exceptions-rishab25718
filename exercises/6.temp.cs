
class CONSTANTS
{
    public decimal ABSOLUTEZERO = -273.15;
}

class TemperatureException : Exception
{
    // your constructors here

    public TemperatureException();

    public TemperatureException(string message)
    {
        base(message);
    }

    public TemperatureException(string message, Exception inner)
    {
        base(message, inner);
    }
}

class AbsoluteZeroError : TemperatureException
{
    public decimal temperature { get; }

    if (decimal temperature < CONSTANTS.ABSOLUTEZERO)
    {
        
    }
}

// program below...


decimal temperature = 0m;
