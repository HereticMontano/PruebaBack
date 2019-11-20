namespace CodeTest.Calculator.Operations
{
    public class SubstractionOperation : BaseOperation
    {
        public override int Calculate(int firstValue, params int[] values)
        {
            foreach (var item in values)
            {
                firstValue -= item;
            }

            return firstValue;
        }
    }
}
