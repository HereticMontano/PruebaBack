using CodeTest.Calculator.Enums;
using CodeTest.Calculator.Interfaces;
using CodeTest.Calculator.Operations;
using System;

namespace CodeTest.Calculator.Factory
{
    public class OperationFactory : BaseFactory<IOperation>
    {
        public override IOperation Fabricate(EnumTypeOperation operation)
        {
            switch (operation)
            {
                case EnumTypeOperation.Add:
                    return new AdditionOperation();
                case EnumTypeOperation.Substract:
                    return new SubstractionOperation();
                case EnumTypeOperation.Multiplication:
                    return new MultiplicationOperation();
                case EnumTypeOperation.Division:
                    return new DivisionOperation();
                case EnumTypeOperation.None:
                default:
                    return null;
            }
        }
    }
}
