using GeometricFigures;
using GeometricFugures.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFugures.Figures
{
    public class Triangle : IFigure
    {

        public Triangle(double a, double b, double c)
        {
            var biggestSide = Math.Max(Math.Max(a, b),c);
            if (biggestSide >= (a+b+c - biggestSide))
            {
                throw new TriangleDoNotExistsException();
            }
            
            SideA = a > 0 ? a : throw new InvalidParameterException(nameof(SideA));
            SideB = b > 0 ? b : throw new InvalidParameterException(nameof(SideB));
            SideC = c > 0 ? c : throw new InvalidParameterException(nameof(SideC));
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public double CalculateArea()
        {
            var p = (SideA + SideB + SideC) / 2d;
            var result = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return result;
        }

        public double CalculatePerimetr()
        {
            return SideA + SideB + SideC;
        }

        public bool IsRight()
        {
            var hypotenuse = Math.Max(SideA, Math.Max(SideB, SideC));
            var sidesSquaredSum = (SideA * SideA + SideB * SideB + SideC * SideC);
            return Constants.AccuracyError > Math.Abs(sidesSquaredSum - (hypotenuse * hypotenuse) * 2);
            
        }
    }
}
