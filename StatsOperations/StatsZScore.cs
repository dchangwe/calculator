using System;
using System.Collections.Generic;
using System.Text;
using operations;

namespace StatsOperations
{
  public  class StatsZScore
    {
        public static double StatZScore(dynamic score, dynamic values)
        {
            double mean = StatisticsMean.Mean(values);
            double standDev = StatsStandardDev.StandardDev(values);
            double zScore = Division.Quotient(Subtraction.Subtract(score, mean), standDev);
            return zScore;
        }
    }
}
