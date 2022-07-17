namespace DesignPrinciplesCSharp.Solid.InterfaceSegregationPrinciple;

/// <summary>
/// Your interfaces should be segregated - No one that implements your interfaces should have to implement methods that they don't want to use.
/// </summary>
public static class InterfaceSegregationPrinciple
{
    public static void Execute()
    {
        Console.WriteLine("No concrete implementations here - Check the segregation of the interfaces.");
    }
}