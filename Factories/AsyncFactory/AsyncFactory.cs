namespace Factories.AsyncFactory;

public static class AsyncFactory
{
    public static async Task ExecuteAsyncFactory()
    { 
        var x = await Foo.CreateAsync();
        Console.WriteLine(x);
    }
}