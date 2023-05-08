namespace WebApplication1;

public class Framework
{
    public Framework(IServiceProvider serviceProvider) => ServiceProvider = serviceProvider;

    public IServiceProvider ServiceProvider { get; }

    public async ValueTask RecieveAsync(Delegate @delegate)
    {
        await using var scope = ServiceProvider.CreateAsyncScope();

        var @params = @delegate.Method.GetParameters();


        if (@delegate.DynamicInvoke(@params.Select(x => scope.ServiceProvider.GetRequiredService(x.ParameterType)).ToArray())
        {
            await c;
        }
    }
}
