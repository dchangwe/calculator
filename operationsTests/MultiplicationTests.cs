using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        private readonly int a = 3;
        private readonly int b = 5;
        private readonly double c = 2.3;
        private readonly double d = 1.0;
        private readonly double[] arrayA = { 1.0, 2.0, 3.0, 5.0};
        private readonly int[] arrayB = { 2, 4, 6, 7 };
        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(15, Multiplication.Multiply(a, b));
        }
        [TestMethod()]
        public void MultiplyDoubleTest()
        {
            Assert.AreEqual(2.3, Multiplication.Multiply(c,d));
        }
        [TestMethod()]
        public void MultiplyDoubleArrayTest()
        {
            Assert.AreEqual(30, Multiplication.Multiply(arrayA));
        }
        [TestMethod()]
        public void MultiplyIntArrayTest()
        {
            Assert.AreEqual(336, Multiplication.Multiply(arrayB));
        }
    }
}