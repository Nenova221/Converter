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
            float result = MetricAndImperialConverter.Convert(lenght, unit);
            Assert.Equal(expectedresult, result, 2);
        }
        [Theory]
        [InlineData(257, 'G', 846)]
        [InlineData(244, 'P', 8523)]
        public void Converter_WithInvalidUnit_ShouldThrowExeption(float lenght, char unit, float expectedresult)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => MetricAndImperialConverter.Convert(lenght, unit));
        }
        [Theory]
        [InlineData(234, 'K', 146.2)]
        [InlineData(322, 'm', 515.2)]
        public void Converter_WithConvertMethricAndImperial1_ShouldReturnCorrect(float lenght, char unit, float expectedresult)
        {
            float result = MetricAndImperialConverter.Convert1(lenght, unit);
            Assert.Equal(expectedresult, result, 1);
        }
        [Theory]
        [InlineData(456, 'd', 520)]
        [InlineData(199, 'J', 43)]
        public void Converter_WithInvalidUnitShouldThrowExeption(float lenght, char unit, float expectedresult)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => MetricAndImperialConverter.Convert1(lenght, unit));
        }       
    }
}
