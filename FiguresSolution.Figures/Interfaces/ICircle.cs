using System.Drawing;

namespace FiguresSolution.Figures.Interfaces
{
    public interface ICircle : IFigure
    {
        Point Center { get; }
        double Radius { get; }
    }
}
