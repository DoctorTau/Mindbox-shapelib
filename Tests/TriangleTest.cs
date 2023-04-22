using Mindbox.Shapes;
using Mindbox.Shapes.Models;
using Xunit;

public class TestTriangle
{
    [Fact]
    public void Constructor_TriangleWithPositiveSides_CreatesTriangle()
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
    public void Constructor_WithNonPositiveSide_ThrowsShapeArgumentException()
    {
        // Arrange
        double sideA = 3;
        double sideB = -4;
        double sideC = 5;

        // Act & Assert
        Assert.Throws<ShapeArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Fact]
    public void Constructor_WithInvalidSides_ThrowsShapeArgumentException()
    {
        // Arrange
        double sideA = 3;
        double sideB = 9;
        double sideC = 5;

        // Act & Assert
        Assert.Throws<ShapeArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Fact]
    public void ChangeSide_ToNegativeSide_ThrowsShapeArgumentException()
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
    public void ChangeSide_ToNotValidTriangle_ThrowsShapeArgumentException()
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
    public void GetArea_ValidParameters_ReturnsCorrectArea()
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

    [Fact]
    public void IsRightTriangle_True()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        Triangle triangle = new Triangle(sideA, sideB, sideC);

        // Act
        bool isRight = triangle.IsRightTriangle();

        // Assert
        Assert.True(isRight);
    }

    [Fact]
    public void IsRightTriangle_False()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 6;

        Triangle triangle = new Triangle(sideA, sideB, sideC);

        // Act
        bool isRight = triangle.IsRightTriangle();

        // Assert
        Assert.False(isRight);
    }
}