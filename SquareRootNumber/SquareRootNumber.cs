using System;
using operations;

namespace SquareRootNumber
{
    public interface ISquareRoot
    {
        public dynamic Root(dynamic a);
    }
    public class RootNumber : ISquareRoot
    {
        public dynamic result;
        public dynamic Root(dynamic a)
        {
            result = SquareRoot.Root(a);
            return result;
        }
    }
}
