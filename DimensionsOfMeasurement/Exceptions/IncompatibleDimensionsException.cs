using System;

namespace DimensionsOfMeasurement.Exceptions;

public class IncompatibleDimensionsException : InvalidOperationException
{
    public IncompatibleDimensionsException(string message) : base(message)
    {

    }
}
