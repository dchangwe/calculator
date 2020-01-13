using System;
using StatsOperations;

namespace StatisticsVariance
{
    public class FindVariance 
    {
        public static dynamic result;
        public double Variance(dynamic arrayA)
        {
            result = StatsOperations.StatsVariance.Variance(arrayA);
            return result;
        }
    }
}
