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
            var result = Division.Quotient(sum, valueCount);
            return result;
        }
    }
}
