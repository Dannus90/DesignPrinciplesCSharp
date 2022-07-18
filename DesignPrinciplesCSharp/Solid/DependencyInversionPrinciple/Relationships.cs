using DesignPrinciplesCSharp.Solid.DependencyInversionPrinciple.Constants;
using DesignPrinciplesCSharp.Solid.DependencyInversionPrinciple.Interfaces;

namespace DesignPrinciplesCSharp.Solid.DependencyInversionPrinciple;

public class Relationships : IRelationshipBrowser
{
    private readonly List<(Person, Relationship, Person)> _relations = new();

    public void AddParentAndChild(Person parent, Person child)
    {
        _relations.Add((parent, Relationship.Parent, child));
        _relations.Add((child, Relationship.Child, parent));
    }

    public IEnumerable<(Person, Relationship, Person)> Relations => _relations;
    public IEnumerable<Person> FindAllChildrenOf(string name)
    {
        return _relations.Where(x => x.Item1.Name == name && x.Item2 == Relationship.Parent)
            .Select(x => x.Item3);
    }
}