using DesignPrinciplesCSharp.Solid.OpenClosedPrinciple.Constants;
using DesignPrinciplesCSharp.Solid.OpenClosedPrinciple.Interfaces;

namespace DesignPrinciplesCSharp.Solid.OpenClosedPrinciple;

public class ColorSpecification : ISpecification<Product>
{
    private readonly Color _color;

    public ColorSpecification(Color color)
    {
        _color = color;
    }

    public bool IsSatisfied(Product t)
    {
        return t.Color == _color;
    }
}