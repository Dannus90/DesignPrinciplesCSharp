namespace DesignPrinciplesCSharp.Solid.SingleResponsibilityPrinciple;

/// <summary>
/// Each class is responsible for one thing and only have one reason to change. 
/// </summary>
public static class SingleResponsibilityPrinciple
{
    public static void Execute()
    {
        var initialEntryList = new List<string>();
        var journal = new Journal(initialEntryList);
        
        journal.AddEntry("FisherJournal");
        journal.AddEntry("SailorJournal");
        
        Console.WriteLine(journal);
        
        PersistJournal.SaveToFile(journal, "journal.txt", true);
        
        journal.RemoveEntry(1);
        journal.AddEntry("WoodCutterJournal");
        
        Console.WriteLine(journal);
        
        PersistJournal.SaveToFile(journal, "journal.txt", true);
    }
}