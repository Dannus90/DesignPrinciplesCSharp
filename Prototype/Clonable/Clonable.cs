namespace Prototype.Clonable;

public static class Clonable
{
    public static void ExecuteClonable()
    {
        var john = new Person(new[] { "John", "Smith" }, 
            new Address("London Road", 123));

        Console.WriteLine(john);
    }
}