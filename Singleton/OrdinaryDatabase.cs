using MoreLinq.Extensions;
using Singleton.Interfaces;

namespace Singleton;

public class OrdinaryDatabase : IDatabase
{
    private readonly Dictionary<string, int> _capitals;

    public OrdinaryDatabase()
    {
        Console.WriteLine("Initializing database");
        var directory = Environment.CurrentDirectory;
        var parentDirectory = Directory.GetParent(directory)?.Parent?.Parent?.FullName;
        var capitals = Path.Combine(parentDirectory ?? throw new InvalidOperationException(), "capitals.txt");
        _capitals = File.ReadAllLines($"{capitals}").
            Batch(2).ToDictionary(
                list => 
                    list.ElementAt(0).ToString(),
                list => 
                    int.Parse(list.ElementAt(1)));
    }
    
    public int GetPopulation(string name)
    {
        return _capitals[name];
    }
}