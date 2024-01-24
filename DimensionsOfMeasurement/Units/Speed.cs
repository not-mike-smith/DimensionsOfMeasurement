using Uom = DimensionsOfMeasurement.UnitOfMeasure;

namespace DimensionsOfMeasurement.Units;

public static class Speed
{
    public static readonly Uom MeterPerSecond = UnitFactory.Create(
        "m/s",
        (Length.Meter, 1),
        (Time.Second, -1));

    public static readonly Uom FootPerSecond = UnitFactory.Create(
        "ft/s",
        (Length.Foot, 1),
        (Time.Second, -1));

    public static readonly Uom Kph = UnitFactory.Create(
        "kph",
        (Length.Kilometer, 1),
        (Time.Second, -1));

    public static readonly Uom Mph = UnitFactory.Create(
        "mph",
        (Length.Mile, 1),
        (Time.Hour, -1));

    public static readonly Uom Knot = UnitFactory.Create(
        "knot",
        (Length.NauticalMile, 1),
        (Time.Hour, -1));

    public static readonly Uom Mach = UnitFactory.Create("mach", 1235, Kph);
    public static readonly Uom LightSpeed = UnitFactory.Create("c", 299792458, MeterPerSecond);
}
