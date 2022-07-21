namespace Builder.StepwiseBuilder.Interfaces;

public interface ISpecifyWheelSize
{
    IBuildCar WithWheels(int size);
}