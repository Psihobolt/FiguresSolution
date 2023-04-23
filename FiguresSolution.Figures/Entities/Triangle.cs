using FiguresSolution.Figures.Interfaces;
using System.Drawing;

namespace FiguresSolution.Figures.Entities
{
    public class Triangle : ITriangle
    {
        private double GetLengthLine(Point one, Point two)
        {
            return Math.Sqrt(Math.Pow(two.X - one.X, 2) + Math.Pow(two.Y - one.Y, 2));
        }
        public IReadOnlyCollection<double> Sides { get
            {
                return Points
                    .Select((x, idx) =>
                        idx == Points.Count() - 1
                        ? GetLengthLine(Points.ElementAt(0), x)
                        : GetLengthLine(Points.ElementAt(idx + 1), x))
                    .OrderByDescending(x => x)
               .ToList();
            }
        }

        public string Name { get; private set; }
        public IReadOnlyCollection<Point> Points { get; private set; }

        public bool IsRectangular { get {
                return Sides.First() == Math.Sqrt(Math.Pow(Sides.ElementAt(1), 2) + Math.Pow(Sides.ElementAt(2), 2));
            } }

        public double Area { get {
                var p = Sides.Sum(x=>x)/2;
                return Math.Sqrt(p * (p - Sides.First()) * (p - Sides.ElementAt(1)) * (p - Sides.ElementAt(2)));
            } }


        public Triangle(string name, IReadOnlyCollection<Point> points)
        {
            if (points == null) 
                throw new ArgumentNullException(nameof(points));

            if (points.Count() != 3)
                throw new ArgumentException("The number of points for the triangle must be three");

            if (points.Distinct().Count() != 3) 
                throw new ArgumentException("The points for the triangle must be located far apart from each other");

            Name = name;
            Points = points;
        }

        public Triangle(string name, Point first, Point second, Point third) : this(name, new List<Point>() { first, second, third }) { }
    }
}
