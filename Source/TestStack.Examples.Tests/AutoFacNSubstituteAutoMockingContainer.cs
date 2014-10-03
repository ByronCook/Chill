using AutofacContrib.NSubstitute;

namespace TestStack.Examples.Tests
{
    public class AutoFacNSubstituteAutoMockingContainer : IAutoMockingContainer
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
}