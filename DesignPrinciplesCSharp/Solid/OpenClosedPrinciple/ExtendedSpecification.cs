using DesignPrinciplesCSharp.Solid.OpenClosedPrinciple.Interfaces;

namespace DesignPrinciplesCSharp.Solid.OpenClosedPrinciple;

public class ExtendedSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _first, _second;

    public ExtendedSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        _first = first ?? throw new ArgumentNullException(paramName: nameof(first));
        _second = second ?? throw new ArgumentNullException(paramName: nameof(second));
    }

    public bool IsSatisfied(T t)
    {
        return _first.IsSatisfied(t) && _second.IsSatisfied(t);
    }
}