using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using operations;

namespace operations.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int a = 10;
        private readonly  int b = 20;
        private readonly double c = 10.5;
        private readonly double d = 20.5;
        private readonly double[] arrayA = { 1.01, 2.04, 3.06, 4.07,  6.4,7,8,9,10};
        private readonly double[] arrayB = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };
        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(30, addition.Sum(a, b));
        }
        [TestMethod()]
        public void SumDoubleTest()
        {
            Assert.AreEqual(31, addition.Sum(c, d));
        }
        [TestMethod()]
        public void SumDoubleArrayTest()
        {
            Assert.AreEqual(50.58, addition.Sum(arrayA));
        }
        [TestMethod()]
        public void SumIntArrayTest()
        {
            Assert.AreEqual(50, addition.Sum(arrayB));
        }
    }
}