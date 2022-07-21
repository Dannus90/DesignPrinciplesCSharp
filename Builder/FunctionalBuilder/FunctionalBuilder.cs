namespace Builder.FunctionalBuilder;

public static class FunctionalBuilder
{
    public static void ExecuteFunctionalBuilder()
    {
        var person = new PersonBuilder()
            .Called("sarah")
            .WorksAs("Bartender")
            .Build();

        var newPerson = new PersonBuilderNew()
            .Called("John");

        Console.WriteLine(person);
        Console.WriteLine(newPerson);
    }
}