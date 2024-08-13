using Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterTest
{
    public class MetricAndImperialConverterTest
    {
        [Theory]
        [InlineData(234, 'M', 767.72)]
        [InlineData(780, 'F', 237.74)]
        [InlineData(338, 'M', 1108.92)]
        public void Converter_WithConvertMethricAndImperial_ShouldReturnCorrect(float lenght, char unit, float expectedresult)
        {
            float result = MetricAndImperialConverter.ConvertMeterToFoot(lenght, unit);
            Assert.Equal(expectedresult, result, 2);
        }
        [Theory]
        [InlineData(257, 'G', 846)]
        [InlineData(244, 'P', 8523)]
        public void Converter_WithInvalidUnit_ShouldThrowExeption(float lenght, char unit, float expectedresult)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => MetricAndImperialConverter.ConvertMeterToFoot(lenght, unit));
        }
        [Theory]
        [InlineData(234, 'K', 146.2)]
        [InlineData(322, 'm', 515.2)]
        public void Converter_WithConvertMethricAndImperial1_ShouldReturnCorrect(float lenght, char unit, float expectedresult)
        {
            float result = MetricAndImperialConverter.ConvertKilometersToMiles(lenght, unit);
            Assert.Equal(expectedresult, result, 1);
        }
        [Theory]
        [InlineData(456, 'd', 520)]
        [InlineData(199, 'J', 43)]
        public void Converter_WithInvalidUnitShouldThrowExeption1(float lenght, char unit, float expectedresult)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => MetricAndImperialConverter.ConvertKilometersToMiles(lenght, unit));
        }
        [Theory]
        [InlineData(149, "cm", 58.66)]
        [InlineData(234, "in", 594.36)]
        public void Converter_WithConvertMethricAndImperial2_ShouldReturnCorrect(float height, string unit, float expectedresult)
        {
            float result = MetricAndImperialConverter.ConvertCentimetersToInches(height, unit);
            Assert.Equal(expectedresult, result,2);
        }
        [Theory]
        [InlineData(456, "km", 520)]
        [InlineData(199, "kW", 43)]
        public void Converter_WithInvalidUnitShouldThrowExeption2(float lenght, string unit, float expectedresult)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => MetricAndImperialConverter.ConvertCentimetersToInches(lenght, unit));
        }
        [Theory]
        [InlineData(504, "ib", 36)]
        [InlineData(142, "st", 1988)]
        public void Converter_WithConvertMethricAndImperial3_ShouldReturnCorrect(float height, string unit, float expectedresult)
        {
            float result = MetricAndImperialConverter.ConvertPoundsToStone(height, unit);
            Assert.Equal(expectedresult, result, 1);
        }
        [Theory]
        [InlineData(54, "cm", 363)]
        [InlineData(1345, "km", 48)]
        public void Converter_WithInvalidUnitShouldThrowExeption3(float height, string unit, float expectedresult)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => MetricAndImperialConverter.ConvertPoundsToStone(height, unit));
        }
    }
}
