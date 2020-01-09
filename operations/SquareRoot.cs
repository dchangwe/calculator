using System;
using System.Collections.Generic;
using System.Text;

namespace operations
{
  public  class SquareRoot
    {
        
        public static double Root(double b)
        {
             double c = Math.Sqrt(b);
            return c;
        }
        
        public static int Root(int a)
        {
            double b = Math.Sqrt(a);
            int c = Convert.ToInt32(b);
            return c;
        }
    }
}
