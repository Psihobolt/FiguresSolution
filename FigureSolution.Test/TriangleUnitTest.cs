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
            // Arrange
            var mock = new Mock<IFigure>();
            mock.Setup(x => x.Area).Returns(40);

            var fixture = new Fixture();
            ITriangle sut = new Triangle("Test", new(0, 0), new(10, 0), new(6, 8));

            // Act
            var result = sut.Area;

            // Assert
            result.Should().Be(mock.Object.Area);
        }

        [Fact]
        public void Triangle_CheckRectangular_IsRectangular()
        {
            // Arrange
            ITriangle sut = new Triangle("Test", new(0, 0), new(6, 0), new(0, 8));

            // Assert
            sut.IsRectangular.Should().BeTrue();
        }

        [Fact]
        public void Triangle_CheckRectangular_IsNotRectangular()
        {
            // Arrange
            ITriangle sut = new Triangle("Test", new(0, 0), new(10, 0), new(6, 8));

            // Assert
            sut.IsRectangular.Should().BeFalse();
        }

        [Fact]
        public void Triangle_CreateNotTriangle_RaiseException()
        {
            // Arrange
            Action action = () => new Triangle("Test", new List<Point> { new(0, 0), new(10, 0) });

            // Assert
            action.Should().Throw<ArgumentException>()
                .WithMessage("The number of points for the triangle must be three");
        }
    }
}