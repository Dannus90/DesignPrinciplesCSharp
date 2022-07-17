using DesignPrinciplesCSharp.Solid.OpenClosedPrinciple.Constants;

namespace DesignPrinciplesCSharp.Solid.OpenClosedPrinciple;

public class Product
{
    public readonly string Name;
    public readonly Color Color;
    public readonly Size Size;

    public Product(string name, Color color, Size size)
    {
        _ = name == null ? throw new ArgumentNullException(paramName: nameof(name)) : true;
        Name = name;
        Color = color;
        Size = size;
    }
}