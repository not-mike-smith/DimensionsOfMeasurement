// using System.Collections.Generic;
//
// namespace DimensionsOfMeasurement.Units
// {
//     public static class Length
//     {
//         public static readonly UnitOfMeasure Meter = UnitFactory.Create(
//             Dimensionality.Length,
//             "m",
//             1);
//
//         public static readonly UnitOfMeasure Kilometer = UnitFactory.Create(
//             Meter,
//             "km",
//             1000);
//
//         public static IReadOnlyList<UnitOfMeasure> All = new[]
//         {
//             Meter,
//             Kilometer
//         };
//     }
//
//     public static class Time
//     {
//         public static readonly UnitOfMeasure Second = UnitFactory.Create(
//             Dimensionality.Time,
//             "s",
//             1);
//
//         public static readonly UnitOfMeasure Minute = UnitFactory.Create(
//             Second,
//             "min",
//             60);
//
//         public static IReadOnlyList<UnitOfMeasure> All = new[]
//         {
//             Second,
//             Minute
//         };
//     }
//
//     public static class Velocity
//     {
//         public static readonly UnitOfMeasure MeterPerSecond = UnitFactory.Create(
//             Dimensionality.Length / Dimensionality.Time,
//             "m/s",
//             1);
//
//         public static readonly UnitOfMeasure KilometerPerSecond = UnitFactory.Create(
//             (Length.Kilometer, 1),
//             (Time.Second, -1));
//
//         public static IReadOnlyList<UnitOfMeasure> All = new[]
//         {
//             MeterPerSecond,
//             KilometerPerSecond
//         };
//     }
//
//     public static class Energy
//     {
//         public static readonly UnitOfMeasure Joule = UnitFactory.Create(
//             // "J",
//             (Mass.Kilogram, 1),
//             (Length.Meter, 2),
//             (Time.Second, -2));
//     }
// }
