namespace Builder.FunctionalBuilder;

public static class FunctionalBuilder
{
    public static void ExecuteFunctionalBuilder()
    {
        var person = new PersonBuilder()
            .Called("sarah")
            .WorksAs("Bartender")
            .Build();
    }
}