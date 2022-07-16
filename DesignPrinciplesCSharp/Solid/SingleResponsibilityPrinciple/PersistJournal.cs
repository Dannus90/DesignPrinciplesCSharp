using System.Reflection;

namespace DesignPrinciplesCSharp.Solid.SingleResponsibilityPrinciple;

public static class PersistJournal
{
    public static void SaveToFile(Journal journal, string fileName, bool overwrite = false)
    {
        if (!overwrite && File.Exists(fileName)) return;
        var currentDirectory = Directory.GetCurrentDirectory();
        File.WriteAllText($"{currentDirectory}/{fileName}", journal.ToString());
    }
}