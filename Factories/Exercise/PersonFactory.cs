namespace Factories.Exercise;

public class PersonFactory
{
    private int _currentId;
    
    public PersonFactory()
    {
    }

    public Person CreatePerson(string name)
    {
        var person = new Person()
        {
            Name = name,
            Id = _currentId
        };
        _currentId++;

        return person;
    }
}