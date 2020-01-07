using System;

namespace operations
{
    public class addition
    
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static double Sum(double a,double b)
        {
            return a + b;
        }
        public static double Sum(double[] arrayA)
        {
            double c = 0.0;
            foreach (double a in arrayA)
            {
                 c=Sum(a,c);
            }
            return c;
        }
        public static double Sum(int[] arrayB)
        {
            double c = 0.0;
            foreach (double a in arrayB)
            {
                c = Sum(a, c);
            }
            return c;
        }
    }
}
