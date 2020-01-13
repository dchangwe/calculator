using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;

namespace StatisticsCalculatorTests
{
    [TestClass]
    public class StatsCalculatorTests
    {
        private readonly StatsCalculator statsCal = new StatsCalculator();
        private readonly int[] values = { 2,4,6,8 };
        private readonly int score = 3;
        private readonly double[] doubleVal = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        private readonly double doubleScore = 2.2;

        [TestMethod]
        public void FindMeanTest()
        {
            var mean = statsCal.Mean(values);
            Assert.AreEqual(5, mean);
        }
        public void VarianceTest()
        {
            var mean = statsCal.Variance(values);
            Assert.AreEqual(5, mean);
        }
        public void FindStandardDevTest()
        {
            var standDev = statsCal.StandardDev(values);
            Assert.AreEqual(2.23606, Helpers.Rounding.RoundFiveDecimals(standDev));
        }
        [TestMethod()]
        public void ZScoreIntTest()
        {
            var z = statsCal.StatZScore(score, values);
            Assert.AreEqual(-0.89443, Helpers.Rounding.RoundFiveDecimals(z));
        }

        [TestMethod()]
        public void MeanDoubleTest()
        {
            var mean = statsCal.Mean(doubleVal);
            Assert.AreEqual(3.3, mean);
        }

        [TestMethod()]
        public void VarianceDoubleTest()
        {
            var variance = statsCal.Variance(doubleVal);
            Assert.AreEqual(2.09, Helpers.Rounding.RoundFiveDecimals(variance));
        }

        [TestMethod()]
        public void StandDevDoubleTest()
        {
            var standDev = statsCal.StandardDev(doubleVal);
            Assert.AreEqual(1.44568, Helpers.Rounding.RoundFiveDecimals(standDev));
        }

        [TestMethod()]
        public void ZScoreDoubleTest()
        {
            var z = statsCal.StatZScore(doubleScore, doubleVal);
            Assert.AreEqual(-0.76089, Helpers.Rounding.RoundFiveDecimals(z));
        }
    }
}
