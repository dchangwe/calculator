using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 6;
        private readonly int b = 2;
        private readonly double c = 4.5;
        private readonly double d = 1.3;
        private readonly double[] arrayA = { 1.0, 2.0, 3.0};
        private readonly int[] arrayB = { 2, 3, 4, 5 };


        [TestMethod()]
        public void SubtractTest()
        {
            Assert.AreEqual(4, Subtraction.Subtract(a, b));
        }
        [TestMethod()]
        public void SubtractDoubleTest()
        {
            Assert.AreEqual(3.2, Subtraction.Subtract(c, d));
        }
        [TestMethod()]
        public void SubtractDoubleArrayTest()
        {
            Assert.AreEqual(-6, Subtraction.Subtract(arrayA));
        }
        [TestMethod()]
        public void SubtractIntArrayTest()
        {
            Assert.AreEqual(-10, Subtraction.Subtract(arrayB));
        }
    }
}