using MoreLinq.Extensions;
using Singleton.Interfaces;

namespace Singleton;

public class SingletonDatabase : IDatabase
{
    private readonly Dictionary<string, int> _capitals;
    private static int _instanceCount;
    public static int Count => _instanceCount;

    private SingletonDatabase()
    {
        Console.WriteLine("Initializing database");
        var directory = Environment.CurrentDirectory;
        var parentDirectory = Directory.GetParent(directory)?.Parent?.Parent?.FullName;
        Console.WriteLine(new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName);
        Console.WriteLine(Path.Combine(new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName ?? throw new InvalidOperationException(), "capitals.txt"));
        _capitals = File.ReadAllLines($"{parentDirectory}/capitals.txt").
            Batch(2).ToDictionary(
                list => 
                    list.ElementAt(0).ToString(),
                list => 
                    int.Parse(list.ElementAt(1)));
        _instanceCount++;
    }
    
    public int GetPopulation(string name)
    {
        return _capitals[name];
    }

    private static readonly Lazy<SingletonDatabase> _instance = new(() => new SingletonDatabase());
    public static SingletonDatabase Instance => _instance.Value;
}