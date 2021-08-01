using System;
using System.Collections.Generic;
using System.Linq;
using DimensionsOfMeasurement.Extensions;

namespace DimensionsOfMeasurement
{
    public static class UnitFactory
    {
        public static UnitOfMeasure Create(
            Dimensionality dimensionality,
            string symbol,
            double kmsConversionFactor)
        {
            return new UnitOfMeasure(dimensionality, symbol, kmsConversionFactor);
        }

        public static UnitOfMeasure Create(
            UnitOfMeasure unitOfMeasure,
            string symbol,
            double scale)
        {
            if (scale == 0)
                throw new DivideByZeroException("Unit of measure conversion factor cannot be zero");

            if (scale < 0)
                throw new InvalidOperationException("Unit of measure conversion factor must be positive");

            var dimensionality = (unitOfMeasure ?? throw new ArgumentNullException(nameof(unitOfMeasure))).Dimensionality;
            var kmsConversionFactor = unitOfMeasure.KmsConversionFactor * scale;
            return new UnitOfMeasure(dimensionality, symbol, kmsConversionFactor);
        }

        public static UnitOfMeasure Create(
            string symbol,
            params (UnitOfMeasure unitOfMeasure, int exponent)[] constituentUnits)
        {
            var dimensionality = ReduceDimensions(constituentUnits);
            var kmsConversionFactor = ReduceKmsConversionFactor(constituentUnits);
            return new UnitOfMeasure(dimensionality, symbol, kmsConversionFactor);
        }

        public static UnitOfMeasure Create(
            params (UnitOfMeasure unitOfMeasure, int exponent)[] constituentUnits)
        {
            var symbol = ReduceSymbols(constituentUnits);
            var dimensionality = ReduceDimensions(constituentUnits);
            var kmsConversionFactor = ReduceKmsConversionFactor(constituentUnits);

            return new UnitOfMeasure(dimensionality, symbol, kmsConversionFactor);
        }

        public static OffsetUnitOfMeasure Create(
            UnitOfMeasure unitOfMeasure,
            string symbol,
            double kmsConversionFactor,
            double zeroOffset)
        {
            return new OffsetUnitOfMeasure(
                unitOfMeasure.Dimensionality,
                symbol,
                kmsConversionFactor,
                zeroOffset);
        }

        public static Dimensionality ReduceDimensions((UnitOfMeasure unitOfMeasure, int exponent)[] constituentUnits)
        {
            return constituentUnits.Aggregate(
                Dimensionality.Dimensionless,
                (d, tuple) => d * (tuple.unitOfMeasure.Dimensionality * tuple.exponent));
        }

        public static double ReduceKmsConversionFactor((UnitOfMeasure unitOfMeasure, int exponent)[] constituentUnits)
        {
            return constituentUnits.Aggregate(
                1d,
                (factor, tuple) => factor * Math.Pow(tuple.unitOfMeasure.KmsConversionFactor, tuple.exponent));
        }

        public static string ReduceSymbols((UnitOfMeasure unitOfMeasure, int exponent)[] constituentUnits)
        {
            var numerators = constituentUnits.Where(t => t.exponent > 0)
                .Select(t => t.exponent == 1
                    ? t.unitOfMeasure.Symbol
                    : $"{t.unitOfMeasure.Symbol}{t.exponent.ToSuperscript()}");

            var numerator = string.Join('·', numerators);
            numerator = numerator.Length == 0 ? "1" : numerator;
            var denominators = constituentUnits.Where(t => t.exponent < 0)
                .Select(t => t.exponent == -1
                    ? t.unitOfMeasure.Symbol
                    : $"{t.unitOfMeasure.Symbol}{(-t.exponent).ToSuperscript()}");

            var denominator = string.Join('·', denominators);
            return denominator.Length == 0 ? numerator : $"{numerator}/{denominator}";
        }

        public static UnitOfMeasure Create(string siPrefix, UnitOfMeasure unitOfMeasure)
        {
            if (siPrefix == "micro")
            {
                siPrefix = "μ";
            }

            return new UnitOfMeasure(
                unitOfMeasure.Dimensionality,
                siPrefix + unitOfMeasure.Symbol,
                SiPrefixes[siPrefix] * unitOfMeasure.KmsConversionFactor);
        }

        private static readonly IReadOnlyDictionary<string, double> SiPrefixes = new Dictionary<string, double>
        {
            {"k", 1E3},
            {"M", 1E6},
            {"G", 1E9},
            {"T", 1E12},
            {"P", 1E15},
            {"E", 1E18},
            {"Z", 1E21},
            {"Y", 1E24},

            {"d", 1E-1},
            {"c", 1E-2},
            {"m", 1E-3},
            {"μ", 1E-6},
            {"n", 1E-9},
            {"p", 1E-12},
            {"f", 1E-15},
            {"a", 1E-18},
            {"z", 1E-21},
            {"y", 1E-24},
        };
    }
}
