using static Factories.PointExercise.PointExercise;

namespace Factories;

/// <summary>
/// A component responsible solely for the wholesale (not piecewise) creation of objects.
/// </summary>
public static class Factories
{
    public static void Execute()
    {
        ExecutePointExercise();
    }
}