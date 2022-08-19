using Singleton.Interfaces;

namespace Singleton;

public class ConfigurableRecordFinder
{
    private IDatabase _datebase;

    public ConfigurableRecordFinder(IDatabase database)
    {
        _datebase = database ?? throw new ArgumentNullException(nameof(database));
    }
    
    public int GetTotalPopulation(IEnumerable<string> names)
    {
        return names.Sum(name => _datebase.GetPopulation(name));
    }
}