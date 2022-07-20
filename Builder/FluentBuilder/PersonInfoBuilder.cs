namespace Builder.FluentBuilder;

// clas Foo : Bar<Foo> -> returns reference to itself. 
public class PersonInfoBuilder<TSelf> : PersonBuilder
where TSelf : PersonInfoBuilder<TSelf>
{
    public TSelf Called (string name)
    {
        Person.Name = name;
        return (TSelf) this;
    }
}