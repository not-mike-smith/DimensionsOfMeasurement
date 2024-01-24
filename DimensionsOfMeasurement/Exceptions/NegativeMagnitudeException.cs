using System;

namespace DimensionsOfMeasurement.Exceptions;

public class NegativeMagnitudeException : InvalidOperationException
{
    internal NegativeMagnitudeException(string message) : base(message)
    {

    }
}
