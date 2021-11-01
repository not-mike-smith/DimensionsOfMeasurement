using Uom = DimensionsOfMeasurement.UnitOfMeasure;

namespace DimensionsOfMeasurement.Units
{
    public static class Volume
    {
        public static readonly Uom CubicMeter = UnitFactory.Create("m³", (Length.Meter, 3));
        public static readonly Uom CubicFoot = UnitFactory.Create("ft³", (Length.Foot, 3));
        public static readonly Uom CubicInch = UnitFactory.Create("in³", (Length.Inch, 3));
        public static readonly Uom CubicCentimeter = UnitFactory.Create("cc", (Length.Centimeter, 3));
        public static readonly Uom Milliliter = UnitFactory.Create(CubicCentimeter, "mL", 1);
        public static readonly Uom Liter = UnitFactory.Create(Milliliter, "L", 1000);

        public static readonly Uom Gallon = UnitFactory.Create(CubicInch, "gal", 231);
        public static readonly Uom Quart = UnitFactory.Create(Gallon, "qt", 0.25);
        public static readonly Uom Pint = UnitFactory.Create(Quart, "pt", 0.5);
        public static readonly Uom Cup = UnitFactory.Create(Pint, "cup", 0.5);
        public static readonly Uom Tablespoon = UnitFactory.Create(Cup, "tbsp", 1d / 16);
        public static readonly Uom Teaspoon = UnitFactory.Create(Cup, "tsp", 1d / 48);
        public static readonly Uom FluidOunce = UnitFactory.Create(Cup, "fl oz", 0.125);

        public static readonly Uom ImperialGallon = UnitFactory.Create(Liter, "imp gal", 4.54609);
        public static readonly Uom ImperialQuart = UnitFactory.Create(ImperialGallon, "imp qt", 0.25);
        public static readonly Uom ImperialPint = UnitFactory.Create(ImperialQuart, "imp pt", 0.5);
        public static readonly Uom ImperialCup = UnitFactory.Create(ImperialPint, "imp cup", 0.5);
        public static readonly Uom ImperialFluidOunce = UnitFactory.Create(ImperialCup, "imp fl oz", 0.125);

        public static readonly Uom MetricCup = UnitFactory.Create(Milliliter, "m cup", 250);
    }
}
