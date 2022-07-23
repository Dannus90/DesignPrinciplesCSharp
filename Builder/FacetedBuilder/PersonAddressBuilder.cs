namespace Builder.FacetedBuilder;

public class PersonAddressBuilder : PersonBuilder
{
    public PersonAddressBuilder(Person person)
    {
        Person = person;
    }

    public PersonAddressBuilder AtCompanyAddress(string streetAddress)
    {
        Person.StressAddress = streetAddress;
        return this;
    }

    public PersonAddressBuilder WithPostCode(string postcode)
    {
        Person.Postcode = postcode;
        return this;
    }

    public PersonAddressBuilder InCity(string city)
    {
        Person.City = city;
        return this;
    }
}