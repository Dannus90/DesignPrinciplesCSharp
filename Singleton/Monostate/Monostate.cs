namespace Singleton.Monostate;

/// <summary>
/// The monostate pattern is really wierd for singleton.
/// It works because we map to static fields.
/// </summary>
public static class Monostate
{
    public static void RunMonostate()
    {
        var ceo = new CEO();
        ceo.Name = "Adam Smith";
        ceo.Age = 55;

        var ceo2 = new CEO();
        Console.WriteLine(ceo2);
    }
}