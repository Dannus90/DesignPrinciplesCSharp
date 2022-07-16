namespace DesignPrinciplesCSharp.Solid.SingleResponsibilityPrinciple;

public class Journal
{
    private readonly List<string> _entries;
    private static int _count;

    public Journal(List<string> entries, int count)
    {
        _entries = entries;
        _count = count;
    }

    public void AddEntry(string text)
    {
        _entries.Add($"{++_count}: {text}");
    }

    public void RemoveEntry(int index)
    {
        _entries.RemoveAt(index);
    }

    public override string ToString() => string.Join(Environment.NewLine, _entries);
}