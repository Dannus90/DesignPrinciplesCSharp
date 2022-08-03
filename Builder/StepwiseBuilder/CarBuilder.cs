using Builder.StepwiseBuilder.Constants;
using Builder.StepwiseBuilder.Interfaces;

namespace Builder.StepwiseBuilder;

public static class CarBuilder
{
    private class Impl : 
        ISpecifyCarType, 
        ISpecifyWheelSize, 
        IBuildCar
    {
        private readonly Car _car = new();
        
        public ISpecifyWheelSize OfType(CarType type)
        {
            _car.Type = type;
            return this;
        }

        public IBuildCar WithWheels(int size)
        {
            switch (_car.Type)
            {
                case CarType.Crossover when size is < 17 or > 20:
                    break;
                case CarType.Sedan when size is < 15 or > 17:
                    throw new ArgumentException($"Wrong size of when for {_car.Type}");
                default:
                    throw new ArgumentOutOfRangeException($"{nameof(size)} is out of range");
            }

            _car.WheelSize = size;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
    
    public static ISpecifyCarType Create()
    {
        return new Impl();
    }
}