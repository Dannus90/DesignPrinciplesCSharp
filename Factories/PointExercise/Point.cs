namespace Factories.PointExercise;

/// <summary>
/// Inner factories within the class make private constructor accessible.
/// </summary>
public class Point
{
    private readonly double _x, _y;
    
    private Point(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public static Point NewOrigin => new Point(0, 0);
    public static Point StaticOrigin = new Point(0, 0);

    public override string ToString()
    {
        return $"{nameof(_x)}: {_x}, {nameof(_y)}: {_y}";
    }
    public static class Factory
    {
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }
    }
    
}