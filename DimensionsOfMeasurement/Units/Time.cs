using Uom = DimensionsOfMeasurement.UnitOfMeasure;

namespace DimensionsOfMeasurement.Units
{
    public static class Time
    {
        public static readonly Uom Second = UnitFactory.Create(Dimensionality.Time, "s", 1);
        public static readonly Uom Minute = UnitFactory.Create(Second, "min", 60);
        public static readonly Uom Hour = UnitFactory.Create(Minute, "h", 60);
        public static readonly Uom Day = UnitFactory.Create(Hour, "day", 24);
        public static readonly Uom Week = UnitFactory.Create(Day, "wk", 7);
        public static readonly Uom Fortnight = UnitFactory.Create(Week, "fortnight", 2);
        public static readonly Uom GregorianYear = UnitFactory.Create(Day, "yr", 365.2425);
        public static readonly Uom JulianYear = UnitFactory.Create(Day, "Jyr", 365.25);
        public static readonly Uom CommonYear = UnitFactory.Create(Day, "common-yr", 365);

        public static readonly Uom Millisecond = Metric.m(Second);
        public static readonly Uom Microsecond = Metric.micro(Second);
        public static readonly Uom Nanosecond = Metric.n(Second);
        public static readonly Uom Picosecond = Metric.p(Second);
        public static readonly Uom Femtosecond = Metric.f(Second);
        public static readonly Uom Attosecond = Metric.a(Second);
        public static readonly Uom Zeptosecond = Metric.z(Second);
        public static readonly Uom Yoctosecond = Metric.y(Second);

        public static readonly Uom PlankTime = UnitFactory.Create(Second, "𝘵ₚ", 5.39056E-44);
        public static readonly Uom Jiffy = UnitFactory.Create(Second, "jiffy", 3E-24);
        public static readonly Uom Svedberg = UnitFactory.Create(Second, "Sv", 1E-13);
        public static readonly Uom Shake = UnitFactory.Create(Second, "shake", 1E-8);
    }
}
