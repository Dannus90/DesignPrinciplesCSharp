﻿namespace Singleton;

public static class Singleton
{
    public static void ExecuteSingleton()
    {
        // This will get the current WORKING directory (i.e. \bin\Debug)
        var db = SingletonDatabase.Instance;
        const string city = "Tokyo";
        Console.WriteLine($"{city} has population {db.GetPopulation(city)}");
    }
}