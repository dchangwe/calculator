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
        public void MeanIntTest()
        {
            int[] values = {10,20,30};
            var mean = StatisticsMean.Mean(values);
            Assert.AreEqual(20, mean);
            
        }
        [TestMethod()]
        public void MeanDoubleTest()
        {
            double[] values = { 2.0,3.0,4.0};
            var mean = StatisticsMean.Mean(values);
            Assert.AreEqual(3, mean);

        }
    }
}