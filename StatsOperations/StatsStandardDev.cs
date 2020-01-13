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
            double variance = StatsVariance.Variance(values);
            double standardDev = SquareRoot.Root(variance);
            return standardDev;
        }
    }
}
