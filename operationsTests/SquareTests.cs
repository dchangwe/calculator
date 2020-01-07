using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly int a = 6;
        private readonly double b = 3.0;
        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(36, Square.Squared(a));
        }
        [TestMethod()]
        public void SquaredDoubleTest()
        {
            Assert.AreEqual(9, Square.Squared(b));
        }
    }
}