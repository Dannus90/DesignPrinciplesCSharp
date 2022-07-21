using Builder.StepwiseBuilder.Constants;

namespace Builder.StepwiseBuilder.Interfaces;

public interface ISpecifyCarType
{
    ISpecifyWheelSize OfType(CarType type);
}