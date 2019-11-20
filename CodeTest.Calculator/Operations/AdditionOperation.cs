﻿namespace CodeTest.Calculator.Operations
{
    public class AdditionOperation : BaseOperation
    { 
        public override int Calculate(params int[] values)
        {
            int response = 0;
            foreach (var item in values)
            {
                response += item;
            }

            return response;
        }
    }
}