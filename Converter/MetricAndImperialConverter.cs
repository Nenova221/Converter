using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class MetricAndImperialConverter
    {
        public static float ConvertMeterToFoot(float lenght, char unit)
        {
            if (unit == 'M')
            {
                return (float)(lenght * 3.2808399);
            }
            if (unit == 'F')
            {
                return (float)(lenght / 3.2808399);
            }
            throw new ArgumentOutOfRangeException($"Argument {nameof(unit)} is out of range");
        }
        public static float ConvertKilometersToMiles(float lenght1, char unit1)
        {
            if (unit1 == 'K')
            {
                return (float)((lenght1 / 1.6));
            }
            if (unit1 == 'm')
            {
                return (float)(lenght1 * 1.6);
            }
            throw new ArgumentOutOfRangeException($"Argument {nameof(unit1)} is out of range");
        }
        public static float ConvertCentimetersToInches(float height, string unit2)
        {
            if (unit2 == "cm")
            {
                return (float)(height * 0.3937007874);
            }
            if (unit2 == "in")
            {
                return (float)(height / 0.3937007874);
            }
            throw new ArgumentOutOfRangeException($"Argument {nameof(unit2)} is out of range");
        }
        public static float ConvertPoundsToStone(float height, string unit3)
        {
            if (unit3 == "ib")
            {
                return (float)(height / 14);
            }
            if (unit3 == "st")
            {
                return (float)(height * 14);
            }
            throw new ArgumentOutOfRangeException($"Argument {nameof(unit3)} is out of range");
        }
    }
}


