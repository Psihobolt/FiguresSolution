using FiguresSolution.Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresSolution.Figures.Entities
{
    public abstract class Triangle : IFigure, ITriangle
    {
        private double GetLengthLine (Point one, Point two)
        {
            return Math.Sqrt(Math.Pow(two.X - one.X, 2) + Math.Pow(two.Y - one.Y, 2));
        }
        private IEnumerable<double> Cathets { get
            {
                return Points.Select((x, idx) => 
                    idx == Points.Count() - 1 
                    ? GetLengthLine(Points.ElementAt(0), x) 
                    : GetLengthLine(Points.ElementAt(idx + 1), x))
               .ToList();
            }
        }

        public string Name { get; private set; }
        public IEnumerable<Point> Points { get; private set; }

        public bool IsRectangular => throw new NotImplementedException();

        public int Area => throw new NotImplementedException();


        public Triangle(string name, IEnumerable<Point> points)
        {
            if (points == null) 
                throw new ArgumentNullException(nameof(points));

            if (points.Count() != 3)
                throw new ArgumentException("The number of points for the triangle must be three");

            if (points.Distinct().Count() == 3) 
                throw new ArgumentException("The points for the triangle must be located far apart from each other");

            Name = name;
            Points = points;
        }

        public Triangle(string name, Point first, Point second, Point third) : this(name, new List<Point>() { first, second, third }) { }
    }
}
