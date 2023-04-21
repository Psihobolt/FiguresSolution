using System.Drawing;

namespace FiguresSolution.Figures.Interfaces
{
    public interface ITriangle
    {
        IEnumerable<Point> Points { get; }
        bool IsRectangular { get; }
    }
}
