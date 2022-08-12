namespace Singleton;

public static class Singleton
{
    public static void ExecuteSingleton()
    {
        var db = SingletonDatabase.Instance;
        const string city = "Tokyo";
        Console.WriteLine(File.Exists("capitals.txt"));
        Console.WriteLine($"{city} has population {db.GetPopulation(city)}");
    }
}