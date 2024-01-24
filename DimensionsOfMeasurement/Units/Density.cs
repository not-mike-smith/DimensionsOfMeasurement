﻿using Uom = DimensionsOfMeasurement.UnitOfMeasure;

namespace DimensionsOfMeasurement.Units;

public static class Density
{
    public static readonly Uom KgPerM3 = UnitFactory.Create(
        (Mass.Kilogram, 1),
        (Volume.CubicMeter, -1));

    public static readonly Uom KgPerLiter = UnitFactory.Create(
        (Mass.Kilogram, 1),
        (Volume.Liter, -1));

    public static readonly Uom GramPerCc = UnitFactory.Create(
        (Mass.Gram, 1),
        (Length.Centimeter, -3));

    public static readonly Uom LbPerCubicFoot = UnitFactory.Create(
        (Mass.Pound, 1),
        (Length.Foot, -3));

    public static readonly Uom LbPerGal = UnitFactory.Create(
        (Mass.Pound, 1),
        (Volume.Gallon, -1));
}
