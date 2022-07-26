using Factories.ObjectTrackingAndBulkReplacement.Interfaces;

namespace Factories.ObjectTrackingAndBulkReplacement;

public class DarkTheme : ITheme
{
    public string TextColor => "white";
    public string BackgroundColor => "black";
}