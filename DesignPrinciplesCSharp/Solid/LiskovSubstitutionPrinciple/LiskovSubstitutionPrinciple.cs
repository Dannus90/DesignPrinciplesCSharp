using static System.Console;

namespace DesignPrinciplesCSharp.Solid.LiskovSubstitutionPrinciple;

/// <summary>
///  You should be able to upcast to your base class without functionality being altered.
/// The square should always behave like a square.
/// </summary>
public static class LiskovSubstitutionPrinciple
{
    private static int Area(Rectangle rectangle) => rectangle.Height * rectangle.Width;
    public static void Execute()
    {
        var rectangle = new Rectangle(4, 5);
        WriteLine($"{rectangle} has area {Area(rectangle)}");

        // If we would not have virtual properties in the Rectangle class and overrides in the Square class.
        // Then the square down below would use the setters for the Rectangle class causing invalid logic. 
        // This breaks the LiskovPrinciple. 
        Rectangle square = new Square
        {
            Width = 4
        };
        WriteLine($"{square} has area {Area(rectangle)}");
    }
}