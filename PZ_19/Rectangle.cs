using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class Rectangle : GeometricFigure
    {
        public override double CalculateArea(params double[] number)
        {
            if (number.Length != 2)
                throw new ArgumentException();
            return number[0] * number[1];
        }

        public override double CalculatePerimeter(params double[] number)
        {
            if (number.Length != 2)
                throw new ArgumentException();
            return 2 * (number[0] + number[1]);
        }
    }
}
