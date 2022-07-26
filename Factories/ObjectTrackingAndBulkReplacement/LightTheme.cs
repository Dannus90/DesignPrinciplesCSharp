using Factories.ObjectTrackingAndBulkReplacement.Interfaces;

namespace Factories.ObjectTrackingAndBulkReplacement;

public class LightTheme : ITheme
{
    public string TextColor => "black";
    public string BackgroundColor => "white";
}