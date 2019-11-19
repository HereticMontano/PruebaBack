
namespace CodeTest.Calculator.Operations
{
    public class Invalid : BaseOperation
    {
        public override int Calculate(params int[] values)
        {
            return 0;
        }
    }
}
