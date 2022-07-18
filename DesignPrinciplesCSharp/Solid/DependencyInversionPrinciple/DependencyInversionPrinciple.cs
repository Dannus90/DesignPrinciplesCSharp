namespace DesignPrinciplesCSharp.Solid.DependencyInversionPrinciple;

/// <summary>
/// High level parts of the system parts of the system should not depend on low level parts of the system.
/// Instead of depending on a low level module we depend on an abstraction. 
/// </summary>
public static class DependencyInversionPrinciple
{
    public static void Execute()
    {
        var parent = new Person { Name = "John" };
        var firstChild = new Person { Name = "Chris" };
        var secondChild = new Person { Name = "Mary" };

        var relationships = new Relationships();
        relationships.AddParentAndChild(parent, firstChild);
        relationships.AddParentAndChild(parent, secondChild);

        new Research(relationships);
    }
}