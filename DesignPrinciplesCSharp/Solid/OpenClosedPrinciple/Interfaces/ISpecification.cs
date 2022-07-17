namespace DesignPrinciplesCSharp.Solid.OpenClosedPrinciple.Interfaces;

public interface ISpecification<in T>
{
    bool IsSatisfied(T t);
}