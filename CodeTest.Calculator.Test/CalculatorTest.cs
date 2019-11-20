using System;
using CodeTest.Calculator.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTest.Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Calculator_Operation_Should_Return_4_When_Add_Is_the_Operation_And_Operand1_Is_1_And_Operand2_Is_3()
        {
            Assert.AreEqual(4, Calculator.Operation(1, 3, EnumTypeOperation.Add));
        }

        [TestMethod]
        public void Calculator_Operation_Should_Return_2_When_Substract_Is_the_Operation_And_Operand1_Is_3_And_Operand2_Is_1()
        {
            Assert.AreEqual(2, Calculator.Operation(3, 1, EnumTypeOperation.Substract));
        }

        [TestMethod]
        public void Calculator_Operation_Should_Return_6_When_Multiplication_Is_the_Operation_And_Operand1_Is_2_And_Operand2_Is_3()
        {
            Assert.AreEqual(6, Calculator.Operation(2, 3, EnumTypeOperation.Multiplication));
        }

        [TestMethod]
        public void Calculator_Operation_Should_Return_4_When_Division_Is_the_Operation_And_Operand1_Is_12_And_Operand2_Is_3()
        {
            Assert.AreEqual(4, Calculator.Operation(12, 3, EnumTypeOperation.Division));
        }

        [TestMethod]
        public void Calculator_Operation_Should_Return_0_When_Unknown_Is_the_Operation_And_Operand1_Is_1_And_Operand2_Is_3()
        {
            Assert.AreEqual(0, Calculator.Operation(1, 3, EnumTypeOperation.None));
        }
    }
}
