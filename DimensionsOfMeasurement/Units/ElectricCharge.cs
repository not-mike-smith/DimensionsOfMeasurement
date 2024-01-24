namespace DimensionsOfMeasurement.Units;

public static class ElectricCharge
{
    public const double ElectronsInCoulomb = 6.241509074E18;

    public static readonly UnitOfMeasure Coulomb = UnitFactory.Create("C",
        Dimensionality.ElectricCurrent * Dimensionality.Time, 1);

    public static readonly UnitOfMeasure FundamentalCharge = UnitFactory.Create("e⁻", 1 / ElectronsInCoulomb, Coulomb);
}
