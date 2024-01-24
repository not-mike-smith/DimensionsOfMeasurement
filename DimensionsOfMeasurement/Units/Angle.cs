using System;

namespace DimensionsOfMeasurement.Units;

public static class Angle
{
    public static UnitOfMeasure Radian = UnitFactory.Create("rad", Dimensionality.Angle, 1);
    public static UnitOfMeasure Milliradian = Metric.m(Radian);
    public static UnitOfMeasure Revolution = UnitFactory.Create("rev", 2 * Math.PI, Radian);
    public static UnitOfMeasure Degree = UnitFactory.Create("°", Math.PI / 180, Radian);
    public static UnitOfMeasure ArcMinute = UnitFactory.Create("′", 60, Degree);
    public static UnitOfMeasure ArcSecond = UnitFactory.Create("″", 60, ArcMinute);
    public static UnitOfMeasure Gradian = UnitFactory.Create("grad", 400, Revolution);
}
