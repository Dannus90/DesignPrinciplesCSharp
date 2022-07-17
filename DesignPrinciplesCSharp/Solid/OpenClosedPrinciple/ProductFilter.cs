using DesignPrinciplesCSharp.Solid.OpenClosedPrinciple.Constants;

namespace DesignPrinciplesCSharp.Solid.OpenClosedPrinciple;

public class ProductFilter
{
    public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products,
        Size size)
    {
        return products.Where(product => product.Size == size);
    }

    public static IEnumerable<Product> FilterByColor(IEnumerable<Product> products,
        Color color)
    {
        return products.Where(product => product.Color == color);
    }
    
    public static IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products,
        Size size, Color color)
    {
        return products.Where(product => product.Color == color && product.Size == size);
    }
}