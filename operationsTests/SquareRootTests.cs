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
        //private readonly int a = 9;
        private readonly double b = 64.0;
        
        
        //[TestMethod()]
        //public void rootIntTest()
        //{
        //    Assert.AreEqual(3, SquareRoot.Root());
        //}
        [TestMethod()]
        public void rootDoubleTest()
        {
            Assert.AreEqual(8.0, SquareRoot.Root(b));
        }
    }
}