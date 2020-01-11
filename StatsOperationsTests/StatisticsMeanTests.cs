using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatsOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsOperations.Tests
{
    [TestClass()]
    public class StatisticsMeanTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            int[] values = {10,20,30};
            var mean = StatisticsMean.Mean(values);
            Assert.AreEqual(20, mean);
            
        }
    }
}