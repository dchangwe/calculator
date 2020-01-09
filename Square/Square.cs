using System;
using operations;

namespace SquaredNumber
{
    public interface ISquareNumber
    {
        public dynamic SquaredNumber(dynamic a);
    }
    public class Squared: ISquareNumber
    {
        public dynamic result;
        public dynamic SquaredNumber(dynamic a)
        {
            result = Square.Squared(a);
            return result;
        }
     
    }
}
