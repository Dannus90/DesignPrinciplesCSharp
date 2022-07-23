using System.Text;
using static System.Console;
using static Builder.FluentBuilder.FluentBuilder;
using static Builder.StepwiseBuilder.StepwiseBuilder;
using static Builder.FunctionalBuilder.FunctionalBuilder;
using static Builder.FacetedBuilder.FacetedBuilder;

namespace Builder;
/// <summary>
/// Having an object with 10 constructor arguments is not productive.s
/// Instead, opt for piecewise construction.
/// Builder provides an api for constructing objects that are complicated to construct succinctly.
/// </summary>
public static class Builder
{
    public static void RunBuilder()
    {
        const string hello = "hello";
        var sb = new StringBuilder();
        sb.Append("<p>");
        sb.Append(hello);
        sb.Append("</p>");
        WriteLine(sb);

        var words = new[] { "hello", "world" };
        sb.Clear();
        sb.Append("<ul>");
        foreach (var word in words)
        {
            sb.Append($"<li>{word}</li>");
        }

        sb.Append("</ul>");
        WriteLine(sb);
        
        // Cleaner way to do it
        var builder = new HtmlBuilder("ul");
        builder.AddChild("li", "hello").AddChild("li", "world");
        WriteLine(builder.ToString());
        
        ExecuteFluentBuilder();
        ExecuteStepwiseBuilder();
        ExecuteFunctionalBuilder();
        ExecuteFacetedBuilder();
    }
}