using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
    [TestClass()]
    public class CubeTests
    {
        private readonly int a = 4;
        private readonly double b = 6.0;
        [TestMethod()]
        public void cubeTest()
        {
            Assert.AreEqual(64, Cube.cubed(a));
        }
        [TestMethod()]
        public void cubeDoubleTest()
        {
            Assert.AreEqual(216, Cube.cubed(b));
        }
    }
}