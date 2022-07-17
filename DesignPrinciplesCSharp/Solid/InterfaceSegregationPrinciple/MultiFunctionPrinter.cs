using DesignPrinciplesCSharp.Solid.InterfaceSegregationPrinciple.Interfaces;

namespace DesignPrinciplesCSharp.Solid.InterfaceSegregationPrinciple;

public class MultiFunctionPrinter : IMultiFunctionInterface
{
    private readonly IPrinter _printer;
    private readonly IFaxer _faxer;
    private readonly IScanner _scanner;

    public MultiFunctionPrinter(IPrinter printer, IFaxer faxer, IScanner scanner)
    {
        _printer = printer ?? throw new ArgumentNullException(nameof(printer));
        _faxer = faxer ?? throw new ArgumentNullException(nameof(faxer));
        _scanner = scanner ?? throw new ArgumentNullException(nameof(scanner));
    }

    // We delegate to the implementation of the respective method.
    // This is the decorator pattern.
    public void Print(Document document)
    {
        _printer.Print(document);
    }

    public void Fax(Document document)
    {
        _faxer.Fax(document);
    }

    public void Scan(Document d)
    {
        _scanner.Scan(d);
    }
}