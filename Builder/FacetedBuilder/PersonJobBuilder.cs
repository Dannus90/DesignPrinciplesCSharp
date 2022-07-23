namespace Builder.FacetedBuilder;

public class PersonJobBuilder : PersonBuilder
{
    public PersonJobBuilder(Person person)
    {
        Person = person;
    }

    public PersonJobBuilder WorksAt(string companyName)
    {
        Person.CompanyName = companyName;
        return this;
    }
    
    public PersonJobBuilder WorksAs(string position)
    {
        Person.Position = position;
        return this;
    }
    
    public PersonJobBuilder Earns(int amount)
    {
        Person.AnnualIncome = amount;
        return this;
    }
}