namespace Prototype.Clonable;

/// <summary>
/// IClonable is not good for deep copy which is used by the prototype pattern.
/// </summary>
public static class Clonable
{
    public static void ExecuteClonable()
    {
        var john = new Person(new[] { "John", "Smith" }, 
            new Address("London Road", 123));

        var jane = (Person) john.Clone();
        jane.Address.HouseNumber = 321;
        
        Console.WriteLine(john);
        Console.WriteLine(jane);
    }
}