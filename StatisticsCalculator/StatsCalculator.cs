using System;
using BasicCalculator;
using StatisticsMean;



namespace StatisticsCalculator
{
    public class StatsCalculator : Calculator , IStatsMean
    {
        private readonly StatsMean mean = new StatsMean();
        public  dynamic Mean(dynamic values)
        {
            return mean.Mean(values);
        }
    }
}
