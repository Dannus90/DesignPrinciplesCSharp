namespace Factories.Exercise;

public static class FactoryExercise
{
    public static void ExecuteFactoryExercise()
    {
        var personFactory = new PersonFactory();

        var firstPerson = personFactory.CreatePerson("Anna");
        var secondPerson = personFactory.CreatePerson("Daniel");

        Console.WriteLine(firstPerson);
        Console.WriteLine(secondPerson);
    }
}