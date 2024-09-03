using GeometricFugures.Enums;

namespace GeometricFugures.Interfaces
{
    public interface IFigureFactory
    {
        IFigure GetFigure(FigureType type, params double[] parameters);
    }
}