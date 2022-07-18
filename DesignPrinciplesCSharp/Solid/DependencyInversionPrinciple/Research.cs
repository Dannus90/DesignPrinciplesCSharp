using DesignPrinciplesCSharp.Solid.DependencyInversionPrinciple.Constants;
using DesignPrinciplesCSharp.Solid.DependencyInversionPrinciple.Interfaces;

namespace DesignPrinciplesCSharp.Solid.DependencyInversionPrinciple;

public class Research
{
    // THIS IS BAD! We depend on low level from high level. 
    /*public Research(Relationships relationships)
    {
        var relations = relationships.Relations;
        foreach (var r in relations.Where(x => x.Item1.Name == "John" && 
                                               x.Item2 == Relationship.Parent))
        {
            Console.WriteLine($"John has a child called {r.Item3.Name}");
        }
    }*/

    // This is better since we depend on an abstraction.
    // With this implementation we don't work with the storage of the relationships class and it can change freely.
    public Research(IRelationshipBrowser browser)
    {
        foreach (var person in browser.FindAllChildrenOf("John"))
            Console.WriteLine($"John has a child called {person.Name}");
    }
}