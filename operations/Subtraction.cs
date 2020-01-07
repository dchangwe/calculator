using System;
using System.Collections.Generic;
using System.Text;

namespace operations
{
  public  class Subtraction
    {
        public static int Subtract(int a,int b)
        {
            return a - b;
        }
        public static double Subtract(double a, double b)
        {
            
            return a - b;
        }
        public static double Subtract(double[] arrayA)
        {
            double c = 0.0;
            foreach (int a in arrayA)
            {
                c = Subtract(c,a);
            }
            return c;
            
        }
        public static int Subtract(int[] arrayB)
        {
            int c = arrayB[0];
            foreach (int a in arrayB)
            {
                c = Subtract(c, a);
            }
            int d = c + arrayB[0];
            return  d;
        }
    }
}
