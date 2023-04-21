using System;
using Xunit;

namespace Mindbox.Shapes.Models.Tests
{
    public class RoundTests
    {
        [Fact]
        public void Constructor_RadiusIsPositive_CreatesRound()
        {
            // Arrange
            double radius = 5;

            // Act
            Round round = new Round(radius);

            // Assert
            Assert.NotNull(round);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-3)]
        public void Constructor_RadiusIsZeroOrNegative_ThrowsShapeArgumentException(double radius)
        {
            // Act & Assert
            Assert.Throws<ShapeArgumentException>(() => new Round(radius));
        }

        [Fact]
        public void Radius_ValidValue_SetsAndGetRadiusValue()
        {
            // Arrange
            double radius = 5;
            Round round = new Round(radius);

            // Act
            round.Radius = 8;

            // Assert
            Assert.Equal(8, round.Radius);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-3)]
        public void Radius_ZeroOrNegativeValue_ThrowsShapeArgumentException(double radius)
        {
            // Arrange
            double initialRadius = 5;
            Round round = new Round(initialRadius);

            // Act & Assert
            Assert.Throws<ShapeArgumentException>(() => round.Radius = radius);
        }

        [Fact]
        public void GetArea_ValidParameters_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            Round round = new Round(radius);

            // Act
            double area = round.GetArea();

            // Assert
            Assert.Equal(Math.PI * radius * radius, area);
        }
    }
}
