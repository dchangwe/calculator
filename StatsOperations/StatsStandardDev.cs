using System;
using System.Collections.Generic;
using System.Text;
using operations;

namespace StatsOperations
{
  public  class StatsStandardDev
    {
        public static double StandardDev(dynamic values)
        {
            double mean = StatisticMean.Mean(values);
            double difference = 0;
            double variance = 0;

            foreach (int a in values)
            {
                difference = Subtraction.Subtract((int)mean, a);
                difference = Math.Pow(difference, 2);
                variance = addition.Sum(variance, (int)difference);

            }
            int ValueCount = Helpers.Arrays.Length(values);
            variance = Division.Quotient(variance, ValueCount);
            double standardDev = SquareRoot.Root(variance);
            return standardDev;
          
        }
    }
}
