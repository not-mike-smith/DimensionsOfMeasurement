namespace DimensionsOfMeasurement.Units
{
    public static class ElectricCurrent
    {
        public static readonly UnitOfMeasure Ampere = UnitFactory.Create(Dimensionality.ElectricCurrent, "A", 1);
        public static readonly UnitOfMeasure Milliamp = Metric.m(Ampere);
        public static readonly UnitOfMeasure Microamp = Metric.micro(Ampere);
        public static readonly UnitOfMeasure Nanoamp = Metric.n(Ampere);
        public static readonly UnitOfMeasure Kiloamp = Metric.k(Ampere);
        public static readonly UnitOfMeasure ElectronsPerSec = UnitFactory.Create(Ampere, "e⁻/s", 1/ElectricCharge.ElectronsInCoulomb);
    }
}
