using System;
using StatsOperations;

namespace StatisticsZScore
{
    public class ZScore : IZScore
    {
        public static dynamic result;

        public double StatZScore(dynamic score, dynamic values)
        {
            result =StatsZScore.StatZScore(score,values);
            return result;

        }
    }
}
