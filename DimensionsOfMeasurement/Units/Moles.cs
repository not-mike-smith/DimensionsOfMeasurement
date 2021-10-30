using UOM = DimensionsOfMeasurement.UnitOfMeasure;

namespace DimensionsOfMeasurement.Units
{
    public static class Moles
    {
        public static readonly UOM Kilomole = UnitFactory.Create(Dimensionality.AmountOfMatter, "kmol", 1);
        public static readonly UOM Mole = UnitFactory.Create(Kilomole, "mol", 0.001);
        public static readonly UOM Millimole = Metric.m(Mole);
        public static readonly UOM Micromole = Metric.micro(Mole);
        public static readonly UOM Nanomole = Metric.n(Mole);
        public static readonly UOM Megamole = Metric.M(Mole);
    }
}
