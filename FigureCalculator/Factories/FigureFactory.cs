using FigureCalculator.Enums;
using FigureCalculator.Figures;
using FigureCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator.Factories
{
    public class FigureFactory : IFigureFactory
    {

        public IFigure GetFigure(FigureType type, params double[] parameters)
        {

            return type switch
            {
                FigureType.Triangle => new Triangle(parameters[0], parameters[1], parameters[2]),
                FigureType.Circle => new Circle(parameters[0]),
                FigureType.Rectangle => new Rectangle(parameters[0], parameters[1])
            };
        }
    }
}
