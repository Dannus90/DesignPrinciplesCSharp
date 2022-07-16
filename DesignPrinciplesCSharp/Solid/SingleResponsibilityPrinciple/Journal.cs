namespace DesignPrinciplesCSharp.Solid.SingleResponsibilityPrinciple;

public class Journal
{
    private readonly List<string> _entries;

    public Journal(List<string> entries)
    {
        _entries = entries;
    }

    public void AddEntry(string text)
    {
        _entries.Add($"{_entries.Count + 1}: {text}");
    }

    public void RemoveEntry(int index)
    {
        _entries.RemoveAt(index);
    }

    public override string ToString() => string.Join(Environment.NewLine, _entries);
}