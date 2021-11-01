namespace DimensionsOfMeasurement.Units
{
    public static class ElectricCharge
    {
        public const double ElectronsInCoulomb = 6.241509074E18;

        public static readonly UnitOfMeasure Coulomb = UnitFactory.Create(
            Dimensionality.ElectricCurrent * Dimensionality.Time,
            "C",
            1);

        public static readonly UnitOfMeasure FundamentalCharge = UnitFactory.Create(Coulomb, "e⁻", 1 / ElectronsInCoulomb);
    }
}
