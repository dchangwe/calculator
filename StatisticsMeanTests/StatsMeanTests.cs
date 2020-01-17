using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsMean;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsMean.Tests
{
    [TestClass()]
    public class StatsMeanTests
    {
        public static StatsMean fmean = new StatsMean();
        [TestMethod()]
        public void MeanIntTest()
        {
            int[] values = { 10, 20, 30 };
            double mean = fmean.Mean(values);
            Assert.AreEqual(20, mean);

        }
        [TestMethod()]
        public void MeanDoubleTest()
        {
            double[] values = { 2.0, 3.0, 4.0 };
            double mean = fmean.Mean(values);
            Assert.AreEqual(3, mean);

        }
        
    }
}