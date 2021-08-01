using System.Collections.Generic;

namespace DimensionsOfMeasurement.Units
{
    public static class Temperature
    {
        public static readonly UnitOfMeasure Kelvin = UnitFactory.Create(
            Dimensionality.Temperature,
            "K",
            1);

        public static readonly OffsetUnitOfMeasure Celsius = UnitFactory.Create(
            Kelvin,
            "°C",
            1,
            273.15);

        public static readonly UnitOfMeasure DeltaCelsius = UnitFactory.Create(
            Kelvin,
            "Δ°C",
            1);

        public static readonly UnitOfMeasure Rankine = UnitFactory.Create(
            Dimensionality.Temperature,
            "°R",
            1.8);

        public static readonly OffsetUnitOfMeasure Fahrenheit = UnitFactory.Create(
            Rankine,
            "°F",
            1,
            459.67);

        public static readonly UnitOfMeasure DeltaFahrenheit = UnitFactory.Create(
            Rankine,
            "Δ°F",
            1);

        public static readonly IReadOnlyList<UnitOfMeasure> All = new[]
        {
            Kelvin,
            Celsius,
            DeltaCelsius,
            Rankine,
            Fahrenheit,
            DeltaFahrenheit,
        };
    }
}
