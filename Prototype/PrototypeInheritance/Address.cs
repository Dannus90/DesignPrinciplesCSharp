using Prototype.PrototypeInheritance.Interfaces;

namespace Prototype.PrototypeInheritance;

public class Address : IDeepCopyable<Address>
{
    public string StreetName = "";
    public int HouseNumber;

    public Address()
    {
    }

    public Address(string streetName, int houseNumber)
    {
        StreetName = streetName ?? throw new ArgumentNullException(nameof(streetName));
        HouseNumber = houseNumber;
    }

    public Address DeepCopy()
    {
        return (Address)MemberwiseClone();
    }

    public override string ToString()
    {
        return $"{nameof(StreetName)}: {StreetName}," +
               $" {nameof(HouseNumber)}: {HouseNumber}";
    }
}