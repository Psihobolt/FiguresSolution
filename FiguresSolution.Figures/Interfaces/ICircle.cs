using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresSolution.Figures.Interfaces
{
    public interface ICircle
    {
        Point Center { get; }
        int Radius { get; }
    }
}
