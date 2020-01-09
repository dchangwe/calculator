using System;
using operations;

namespace Multiply
{
    public interface IMultiply
    {
        public dynamic Multiply(dynamic a, dynamic b);
    }
    public class Multiplying : IMultiply
    {
        public dynamic result;
        public dynamic Multiply(dynamic a, dynamic b)
        {
           
            result = Multiplication.Multiply(a, b);
            return result;
        }
    }
}
