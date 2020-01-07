using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 30;
        private readonly int b = 5;
        private readonly double c = 15.3;
        private readonly double d = 5.0;
        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(6, Division.Divide(a, b));
        }
        [TestMethod()]
        public void DivideDoubleTest()
        {
            Assert.AreEqual(3.06, Division.Divide(c, d));
        }
    }
}