using System;
using operations;


namespace Sum
{
    public interface IAdd
    {
        public dynamic Add(dynamic a, dynamic b);

    }
    public class Adding :IAdd
    {
        public dynamic result;
        public dynamic Add(dynamic a, dynamic b)
        {
            result = addition.Sum(a, b);
            return result;
        }
    }
}
