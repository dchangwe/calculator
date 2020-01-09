using System;
using operations;
namespace Divide
{
    public interface IDivide
    {
        public dynamic Divide(dynamic a, dynamic b);
    }
    public class Dividing : IDivide
        {
            public dynamic result;

            public dynamic Divide(dynamic a, dynamic b)
            {
                result = Division.Divide(a, b);
                return result;
            }
        }
    }

