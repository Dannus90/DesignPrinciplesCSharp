namespace DesignPrinciplesCSharp.Solid.OpenClosedPrinciple.Interfaces;

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
}