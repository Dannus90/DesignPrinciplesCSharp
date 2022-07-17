namespace DesignPrinciplesCSharp.Solid.OpenClosedPrinciple.Interfaces;

public interface ISpecification<T>
{
    bool IsSatisfied(T t);
}