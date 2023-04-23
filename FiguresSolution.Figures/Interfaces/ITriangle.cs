using System.Drawing;

namespace FiguresSolution.Figures.Interfaces
{
    public interface ITriangle: IFigure
    {
        IReadOnlyCollection<Point> Points { get; }
        bool IsRectangular { get; }
    }
}
