using static System.Console;

namespace Prototype.PrototypeInheritance;

public static class PrototypeInheritance
{
    public static void ExecutePrototypeInheritance()
    {
        var john = new Employee();
        john.Names = new[] { "John", "Doe" };
        john.Address = new Address()
        {
            HouseNumber = 123,
            StreetName = "Ponnygatan"
        };
        john.Salary = 321000;
        var copy = john.DeepCopy();
        copy.Names[1] = "Smith";
        copy.Address.HouseNumber++;
        copy.Salary = 123000;

        WriteLine(john);
        WriteLine(copy);
    }
}