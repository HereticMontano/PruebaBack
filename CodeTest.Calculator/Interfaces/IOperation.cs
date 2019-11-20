
namespace CodeTest.Calculator.Interfaces
{
    public interface IOperation
    {
        int Calculate(int firstValue, params int[] values);
    }
}
