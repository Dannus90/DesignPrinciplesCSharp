namespace Prototype.Cloneable;

/// <summary>
/// ICloneable is not good for deep copy which is used by the prototype pattern.
/// </summary>
public static class Cloneable
{
    public static void ExecuteCloneable()
    {
        var john = new Person(new[] { "John", "Smith" }, 
            new Address("London Road", 123));

        var jane = (Person) john.Clone();
        jane.Address.HouseNumber = 321;
        
        Console.WriteLine(john);
        Console.WriteLine(jane);
    }
}