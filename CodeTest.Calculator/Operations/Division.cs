namespace CodeTest.Calculator.Operations
{
    public class Division : BaseOperation
    {
        public override int Calculate(params int[] values)
        {
            int response = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                response = response / values[i];
            }
            return response;
        }
    }
}
