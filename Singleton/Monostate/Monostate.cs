namespace Singleton.Monostate;

/// <summary>
/// The monostate pattern is really wierd for singleton.
/// It works because we map to static fields.
/// </summary>
public static class Monostate
{
    public static void RunMonostate()
    {
        var ceo = new CEO
        {
            Name = "Adam Smith",
            Age = 55
        };

        Console.WriteLine(ceo);
        var ceo2 = new CEO();

        // Will be same
        Console.WriteLine(ceo2);
    }
}