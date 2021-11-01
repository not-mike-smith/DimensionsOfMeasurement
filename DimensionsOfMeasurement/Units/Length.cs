using System;
using Uom = DimensionsOfMeasurement.UnitOfMeasure;

namespace DimensionsOfMeasurement.Units
{
    public static class Length
    {
        public static readonly Uom Meter = UnitFactory.Create(Dimensionality.Length, "m", 1);
        public static readonly Uom Kilometer = Metric.k(Meter);
        public static readonly Uom Megameter = Metric.M(Meter);
        public static readonly Uom Decimeter = Metric.d(Meter);
        public static readonly Uom Centimeter = Metric.c(Meter);
        public static readonly Uom Millimeter = Metric.m(Meter);
        public static readonly Uom Micron = Metric.micro(Meter);
        public static readonly Uom Nanometer = Metric.n(Meter);
        public static readonly Uom Picometer = Metric.p(Meter);
        public static readonly Uom Femtometer = Metric.f(Meter);
        public static readonly Uom Attometer = Metric.a(Meter);
        public static readonly Uom Zeptometer = Metric.z(Meter);
        public static readonly Uom Yoctometer = Metric.y(Meter);

        // Imperial
        public static readonly Uom Foot = UnitFactory.Create(Meter, "ft", 0.3048);
        public static readonly Uom Inch = UnitFactory.Create(Foot, "in", 1d/12);
        public static readonly Uom Thou = UnitFactory.Create(Inch, "thou", 1000);
        public static readonly Uom Yard = UnitFactory.Create(Foot, "yd", 3);
        public static readonly Uom Mile = UnitFactory.Create(Foot, "mi", 5280);

        // Atomic
        public static readonly Uom Angstrom = UnitFactory.Create(Meter, "Å", 1E10);
        public static readonly Uom XUnit = UnitFactory.Create(Meter, "xu", 1d/1.0021E-13);
        public static readonly Uom PlanckLength = UnitFactory.Create(Meter, "ℓₚ", 1d / 1.61625518E-35);
        public static readonly Uom BohrRadius = UnitFactory.Create(Meter, "a₀", 1d / 5.2917721090380E-11);

        // Astronomical
        public static readonly Uom AstronomicalUnit = UnitFactory.Create(Meter, "au", 149597870700);
        public static readonly Uom LightYear = UnitFactory.Create(Meter, "ly", 9460730472580800);
        public static readonly Uom Parsec = UnitFactory.Create(AstronomicalUnit, "pc", 180d * 60 * 60 / Math.PI);

        // Nautical
        public static readonly Uom NauticalMile = UnitFactory.Create(Meter, "NM", 1d / 1852);
        public static readonly Uom Cable = UnitFactory.Create(NauticalMile, "cable", 10);
        public static readonly Uom Fathom = UnitFactory.Create(Yard, "fathom", 0.5);

        // Surveying
        public static readonly Uom Chain = UnitFactory.Create(Yard, "Chain", 22);
        public static readonly Uom Rod = UnitFactory.Create(Chain, "rod", 0.25);
    }
}
