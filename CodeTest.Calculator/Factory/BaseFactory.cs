
namespace CodeTest.Calculator.Factory
{
    public abstract class BaseFactory<T>
    {
        public abstract T Fabricate(string operation);
    }
}
