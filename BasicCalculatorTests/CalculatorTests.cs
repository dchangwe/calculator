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
        public void DivideTest()
        {
            Calculator calculator = new Calculator();

            int c = calculator.Divide(6, 2);

            Assert.AreEqual(3, c);
            Assert.AreEqual(3, calculator.result);
           
        }
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