using System;
using StatsOperations;

namespace StatisticsVariance
{
    public class FindVariance : IFindVariance
    {
        public static dynamic result;
        public double Variance(dynamic arrayA)
        {
            result = StatsVariance.Variance(arrayA);
            return result;
        }
    }
}
