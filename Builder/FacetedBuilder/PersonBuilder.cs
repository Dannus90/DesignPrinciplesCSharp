namespace Builder.FacetedBuilder;

public class PersonBuilder // Facade
{
    // Reference
    protected Person Person = new();

    public PersonJobBuilder Works => new(Person);
    public PersonAddressBuilder Lives => new(Person);

    public static implicit operator Person(PersonBuilder pb)
    {
        return pb.Person;
    }
}