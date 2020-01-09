using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;
using operations;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly int a = 5;
        private readonly int b = 10;
        private readonly int c = 0;
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();

            int c = calculator.Add(7, 5);

            Assert.AreEqual(12, c);
            Assert.AreEqual(12, calculator.result);

            
        }
        [TestMethod()]
        public void AddIntDoubleTest()
        {
            Calculator calculator = new Calculator();
            int a = 1;
            double b = 2.02;
            double c = calculator.Add(a, b);

            Assert.AreEqual(3.02, c);
            Assert.AreEqual(3.02, calculator.result);


        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();

            int c = calculator.Divide(6, 2);

            Assert.AreEqual(3, c);
            Assert.AreEqual(3, calculator.result);
           
        }
        [TestMethod()]
        public void SubtractTest()
        {
            Calculator calculator = new Calculator();

            int c = calculator.Subtract(15, 5);

            Assert.AreEqual(10, c);
            Assert.AreEqual(10, calculator.result);

        }
        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();

            int c = calculator.Multiply(10, 10);

            Assert.AreEqual(100, c);
            Assert.AreEqual(100, calculator.result);

        }
        [TestMethod()]
        public void SquaredNumberTest()
        {
            Calculator calculator = new Calculator();

            int c = calculator.SquaredNumber(7);

            Assert.AreEqual(49, c);
            Assert.AreEqual(49, calculator.result);

        }
        [TestMethod()]
        public void CubeTest()
        {
            Calculator calculator = new Calculator();

            int c = calculator.Cubed(2);

            Assert.AreEqual(6, c);
            Assert.AreEqual(6, calculator.result);

        }

        //[TestMethod()]
        //public void DivideIntDoubleTest()
        //{
        //    Calculator calculator = new Calculator();
        //    int a = 10;
        //    double b = 5.02;
        //    double c = calculator.Add(a, b);

        //    Assert.AreEqual(1.9920, c);
        //    Assert.AreEqual(1.9920, calculator.result);


        //}

        [TestMethod()]
        public void QuoIntDivideZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Division.Divide(a, c));
        }

        [TestMethod()]
        public void QuotientIntTest()
        {
            Assert.AreEqual(2, Division.Divide(b, a));
        }
    }
}