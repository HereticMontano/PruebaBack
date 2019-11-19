using CodeTest.Calculator.Factory;

namespace CodeTest.Calculator
{

    public class Calculator
    {
        public static int Operation(int operand1, int operand2, string operation)
        {
            var operationFactory = new OperationFactory();
            var opera = operationFactory.Fabricate(operation);
            return opera.Calculate(operand1, operand2);
        }
    }
}
