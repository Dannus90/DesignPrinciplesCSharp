namespace DesignPrinciplesCSharp.Solid.LiskovSubstitutionPrinciple;

public class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    
    public Rectangle()
    {
    }

    public Rectangle(int width, int weight)
    {
        Width = width;
        Height = weight;
    }

    public override string ToString()
    {
        return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
    }
}