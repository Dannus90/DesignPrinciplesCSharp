using Factories.AbstractFactory.Constants;
using Factories.AbstractFactory.Interfaces;

namespace Factories.AbstractFactory;

public class HotDrinkMachine
{
    private Dictionary<AvailableDrink, IHotDrinkFactory> _factories = new ();

    public HotDrinkMachine()
    {
        foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
        {
            var factory = (IHotDrinkFactory) Activator.CreateInstance(
                Type.GetType("Factories.AbstractFactory." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory") 
                ?? throw new InvalidOperationException("Instance not found"))!;
            
            _factories.Add(drink, factory);
        }
    }

    public IHotDrink MakeDrink(AvailableDrink drink, int amount)
    {
        return _factories[drink].Prepare(amount);
    }
}