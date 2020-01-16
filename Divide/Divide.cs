using System;
using BasicOperations;
namespace Divide
{
    public interface IDivide
    {
        public dynamic Quotient(dynamic a, dynamic b);
    }
    public class Dividing : IDivide
        {
            public dynamic result;

            public dynamic Quotient(dynamic a, dynamic b)
            {
                result = Division.Quotient(a, b);
                return result;
            }
        }
    }

