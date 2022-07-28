namespace Factories.PointExercise;

public static class PointExercise
{
    public static void ExecutePointExercise()
    {
        var point = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
        Console.WriteLine(point);

        var newOrigin = Point.NewOrigin;
        var staticOrigin = Point.StaticOrigin;

        Console.WriteLine(newOrigin);
        Console.WriteLine(staticOrigin);
    }
}