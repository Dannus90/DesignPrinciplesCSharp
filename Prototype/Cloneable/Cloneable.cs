namespace Prototype.Cloneable;

/// <summary>
/// ICloneable is not good for deep copy which is used by the prototype pattern.
/// Returns an object instead of something strongly typed.
/// Constructor pattern is better but not the best solution.
/// Deep copy interface is still a problem since we have to specify deep copy on each underlying object.
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