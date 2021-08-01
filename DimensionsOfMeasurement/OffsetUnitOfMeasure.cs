using System;

namespace DimensionsOfMeasurement
{
    public class OffsetUnitOfMeasure : UnitOfMeasure
    {
        protected readonly double ZeroOffset;

        internal OffsetUnitOfMeasure(
            Dimensionality dimensionality,
            string symbol,
            double kmsConversionFactor,
            double zeroOffset)
            : base (dimensionality, symbol, kmsConversionFactor)
        {
            if (double.IsNaN(zeroOffset))
            {
                throw new ArgumentException( "zero offset cannot be NaN", nameof(zeroOffset));
            }

            if (double.IsInfinity(zeroOffset))
            {
                throw new ArgumentException("zero offset must be finite", nameof(zeroOffset));
            }

            ZeroOffset = zeroOffset;
        }

        public override double ConvertToKmsValue(double value)
        {
            return (value + ZeroOffset) * KmsConversionFactor;
        }

        public override double ConvertFromKmsValue(double value)
        {
            return value / KmsConversionFactor - ZeroOffset;
        }
    }
}
