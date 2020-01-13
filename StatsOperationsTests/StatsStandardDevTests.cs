using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatsOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsOperations.Tests
{
    [TestClass()]
    public class StatsStandardDevTests
    {
        [TestMethod()]
        public void StandardDevTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var standDev = StatsStandardDev.StandardDev(values);
            Assert.AreEqual(1.41421, Helpers.Rounding.RoundFiveDecimals(standDev));
            
        }
        [TestMethod()]
        public void StandardDevDoubleTest()
        {
            double[] values = { 2.0,3.0,4.0};
            var standDev = StatsStandardDev.StandardDev(values);
            Assert.AreEqual(0.81650, Helpers.Rounding.RoundFiveDecimals(standDev));

        }
    }
}