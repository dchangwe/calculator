using System;
using operations;

namespace StatsOperations
{
    public class StatisticsMean 
    {
        public static dynamic Mean(dynamic values)
        {
            var sum = operations.addition.Sum(values);
            var valueCount = Helpers.Arrays.Length(values);
            var result = operations.Division.Divide(sum, valueCount);
            return result;
        }
    }
}
