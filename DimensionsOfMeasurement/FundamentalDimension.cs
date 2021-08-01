﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DimensionsOfMeasurement
{
    public class FundamentalDimension : IComparable<FundamentalDimension>
    {
        public string Name { get; }
        public string Symbol { get; }

        protected FundamentalDimension(string name, string symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public static readonly FundamentalDimension Mass = new FundamentalDimension("Mass", "M");
        public static readonly FundamentalDimension Length = new FundamentalDimension("Length", "L");
        public static readonly FundamentalDimension Temperature = new FundamentalDimension("Temperature", "T");
        public static readonly FundamentalDimension ElectricCurrent = new FundamentalDimension("Electric Current", "I");
        public static readonly FundamentalDimension Angle = new FundamentalDimension("Angle", "A");
        public static readonly FundamentalDimension Time = new FundamentalDimension("Time", "t");
        public static readonly FundamentalDimension AmountOfMatter = new FundamentalDimension("Amount of Matter", "N");

        public static readonly FundamentalDimension LuminousIntensity =
            new FundamentalDimension("Luminous Intensity", "C");

        public static readonly FundamentalDimension Currency = new FundamentalDimension("Currency", "c");

        internal static readonly IReadOnlyDictionary<FundamentalDimension, int> Order = new Dictionary<FundamentalDimension, int>
        {
            { Currency, 0 },
            { AmountOfMatter, 1 },
            { Mass, 2 },
            { LuminousIntensity, 3 },
            { ElectricCurrent, 4 },
            { Length, 5 },
            { Temperature, 6 },
            { Angle, 7 },
            { Time, 8 },
        };

        public static readonly IReadOnlyList<FundamentalDimension> All = Order.Keys.ToList();

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return (obj as FundamentalDimension)?.Name == Name;
        }

        public override string ToString()
        {
            return Symbol;
        }

        public int CompareTo(FundamentalDimension? other)
        {
            if (other == null) return -1;
            return Order[this] - Order[other!];
        }
    }
}
