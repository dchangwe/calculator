using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sum;
using System;
using System.Collections.Generic;
using System.Text;
using BasicCalculator;
using operations;

namespace Sum.Tests
{
    [TestClass()]
    public class AddingTests
    {
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
     
    }
}