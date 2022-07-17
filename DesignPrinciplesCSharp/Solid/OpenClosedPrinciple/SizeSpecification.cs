using DesignPrinciplesCSharp.Solid.OpenClosedPrinciple.Constants;
using DesignPrinciplesCSharp.Solid.OpenClosedPrinciple.Interfaces;

namespace DesignPrinciplesCSharp.Solid.OpenClosedPrinciple;

public class SizeSpecification : ISpecification<Product>
{
    private readonly Size _size;

    public SizeSpecification(Size size)
    {
        _size = size;
    }

    public bool IsSatisfied(Product t)
    {
        return t.Size == _size;
    }
}