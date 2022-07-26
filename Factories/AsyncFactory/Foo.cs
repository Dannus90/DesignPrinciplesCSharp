namespace Factories.AsyncFactory;

public class Foo
{
    private Foo()
    {
    }

    private async Task<Foo> InitAsync()
    {
        await Task.Delay(1000);
        return this;
    }

    public static Task<Foo> CreateAsync()
    {
        return new Foo().InitAsync();
    }
    
}