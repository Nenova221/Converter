using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class MetricAndImperialConverter
    {
        public static float Convert(float lenght, char unit)
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
        public static float Convert1(float lenght1, char unit1)
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
    }
}
