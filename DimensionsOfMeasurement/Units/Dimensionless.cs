using System;
using Uom = DimensionsOfMeasurement.UnitOfMeasure;

namespace DimensionsOfMeasurement.Units
{
    public static class Dimensionless
    {
        public static readonly Uom One = UnitFactory.Create(Dimensionality.Dimensionless, "unit", 1);

        public static readonly Uom Dozen = UnitFactory.Create(One, "dz", 12);
        public static readonly Uom Gross = UnitFactory.Create(Dozen, "gr", 12);
        public static readonly Uom EddyCorrectionFactor = UnitFactory.Create(One, "🇪", (0.1 + 0.1 + 0.1) / 3 * 10);

        public static readonly Uom ReynoldsNumber = UnitFactory.Create(One, "Re", 1);

        public static readonly Uom FineStructureConstant = UnitFactory.Create(One, "α", 1d / 137.03599908);

        public static readonly Uom FeigenbaumConstant = UnitFactory.Create(One, "δ", 4.66920160910299);

        public static UnitOfMeasure FeigenbaumAlphaConstant = UnitFactory.Create(One, "α", 2.50290787509589);
    }
}
