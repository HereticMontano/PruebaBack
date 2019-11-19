using CodeTest.Calculator.Interfaces;
using CodeTest.Calculator.Operations;

namespace CodeTest.Calculator.Factory
{
    public class OperationFactory : BaseFactory<IOperation>
    {
        public override IOperation Fabricate(string operation)
        {
            switch (operation)
            {
                case "add":
                    return new Addition();
                case "substract":
                    return new Substraction();
                case "multiplication":
                    return new Multiplication();
                case "division":
                    return new Division();
                default:
                    return new Invalid();
            }
        }
    }
}
