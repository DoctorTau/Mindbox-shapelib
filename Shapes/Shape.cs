namespace Mindbox.Shapes.Models;

/// <summary>
/// Base class for all shapes. 
/// </summary>
public abstract class Shape
{
    /// <summary>
    /// Calculates the area of the shape.
    /// </summary>
    /// <returns> The area of the shape </returns>
    public abstract double GetArea();
}
