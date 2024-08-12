using Converter;
using System;
namespace ConverterTest
{
    public class ConverterTest
    {
        [Theory]
        [InlineData(212, 'F', 100)]
        [InlineData(41, 'F', 5)]
        [InlineData(0, 'C', 32)]
        [InlineData(548, 'C', 1018.4)]
        public void Converter_WithConvertDegrees_ShouldReturnCorrectDegrees(float degrees, char unit,float expectedresult)
        {
           float result = DegreeConverter.Convert(degrees, unit);
           Assert.Equal(expectedresult, result);   
        }
        [Theory]
        [InlineData(200, 'Q', 162)]
        [InlineData(14, 'M', 349)]

        public void Converter_InvalidUnit_ShouldThrowExeption(float degrees, char unit,float expectedresult)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => DegreeConverter.Convert(degrees,unit));
        }
    }
}