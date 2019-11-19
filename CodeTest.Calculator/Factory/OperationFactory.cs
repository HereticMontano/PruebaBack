using CodeTest.Calculator.Enums;
using CodeTest.Calculator.Interfaces;
using CodeTest.Calculator.Operations;
using System;

namespace CodeTest.Calculator.Factory
{
    public class OperationFactory : BaseFactory<IOperation>
    {
        public override IOperation Fabricate(string operation)
        {
            Enum.TryParse(operation, true, out TypeOperationEnum op);

            switch (op)
            {
                case TypeOperationEnum.Add:
                    return new AdditionOperation();
                case TypeOperationEnum.Substract:
                    return new SubstractionOperation();
                case TypeOperationEnum.Multiplication:
                    return new MultiplicationOperation();
                case TypeOperationEnum.Division:
                    return new DivisionOperation();
                case TypeOperationEnum.None:
                default:
                    return null;
            }
        }
    }
}
