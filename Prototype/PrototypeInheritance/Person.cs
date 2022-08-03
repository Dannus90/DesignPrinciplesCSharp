using Prototype.PrototypeInheritance.Interfaces;

namespace Prototype.PrototypeInheritance;

public class Person : IDeepCopyable<Person>
{
    public string[] Names = Array.Empty<string>();
    public Address Address = new();

    public Person()
    {
    }

    public Person(string[] names, Address address)
    {
        Names = names;
        Address = address;
    }

    public void CopyTo(Person target)
    {
        target.Names = (string[])Names.Clone();
        target.Address = Address.DeepCopy();
    }

    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(", ", Names)}, {nameof(Address)}: {Address}";
    }
}