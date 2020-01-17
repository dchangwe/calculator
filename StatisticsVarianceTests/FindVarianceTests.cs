using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsVariance;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsVariance.Tests
{
    
    [TestClass()]
    public class FindVarianceTests
    {
        public static FindVariance findVariance = new FindVariance();
        [TestMethod()]
        public void VarianceIntTest()
        {
            int[] values = { 2, 4, 6, 8 };
            double variance = findVariance.Variance(values);
            Assert.AreEqual(5, Helpers.Rounding.RoundFiveDecimals(variance));
            
        }
        [TestMethod()]
        public void VarianceDoubleTest()
        {
            double[] values = { 2.0, 3.0, 4.0 };
            double variance = findVariance.Variance(values);
            Assert.AreEqual(0.66667, Helpers.Rounding.RoundFiveDecimals(variance));

        }
    }
}