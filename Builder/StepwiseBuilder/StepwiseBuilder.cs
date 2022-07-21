using Builder.StepwiseBuilder.Constants;

namespace Builder.StepwiseBuilder;

/// <summary>
/// We can restrict the accessible methods and chaining order with interfaces as return types even though it returns this.
/// </summary>
public static class StepwiseBuilder
{
    public static void ExecuteStepwiseBuilder()
    {
        var car = CarBuilder.Create()
            .OfType(CarType.Crossover)
            .WithWheels(18)
            .Build();

        Console.WriteLine(car);
    }
}