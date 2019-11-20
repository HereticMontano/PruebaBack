namespace CodeTest.Calculator.Operations
{
    public class AdditionOperation : BaseOperation
    { 
        public override int Calculate(int firstValue, params int[] values)
        {
            int response = firstValue;
            foreach (var item in values)
            {
                response += item;
            }

            return response;
        }
    }
}
