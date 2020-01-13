using System;
using BasicCalculator;
using StatisticsMean;
using StatsStandardDeviation;
using StatisticsVariance;
using StatisticsZScore;

namespace StatisticsCalculator
{
    public class StatsCalculator : Calculator , IStatsMean , IFindStandardDev , IFindVariance , IZScore
    {
        private readonly StatsMean mean = new StatsMean();
        private readonly FindStandardDev standardDev = new FindStandardDev();
        private readonly FindVariance variance = new FindVariance();
        private readonly ZScore z = new ZScore();
        public  dynamic Mean(dynamic values)
        {
            return mean.Mean(values);
        }
        public double Variance(dynamic values)
        {
            return variance.Variance(values);
        }
        public double StandardDev(dynamic values)
        {
            return standardDev.StandardDev(values);
        }
        public double StatZScore(dynamic score, dynamic values)
        {
            return z.StatZScore(score, values);
        }
    }
}
