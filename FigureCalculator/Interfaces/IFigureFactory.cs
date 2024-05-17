using FigureCalculator.Enums;

namespace FigureCalculator.Interfaces
{
    public interface IFigureFactory
    {
        IFigure GetFigure(FigureType type, params double[] parameters);
    }
}