namespace Mindbox.Shapes;

[System.Serializable]
/// <summary>
/// Shape exception class to be used in case of invalid shape usage.
/// </summary>
public class ShapeArgumentException : System.ArgumentException
{
    public ShapeArgumentException() { }
    public ShapeArgumentException(string message) : base(message) { }
    public ShapeArgumentException(string message, System.Exception inner) : base(message, inner) { }
    protected ShapeArgumentException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}