using DesignPrinciplesCSharp.Solid.InterfaceSegregationPrinciple.Interfaces;

namespace DesignPrinciplesCSharp.Solid.InterfaceSegregationPrinciple;

public class OldFashionedPrinter : IPrinter
{
    public void Print(Document d)
    {
        throw new NotImplementedException();
    }
}