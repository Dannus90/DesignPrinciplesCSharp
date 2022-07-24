using Factories.PointExercise.Constants;

namespace Factories.PointExercise;

public class Point
{
    private readonly double _x, _y;

    /// <summary>
    /// Initializes a point from EITHER cartesian or polar
    /// </summary>
    /// <param name="a">x if cartesian, rho if polar</param>
    /// <param name="b"></param>
    /// <param name="system"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Point(double a, 
        double b, 
        CoordinateSystem system = CoordinateSystem.Cartesian)
    {
        switch (system)
        {
            case CoordinateSystem.Cartesian:
                _x = a;
                _y = b;
                break;
            case CoordinateSystem.Polar:
                _x = a * Math.Cos(b);
                _y = a * Math.Sin(b);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(system), system, null);
        }
    }
}