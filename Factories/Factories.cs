using static Factories.PointExercise.PointExercise;
using static Factories.AsyncFactory.AsyncFactory;
using static Factories.AbstractFactory.AbstractFactory;
using static Factories.ObjectTrackingAndBulkReplacement.ObjectTrackingAndBulkReplacement;

namespace Factories;

/// <summary>
/// A component responsible solely for the wholesale (not piecewise) creation of objects.
/// </summary>
public static class Factories
{
    public static async Task RunFactories()
    {
        ExecutePointExercise();
        await ExecuteAsyncFactory(); 
        ExecuteObjectTrackingAndBulkReplacement();
        ExecuteAbstractFactory();
    }
}