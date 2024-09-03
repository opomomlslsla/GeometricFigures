using GeometricFugures.Enums;
using GeometricFugures.Figures;
using GeometricFugures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFugures.Factories
{
    public class FigureFactory : IFigureFactory
    {

        public IFigure GetFigure(FigureType type, params double[] parameters)
        {

            return type switch
            {
                FigureType.Triangle => parameters.Count() == 3 ? new Triangle(parameters[0], parameters[1], parameters[2]): throw new ArgumentException("Incorrect amount of parameters, should be 3"),
                FigureType.Circle => parameters.Count() == 1 ? new Circle(parameters[0]) : throw new ArgumentException("Incorrect amount of parameters for circle, should be only one"),
                FigureType.Rectangle => parameters.Count() == 2 ? new Rectangle(parameters[0], parameters[1]) : throw new ArgumentException("Incorrect amount of parameters, should be 2")
            };
        }
    }
}
