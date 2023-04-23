using System.Drawing;

namespace FiguresSolution.Figures.Interfaces
{
    public interface ITriangle: IFigure
    {
        IEnumerable<Point> Points { get; }
        bool IsRectangular { get; }
    }
}
