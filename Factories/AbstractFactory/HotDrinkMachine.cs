using Factories.AbstractFactory.Constants;
using Factories.AbstractFactory.Interfaces;

namespace Factories.AbstractFactory;

public class HotDrinkMachine
{
    private readonly List<Tuple<string, IHotDrinkFactory>> _factories = new();

    public HotDrinkMachine()
    {
        foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
        {
            if (typeof(IHotDrinkFactory).IsAssignableFrom(t) &&
                !t.IsInterface)
            {
                _factories.Add(Tuple.Create(t.Name.Replace("Factory", string.Empty),
                    (IHotDrinkFactory)Activator.CreateInstance(t)!));
            }
        }
    }
    
    public IHotDrink MakeDrink()
    {
        Console.WriteLine("Available drinks:");
        for (var index = 0; index < _factories.Count; index++)
        {
            var tuple = _factories[index];
            Console.WriteLine($"{index}: {tuple.Item1}");
        }

        while (true)
        {
            string? s;
            if ((s = Console.ReadLine()) != null
                && int.TryParse(s, out var i)
                && i >= 0
                && i < _factories.Count)
            {
                Console.Write("Specify amount: ");
                s = Console.ReadLine();
                if (s != null
                    && int.TryParse(s, out var amount)
                    && amount > 0)
                {
                    return _factories[i].Item2.Prepare(amount);
                }
            }

            Console.WriteLine("Incorrect input! Try again!");
        }


    }
}