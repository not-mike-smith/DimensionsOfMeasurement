namespace DimensionsOfMeasurement.Units
{
    public static class Mass
    {
        public static readonly UnitOfMeasure Kilogram = UnitFactory.Create(
            Dimensionality.Mass,
            "kg",
            1);

        public static readonly UnitOfMeasure Gram = UnitFactory.Create(
            Kilogram,
            "g",
            0.001);

        public static readonly UnitOfMeasure Milligram = UnitFactory.Create("m", Gram);
    }
}
