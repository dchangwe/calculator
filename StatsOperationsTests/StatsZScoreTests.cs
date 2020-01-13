using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatsOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsOperations.Tests
{
    [TestClass()]
    public class StatsZScoreTests
    {
        [TestMethod()]
        public void ZScoreIntTest()
        {
            int[] values = {  3, 4, 5 };
            int score = 2;
            var zScore = StatsZScore.StatZScore(score, values);
            Assert.AreEqual(-2.44949, Helpers.Rounding.RoundFiveDecimals(zScore));
        }

        [TestMethod()]
        public void ZScoreDoubleTest()
        {
            double[] values = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double score = 2.2;
            var zScore = StatsZScore.StatZScore(score, values);
            Assert.AreEqual(-0.76089, Helpers.Rounding.RoundFiveDecimals(zScore));
        }
       
    }
}