namespace DimensionsOfMeasurement.Units
{
    public static class Acceleration
    {
        public static readonly UnitOfMeasure MeterPerSecondSquared = UnitFactory.Create(
            "m/s²",
            (Length.Meter, 1),
            (Time.Second, -2));

        public static readonly UnitOfMeasure FootPerSecondSquared = UnitFactory.Create(
            "ft/s²",
            (Length.Foot, 1),
            (Time.Second, -2));
    }
}
