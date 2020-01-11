using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;

namespace StatisticsCalculatorTests
{
    [TestClass]
    public class StatsCalculatorTests
    {
        private readonly StatsCalculator statsCal = new StatsCalculator();
        private readonly int[] values = { 2,4,6,8 };
        [TestMethod]
        public void FindMeanTest()
        {
            var mean = statsCal.Mean(values);
            Assert.AreEqual(5, mean);
        }
    }
}
