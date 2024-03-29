namespace Factories.Exercise;

public class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"Name: {Name} and Id: {Id}";
    }
}