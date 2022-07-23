namespace Builder.FacetedBuilder;
using static System.Console;

/// <summary>
/// More convenient to use.
/// </summary>
public static class FacetedBuilder
{
    public static void ExecuteFacetedBuilder()
    {
        var personBuilder = new PersonBuilder();
        var person = personBuilder.Works
            .WorksAt("FrontEdge IT")
            .WorksAs("Developer")
            .Earns(50000)
            .Lives
            .InCity("Gothenburg")
            .AtCompanyAddress("Anders Carlsson Gata")
            .WithPostCode("43132");
        
        WriteLine(person);
    }
}