using FigureCalculator.Enums;
using FigureCalculator.Interfaces;
using Microsoft.Extensions.Logging;

namespace FigureCalculator
{
    public class Calculator
    {
        private readonly IFigureFactory _factory;
        public Calculator(IFigureFactory factory) 
        {
            _factory = factory;
        }
        
        public double CalculateFigureArea(FigureType type, params double[] parameters)
        {
            var figure = _factory.GetFigure(type, parameters);
            return figure.CalculateArea();
        }

        public double CalculateFigureArea(IFigure figure)
        {
            return figure.CalculateArea();
        }
    }
}
