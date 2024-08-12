using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class DegreeConverter
    {
        public static float Convert(float degrees, char unit)
        {

            if (unit == 'F')
            {
                 return (degrees - 32) * 5 / 9;
            }
            if (unit == 'C')
            {
                return ((degrees * 9) / 5) + 32;
            }
            throw new ArgumentOutOfRangeException($"Argument {nameof(unit)} is out of range");

        }

    }
}
