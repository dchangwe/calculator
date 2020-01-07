using System;
using operations;
namespace BasicCalculator
{
    public class Calculator
    {
        public int result;

        public int Add(int a, int b)
        {
            result = addition.Sum(a, b);
            return result;
        }
        public int Divide(int a, int b)
        {
            result = Division.Divide(a, b);
            return result;
        }
    }
}
