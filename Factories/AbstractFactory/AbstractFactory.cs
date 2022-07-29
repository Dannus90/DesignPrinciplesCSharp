using Factories.AbstractFactory.Constants;

namespace Factories.AbstractFactory;

/// <summary>
/// Abstract factory -> Give out abstract objects instead of concrete objects. 
/// </summary>
public static class AbstractFactory
{
    public static void ExecuteAbstractFactory()
    {
        var machine = new HotDrinkMachine();
        var drink = machine.MakeDrink(AvailableDrink.Tea, 100);
        drink.Consume();
    }
}