using MoreLinq.Extensions;
using Singleton.Interfaces;

namespace Singleton;

public class SingletonDatabase : IDatabase
{
    private readonly Dictionary<string, int> _capitals;

    private SingletonDatabase()
    {
        Console.WriteLine("Initializing database");
        var pathName = Directory.GetCurrentDirectory();
        _capitals = File.ReadAllLines($"{pathName}/capitals.txt").
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

    private static readonly Lazy<SingletonDatabase> _instance = new(() => new SingletonDatabase());
    public static SingletonDatabase Instance => _instance.Value;
}