using System;

namespace DimensionsOfMeasurement.Exceptions
{
    public class NondiscreteDimensionalityException : InvalidOperationException
    {
        internal NondiscreteDimensionalityException(string message) : base(message)
        {

        }
    }
}
