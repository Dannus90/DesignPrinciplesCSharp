namespace Builder.FunctionalBuilder;

public sealed class PersonBuilder
{
    private readonly List<Func<Person, Person>> _actions = new();

    public PersonBuilder Do(Action<Person> action) => AddAction(action);

    public PersonBuilder Called(string name) => Do(p => p.Name = name);

    public Person Build() => _actions
        .Aggregate(new Person(), (p, f) => f(p));

    private PersonBuilder AddAction(Action<Person> action)
    {
        _actions.Add(p =>
        {
            action(p);
            return p;
        });
        return this;
    }
}