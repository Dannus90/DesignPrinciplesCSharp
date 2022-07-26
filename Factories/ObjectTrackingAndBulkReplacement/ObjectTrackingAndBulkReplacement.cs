namespace Factories.ObjectTrackingAndBulkReplacement;

public static class ObjectTrackingAndBulkReplacement
{
    public static void ExecuteObjectTrackingAndBulkReplacement()
    {
        var factory = new TrackingThemeFactory();
        factory.CreateTheme(false);
        factory.CreateTheme(true);
        Console.WriteLine(factory.Info);

        var replaceableThemeFactory = new ReplaceableThemeFactory();
        var magicTheme = replaceableThemeFactory.CreateTheme(true);

        Console.WriteLine(magicTheme.Value.BackgroundColor);
        replaceableThemeFactory.ReplaceTheme(false);
        Console.WriteLine(magicTheme.Value.BackgroundColor);
    }
}