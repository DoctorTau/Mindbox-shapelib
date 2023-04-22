namespace Mindbox.Shapes.Models;

/// <summary>
/// Class that represents a triangle shape.
/// This class is an implementation of <see cref="Shape"/> class.
/// </summary>
public class Triangle : Shape
{
    /// <summary>
    /// Checks that the given triangle sides are positive and that the given triangle exits.
    /// </summary>
    /// <param name="triangle">Triangle to check</param>
    private static void existenceExceptionThrower(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ShapeArgumentException("Sides must be positive");

        if (!(sideA + sideB > sideC
            && sideA + sideC > sideB
            && sideB + sideC > sideA))
            throw new ShapeArgumentException("Triangle with such sides doesn't exist");
    }

    // Size of the triangle.
    double sideA;
    double sideB;
    double sideC;

    /// <summary>
    /// The constructor of the <see cref="Triangle"/> class.
    /// </summary>
    /// <param name="sideA"> Value of the first side.</param>
    /// <param name="sideB"> Value of the second side.</param>
    /// <param name="sideC"> Value of the third side.</param>
    public Triangle(double sideA, double sideB, double sideC)
    {
        existenceExceptionThrower(sideA, sideB, sideC);

        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    /// <summary>
    /// The value of the first side.
    /// </summary>
    /// <value>First side.</value>
    public double SideA
    {
        get { return sideA; }
        set
        {
            existenceExceptionThrower(value, sideB, sideC);
            sideA = value;
        }
    }

    /// <summary>
    /// The value of the second side.
    /// </summary>
    /// <value> Second side.</value>
    public double SideB
    {
        get { return sideB; }
        set
        {
            existenceExceptionThrower(sideA, value, sideC);
            sideB = value;
        }
    }

    /// <summary>
    /// The value of the third side.
    /// </summary>
    /// <value> Third side.</value>
    public double SideC
    {
        get { return sideC; }
        set
        {
            existenceExceptionThrower(sideA, sideB, value);
            sideC = value;
        }
    }

    /// <summary>
    /// Gets the area of the triangle.
    /// </summary>
    /// <returns> The area of the triangle.</returns>
    public override double GetArea()
    {
        double p = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }

    /// <summary>
    /// Checks if the triangle is right.
    /// </summary>
    /// <returns> True if triangle is right, false otherwise.</returns>
    public bool IsRightTriangle()
    {
        return sideA * sideA + sideB * sideB == sideC * sideC
            || sideA * sideA + sideC * sideC == sideB * sideB
            || sideB * sideB + sideC * sideC == sideA * sideA;
    }
}