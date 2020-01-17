using System;
using StatsOperations;

namespace StatsStandardDeviation
{
    public class FindStandardDev : IFindStandardDev
    {
        public static dynamic result;
        public double StandardDev(dynamic arrayA)
        {
            result = StatsStandardDev.StandardDev(arrayA);
            return result;
        }
    }
}
