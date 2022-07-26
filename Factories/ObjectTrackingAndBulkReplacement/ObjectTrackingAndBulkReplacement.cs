namespace Factories.ObjectTrackingAndBulkReplacement;

public static class ObjectTrackingAndBulkReplacement
{
    public static void ExecuteObjectTrackingAndBulkReplacement()
    {
        var factory = new TrackingThemeFactory();
        factory.CreateTheme(false);
        factory.CreateTheme(true);
        Console.WriteLine(factory.Info);
    }
}