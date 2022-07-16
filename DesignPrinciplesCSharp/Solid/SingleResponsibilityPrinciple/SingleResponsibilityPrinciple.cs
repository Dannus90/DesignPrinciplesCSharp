namespace DesignPrinciplesCSharp.Solid.SingleResponsibilityPrinciple;

/// <summary>
/// Each class is responsible for one thing and only have one reason to change. 
/// </summary>
public static class SingleResponsibilityPrinciple
{
    public static void Execute()
    {
        var initialEntryList = new List<string>();
        var srp = new Journal(initialEntryList, initialEntryList.Count);
        srp.AddEntry("test1");
        srp.AddEntry("test2");
        Console.WriteLine(srp);
        PersistJournal.SaveToFile(srp, "journal.txt", true);
    }
}