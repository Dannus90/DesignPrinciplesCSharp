namespace Builder.FunctionalBuilder;

public sealed class PersonBuilderNew : FunctionalBuilderNew<Person, PersonBuilderNew>
{
    public PersonBuilderNew Called(string name) => Do(p => p.Name = name);
}