namespace Prototype;

/// <summary>
/// Complicated objects aren't designed from scratch. They reiterate existing designs.
/// An exiting (partially or fully constructed) design is a Prototype.
/// We make a copy (clone) the prototype and customize it (Requires deep copy support).
/// We make te cloning convenient through a factory. 
/// </summary>
public static class Prototype
{
    public static void RunPrototypes()
    {
        Console.WriteLine("Running prototypes");
    }
}