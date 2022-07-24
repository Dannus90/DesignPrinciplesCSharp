using static Factories.PointExercise.PointExercise;
using static Factories.AsyncFactory.AsyncFactory;

namespace Factories;

/// <summary>
/// A component responsible solely for the wholesale (not piecewise) creation of objects.
/// </summary>
public static class Factories
{
    public static void RunFactories()
    {
        ExecutePointExercise();
        ExecuteAsyncFactory();
    }
}