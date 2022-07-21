using Builder.StepwiseBuilder.Constants;

namespace Builder.StepwiseBuilder;

public class Car
{
    public CarType Type;
    public int WheelSize;
    public override string ToString()
    {
        return $"Car is of type {Type} and wheel size is {WheelSize}";
    }
}