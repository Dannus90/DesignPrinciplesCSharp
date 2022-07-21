namespace Builder.FunctionalBuilder;

public abstract class FunctionalBuilderNew<TSubject, TSelf>
    where TSelf : FunctionalBuilderNew<TSubject, TSelf>
    where TSubject : new()
{
    private readonly List<Func<Person, Person>> _actions = new();

    public TSelf Do(Action<Person> action) => AddAction(action);

    public Person Build() => _actions
        .Aggregate(new Person(), (p, f) => f(p));

    private TSelf AddAction(Action<Person> action)
    {
        _actions.Add(p =>
        {
            action(p);
            return p;
        });
        return (TSelf) this;
    }
}