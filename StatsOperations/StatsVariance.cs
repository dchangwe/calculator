using System;
using System.Collections.Generic;
using System.Text;
using operations;

namespace StatsOperations
{
 public class StatsVariance
    {
public static double Variance(dynamic values)
        {
            double mean = StatisticsMean.Mean(values);
            double[] squareDeviation = new double[Helpers.Arrays.Length(values)];
            int i = 0;
            foreach( int a in values)
            {
                squareDeviation[i] = Square.Squared(Subtraction.Subtract(a, mean));
                i++;
            }
            double variance = StatisticsMean.Mean(squareDeviation);
            return variance;
        }
    }
}
