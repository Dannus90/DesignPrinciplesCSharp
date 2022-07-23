namespace Builder.FacetedBuilder;
using static Console;

/// <summary>
/// More convenient to use.
/// Side effect is that you can chain events and overwrite them in the same creation.
/// Facade hides a lot of information behind it. 
/// </summary>
public static class FacetedBuilder
{
    public static void ExecuteFacetedBuilder()
    {
        var personBuilder = new PersonBuilder();
        
        // Giving the type here lets us do to string correctly based on the person builder setup.
        Person person = personBuilder.Works
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