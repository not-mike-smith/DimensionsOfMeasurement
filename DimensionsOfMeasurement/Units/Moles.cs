using Uom = DimensionsOfMeasurement.UnitOfMeasure;

namespace DimensionsOfMeasurement.Units
{
    public static class Moles
    {
        public static readonly Uom Kilomole = UnitFactory.Create(Dimensionality.AmountOfMatter, "kmol", 1);
        public static readonly Uom Mole = UnitFactory.Create(Kilomole, "mol", 0.001);
        public static readonly Uom Millimole = Metric.m(Mole);
        public static readonly Uom Micromole = Metric.micro(Mole);
        public static readonly Uom Nanomole = Metric.n(Mole);
        public static readonly Uom Megamole = Metric.M(Mole);
    }
}
