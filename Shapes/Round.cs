namespace Mindbox.Shapes.Models;

/// <summary>
/// Class that represents a round shape.
/// This class is an implementation of <see cref="Shape"/> class.
/// </summary>
public class Round : Shape
{
    // Radius of the round.
    private double radius;

    /// <summary>
    /// Constructs a new <see cref="Round"/> instance.
    /// </summary>
    /// <param name="radius"></param>
    public Round(double radius)
    {
        // Radius must be positive.
        if (radius <= 0)
            throw new ShapeArgumentException("Radius must be positive");
        this.radius = radius;
    }

    /// <summary>
    /// Gets the radius of the round.
    /// </summary>
    /// <value> The radius of the round </value>
    public double Radius
    {
        get { return radius; }
        set
        {
            if (value <= 0)
                throw new ShapeArgumentException("Radius must be positive");
            radius = value;
        }
    }

    /// <summary>
    /// Calculates the area of the round.
    /// </summary>
    /// <returns> The area of the round. </returns>
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}