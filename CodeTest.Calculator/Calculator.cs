using CodeTest.Calculator.Enums;
using CodeTest.Calculator.Factory;

namespace CodeTest.Calculator
{

    public class Calculator
    {
        public static int Operation(int firtsOperand, int secondOperand, EnumTypeOperation operation)
        {
            var operationFactory = new OperationFactory();
            var opera = operationFactory.Fabricate(operation);
            
            return opera != null ? opera.Calculate(firtsOperand, secondOperand) : 0;
        }
    }
}
