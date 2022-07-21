using Builder.StepwiseBuilder.Constants;

namespace Builder.StepwiseBuilder;

public static class StepwiseBuilder
{
    public static void ExecuteStepwiseBuilder()
    {
        var car = CarBuilder.Create()
            .OfType(CarType.Crossover)
            .WithWheels(18)
            .Build();
    }
}