namespace DimensionsOfMeasurement.Units
{
    public static class Jerk
    {
        public static readonly UnitOfMeasure MeterPerSecondCubed = UnitFactory.Create(
            "m/s³",
            (Length.Meter, 1),
            (Time.Second, -3));

        public static readonly UnitOfMeasure FootPerSecondCubed = UnitFactory.Create(
            "ft/s³",
            (Length.Foot, 1),
            (Time.Second, -3));
    }
}
