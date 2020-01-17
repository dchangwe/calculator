using System;
using StatsOperations;

namespace StatisticsMean
{
    public class StatsMean : IStatsMean
    {
        public static dynamic result;

        public dynamic Mean(dynamic a)
        {
            
            result =StatisticMean.Mean(a);
            return result;
        }
    }
}
