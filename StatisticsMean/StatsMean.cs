using System;

namespace StatisticsMean
{
    public class StatsMean : IStatsMean
    {
        public static dynamic result;

        public dynamic Mean(dynamic a)
        {
            
            result = StatsOperations.StatisticsMean.Mean(a);
            return result;
        }
    }
}
