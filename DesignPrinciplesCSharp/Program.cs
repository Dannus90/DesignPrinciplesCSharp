using DesignPrinciplesCSharp.Solid.DependencyInversionPrinciple;
using DesignPrinciplesCSharp.Solid.InterfaceSegregationPrinciple;
using DesignPrinciplesCSharp.Solid.LiskovSubstitutionPrinciple;
using DesignPrinciplesCSharp.Solid.OpenClosedPrinciple;
using DesignPrinciplesCSharp.Solid.SingleResponsibilityPrinciple;
using static Builder.Builder;
using static Factories.Factories;

// SOLID
SingleResponsibilityPrinciple.Execute();
OpenClosedPrinciple.Execute();
LiskovSubstitutionPrinciple.Execute();
InterfaceSegregationPrinciple.Execute();
DependencyInversionPrinciple.Execute();

// BUILDER
RunBuilder();

// FACTORIES
RunFactories();