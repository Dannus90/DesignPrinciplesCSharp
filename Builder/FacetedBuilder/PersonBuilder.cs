namespace Builder.FacetedBuilder;

public class PersonBuilder // Facade
{
    // Reference
    protected Person Person = new();

    public PersonJobBuilder Works => new PersonJobBuilder(Person);
    public PersonAddressBuilder Lives => new PersonAddressBuilder(Person);
}