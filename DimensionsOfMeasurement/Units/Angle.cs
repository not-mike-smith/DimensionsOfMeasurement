using System;

namespace DimensionsOfMeasurement.Units
{
    public static class Angle
    {
        public static UnitOfMeasure Radian = UnitFactory.Create(Dimensionality.Angle, "rad", 1);
        public static UnitOfMeasure Milliradian = Metric.m(Radian);
        public static UnitOfMeasure Revolution = UnitFactory.Create(Radian, "rev", 2 * Math.PI);
        public static UnitOfMeasure Degree = UnitFactory.Create(Radian, "°", Math.PI / 180);
        public static UnitOfMeasure ArcMinute = UnitFactory.Create(Degree, "′", 60);
        public static UnitOfMeasure ArcSecond = UnitFactory.Create(ArcMinute, "″", 60);
        public static UnitOfMeasure Gradian = UnitFactory.Create(Revolution, "grad", 400);
    }
}
