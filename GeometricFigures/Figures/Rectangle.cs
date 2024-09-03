using GeometricFugures.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFugures.Figures
{
    public class Rectangle : IFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public Rectangle(double a, double b) 
        {
            SideA = a > 0 ? a : throw new InvalidParameterException(nameof(SideA));
            SideB = b > 0 ? b : throw new InvalidParameterException(nameof(SideB));
        }
        public double CalculateArea()
        {
            return SideA * SideB;
        }

        public double CalculatePerimetr()
        {
            return (SideA + SideB) * 2;
        }
    }
}
