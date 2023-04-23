using AutoFixture;
using FiguresSolution.Figures.Entities;
using FiguresSolution.Figures.Interfaces;
using FluentAssertions;
using Moq;
using System.Drawing;

namespace FigureSolution.Test
{
    public class TriangleUnitTest
    {
        [Fact]
        public void Triangle_CalculateArea_Equals()
        {
            var mock = new Mock<IFigure>();
            mock.Setup(x => x.Area).Returns(40);

            var fixture = new Fixture();
            ITriangle sut = new Triangle("Test", new(0, 0), new(10, 0), new(6, 8));

            sut.Area.Should().Be(mock.Object.Area);
        }

        [Fact]
        public void Triangle_CheckRectangular_IsRectangular()
        {
            var fixture = new Fixture();
            ITriangle sut = new Triangle("Test", new(0, 0), new(6, 0), new(0, 8));

            sut.IsRectangular.Should().BeTrue();
        }

        [Fact]
        public void Triangle_CheckRectangular_IsNotRectangular()
        {
            var fixture = new Fixture();
            ITriangle sut = new Triangle("Test", new(0, 0), new(10, 0), new(6, 8));

            Assert.False(sut.IsRectangular);
            sut.IsRectangular.Should().BeFalse();
        }

        [Fact]
        public void Triangle_CreateNotTriangle_RaiseException()
        {
            var fixture = new Fixture();
            try
            {
                ITriangle sut = new Triangle("Test", new List<Point> { new(0, 0), new(10, 0) });
            }
            catch (ArgumentException ex)
            {
                Assert.Equal("The number of points for the triangle must be three", ex.Message);
            }
            catch (Exception)
            {
                Assert.True(false);
            }
        }
    }
}