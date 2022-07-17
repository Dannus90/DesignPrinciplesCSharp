using DesignPrinciplesCSharp.Solid.OpenClosedPrinciple.Constants;

namespace DesignPrinciplesCSharp.Solid.OpenClosedPrinciple;

public class OpenClosedPrinciple
{
    public static void Execute()
    {
        var products = new List<Product>
        {
            new("Apple", Color.Green, Size.Small),
            new("Tree", Color.Green, Size.Large),
            new("House", Color.Blue, Size.Large)
        };
        
        Console.WriteLine("Green products (old):");
        foreach (var product in ProductFilter.FilterByColor(products, Color.Green))
        {
            Console.WriteLine($"( - {product.Name} is green)");
        }
    }
}