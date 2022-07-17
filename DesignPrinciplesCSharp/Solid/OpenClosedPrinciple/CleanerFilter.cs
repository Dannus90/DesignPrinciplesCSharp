using DesignPrinciplesCSharp.Solid.OpenClosedPrinciple.Interfaces;

namespace DesignPrinciplesCSharp.Solid.OpenClosedPrinciple;

public class CleanerFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        return items.Where(spec.IsSatisfied);
    }
}