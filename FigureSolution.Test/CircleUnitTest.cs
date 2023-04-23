using FiguresSolution.Figures.Entities;
using FiguresSolution.Figures.Interfaces;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSolution.Test
{
    public class CircleUnitTest
    {
        [Fact]
        public void Circle_CalculateArea_Equals()
        {
            var mock = new Mock<ICircle>();
            mock.Setup(x=>x.Area).Returns(Math.Round(Math.PI, 2) * Math.Pow(10, 2));

            var sut = new Circle("Test", new(0, 0), 10);
            sut.Area.Should().Be(mock.Object.Area);
        }
    }
}
