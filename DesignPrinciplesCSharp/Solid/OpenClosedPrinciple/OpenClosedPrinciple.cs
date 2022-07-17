using DesignPrinciplesCSharp.Solid.OpenClosedPrinciple.Constants;

namespace DesignPrinciplesCSharp.Solid.OpenClosedPrinciple;
/// <summary>
/// Classes should be open for extension (add new filters) but they should be closed for modification.
/// </summary>
public static class OpenClosedPrinciple
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

        var cleanerFilter = new CleanerFilter();
        Console.WriteLine("Green products (new):");
        foreach (var product in cleanerFilter.Filter(products, new ColorSpecification(Color.Green)))
        {
            Console.WriteLine($"( - {product.Name} is green)");
        }
    }
}