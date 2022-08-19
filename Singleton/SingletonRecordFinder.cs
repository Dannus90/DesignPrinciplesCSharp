namespace Singleton;

public class SingletonRecordFinder
{
    public int GetTotalPopulation(IEnumerable<string> names)
    {
        return names.Sum(name => SingletonDatabase.Instance.GetPopulation(name));
    }
}