namespace Prototype.Cloneable;

/// <summary>
/// ICloneable is not good for deep copy which is used by the prototype pattern.
/// Returns an object instead of something strongly typed.
/// Constructor pattern is better but not the best solution.
/// </summary>
public static class Cloneable
{
    public static void ExecuteCloneable()
    {
        var john = new Person(new[] { "John", "Smith" }, 
            new Address("London Road", 123));

        var jane = john.DeepCopy();
        jane.Address.HouseNumber = 321;
        
        Console.WriteLine(john);
        Console.WriteLine(jane);
    }
}