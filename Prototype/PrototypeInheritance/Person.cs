namespace Prototype.PrototypeInheritance;

public class Person
{
    public string[] Names = Array.Empty<string>();
    public Address Address = new Address();

    public Person()
    {
    }

    public Person(string[] names, Address address)
    {
        Names = names;
        Address = address;
    }

    public override string ToString()
    {
        return $"{nameof(Names)}: {Names}, {nameof(Address)}: {Address}";
    }
}