using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatsOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsOperations.Tests
{
    [TestClass()]
    public class StatsVarianceTests
    {
        [TestMethod()]
        public void VarianceTest()
        {
            int[] values = { 2,4,6,8};
            var variance = StatsVariance.Variance(values);
            Assert.AreEqual(5, Helpers.Rounding.RoundFiveDecimals(variance));
            
        }
    }
}