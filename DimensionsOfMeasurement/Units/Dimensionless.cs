﻿using System;
using Uom = DimensionsOfMeasurement.UnitOfMeasure;

namespace DimensionsOfMeasurement.Units;

public static class Dimensionless
{
    public static readonly Uom One = UnitFactory.Create("unit", Dimensionality.Dimensionless, 1);

    public static readonly Uom Percent = UnitFactory.Create("%", 0.01, One);
    public static readonly Uom PerMille = UnitFactory.Create("‰", 0.001, One);

    public static readonly Uom Dozen = UnitFactory.Create("dz", 12, One);
    public static readonly Uom Gross = UnitFactory.Create("gr", 12, Dozen);
    public static readonly Uom EddyCorrectionFactor = UnitFactory.Create("🇪", (0.1 + 0.1 + 0.1) / 3 * 10, One);

    public static readonly Uom ReynoldsNumber = UnitFactory.Create("Re", 1, One);

    public static readonly Uom FineStructureConstant = UnitFactory.Create("α", 1d / 137.03599908, One);

    public static readonly Uom FeigenbaumConstant = UnitFactory.Create("δ", 4.66920160910299, One);

    public static UnitOfMeasure FeigenbaumAlphaConstant = UnitFactory.Create("α", 2.50290787509589, One);
}
