namespace Builder.FluentBuilder;

/// <summary>
/// Return this to chain methods. If you inherit and try use functionality
/// it might return this of a object that does not contain the properties of the derived class.
/// Do not use the containing type as the return type. 
/// </summary>
public static class FluentBuilder
{
    public static void ExecuteFluentBuilder()
    {
        var personBuilder = new PersonJobBuilder();
        var me = Person.New
            .Called("John")
            .WorksAsA("quant")
            .Build();

        Console.WriteLine(me);
    }
}