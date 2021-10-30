﻿using DimensionsOfMeasurement.Units;
using FluentAssertions;
using Xunit;

namespace DimensionsOfMeasurement.Test
{
    public class MassTests
    {
        [Fact]
        public void SpotTest()
        {
            Mass.Pound.ConvertFromKmsValue(1).Should().BeApproximately(2.2, 0.1);
            Mass.Pound.ConvertToKmsValue(2.2).Should().BeApproximately(1, 0.05);
            Mass.Gram.ConvertFromKmsValue(1).Should().Be(1000);
            Mass.Milligram.ConvertFromKmsValue(1).Should().Be(1E6);
        }
    }
}
