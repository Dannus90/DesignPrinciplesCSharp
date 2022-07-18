namespace DesignPrinciplesCSharp.Solid.DependencyInversionPrinciple.Interfaces;

public interface IRelationshipBrowser
{
    IEnumerable<Person> FindAllChildrenOf(string name);
}