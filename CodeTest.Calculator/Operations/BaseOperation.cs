using CodeTest.Calculator.Interfaces;

namespace CodeTest.Calculator.Operations
{
    public abstract class BaseOperation : IOperation
    {
        public abstract int Calculate(params int[] values);
    }
}
