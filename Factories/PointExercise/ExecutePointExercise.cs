namespace Factories.PointExercise;

public static class PointExercise
{
    public static void ExecutePointExercise()
    {
        var point = Point.NewPolarPoint(1.0, Math.PI / 2);
        Console.WriteLine(point);
    }
}