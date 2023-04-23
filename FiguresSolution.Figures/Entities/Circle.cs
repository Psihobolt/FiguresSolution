using FiguresSolution.Figures.Interfaces;
using System.Drawing;

namespace FiguresSolution.Figures.Entities
{
    public class Circle : ICircle
    {
        public Point Center { get; private set; }

        public double Radius { get; private set; }

        public string Name { get; private set; }

        public double Area => Math.Round(Math.PI, 2) * Math.Pow(Radius, 2);

        public Circle(string name, Point center, double radius)
        {
            Name = name;
            Center = center;
            Radius = radius;
        }
    }
}
