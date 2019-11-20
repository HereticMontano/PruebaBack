using CodeTest.Calculator.Enums;

namespace CodeTest.Calculator.Factory
{
    public abstract class BaseFactory<T>
    {
        public abstract T Fabricate(EnumTypeOperation operation);
    }
}
