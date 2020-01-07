using System;
using System.Collections.Generic;
using System.Text;

namespace operations
{
  public  class Multiplication
    {
        public static int Multiply(int a , int b)
        {
            return a * b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Multiply(double[] arrayA)
        {
            double c = arrayA[0];
            foreach (int a in arrayA)
            {
                c = Multiply(c, a);
            }
            double d = c / arrayA[0];
            return d;
        }
        public static int Multiply(int[] arrayB)
        {
            int c = 1;
            foreach (int a in arrayB)
            {
                c = Multiply(c, a);
            }
            
            return c;
        }
    }
}
