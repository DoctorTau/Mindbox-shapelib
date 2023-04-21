using Mindbox.Shapes;
using Mindbox.Shapes.Models;
using Xunit;

public class TestTriangle
{
    [Fact]
    public void CreateTriangleWithPositiveSides()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        // Act
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        // Assert
        Assert.Equal(triangle.SideA, sideA);
        Assert.Equal(triangle.SideB, sideB);
        Assert.Equal(triangle.SideC, sideC);
    }

    [Fact]
    public void CreateTriangleWithNonPositiveSide()
    {
        // Arrange
        double sideA = 3;
        double sideB = -4;
        double sideC = 5;

        // Act & Assert
        Assert.Throws<ShapeArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Fact]
    public void CreateTriangleWithInvalidSides()
    {
        // Arrange
        double sideA = 3;
        double sideB = 9;
        double sideC = 5;

        // Act & Assert
        Assert.Throws<ShapeArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Fact]
    public void ChangeSideToNonPositive()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        Triangle triangle = new Triangle(sideA, sideB, sideC);

        // Act & Assert
        Assert.ThrowsAny<ShapeArgumentException>(() => triangle.SideA = -2);
    }

    [Fact]
    public void ChangeSideToCreateInvalidTriangle()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        Triangle triangle = new Triangle(sideA, sideB, sideC);

        // Act & Assert
        Assert.ThrowsAny<ShapeArgumentException>(() => triangle.SideC = 8);
    }

    [Fact]
    public void CalculateAreaOfTriangle()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        Triangle triangle = new Triangle(sideA, sideB, sideC);

        // Act
        double area = triangle.GetArea();

        // Assert
        Assert.Equal(area, 6);
    }
}