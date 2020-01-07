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
        
        
        [TestMethod()]
        public void rootTest()
        {
            Assert.AreEqual(3, SquareRoot.Root());
        }
        [TestMethod()]
        public void rootDoubleTest()
        {
            Assert.AreEqual(8.0, SquareRoot.Root());
        }
    }
}