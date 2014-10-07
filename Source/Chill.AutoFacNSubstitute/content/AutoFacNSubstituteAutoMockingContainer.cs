using AutofacContrib.NSubstitute;
using Chill;

internal class AutofacNSubstituteAutoMockingContainer : IAutoMockingContainer
{
    private AutoSubstitute container = new AutoSubstitute();
    public T Get<T>() where T : class
    {
        return container.Resolve<T>();
    }

    public T Set<T>(T valueToSet) where T : class
    {
        return container.Provide(valueToSet);

    }

    public void Dispose()
    {
        container.Dispose();
    }
}
