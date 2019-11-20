namespace CodeTest.Calculator.Operations
{
    public class DivisionOperation : BaseOperation
    {
        public override int Calculate(int firstValue, params int[] values)
        {
            foreach (var item in values)
            {
                firstValue /= item;
            }
            
            return firstValue;
        }
    }
}
