using System.Text;
using Factories.ObjectTrackingAndBulkReplacement.Interfaces;

namespace Factories.ObjectTrackingAndBulkReplacement;

public class TrackingThemeFactory
{
    private readonly List<WeakReference<ITheme>> _themes = new();

    public ITheme CreateTheme(bool dark)
    {
        ITheme theme = dark ? new DarkTheme() : new LightTheme();
        _themes.Add(new WeakReference<ITheme>(theme));

        return theme;
    }

    public string Info
    {
        get
        {
            var sb = new StringBuilder();
            foreach (var theme in _themes)
            {
                if (!theme.TryGetTarget(out var outTheme)) continue;
                var dark = outTheme is DarkTheme;
                sb.Append(dark ? "Dark" : "Light")
                    .AppendLine(" theme");
            }

            return sb.ToString();
        }
    }
}