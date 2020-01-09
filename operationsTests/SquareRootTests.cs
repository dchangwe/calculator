using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
    [TestClass()]
    public class SquareRootTests
    {
        private readonly double b = 64.0;
        private readonly int a = 9;
        [TestMethod()]
        public void RootTest()
        {
            Assert.AreEqual(3, SquareRoot.Root(a));
        }
        [TestMethod()]
        public void RootDoubleTest()
        {
            Assert.AreEqual(8.0, SquareRoot.Root(b));
        }


    }
}