namespace CodeTest.Calculator.Operations
{
    public class Multiplication : BaseOperation
    {
        public override int Calculate(params int[] values)
        {
            int response = 1;
            foreach (var item in values)
            {
                response *= item;
            }

            return response;
        }
    }
}
