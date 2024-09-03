using GeometricFugures.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFugures.Figures
{
    public class Circle : IFigure
    {

        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius > 0 ? radius : throw new InvalidParameterException(nameof(Radius));
        }
        public double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }

        public double CalculatePerimetr()
        {
            return 2 * Radius * Math.PI;
        }
    }
}
