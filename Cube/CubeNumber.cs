using System;
using operations;

namespace CubeNumber
{
    public interface ICube
    {
        public dynamic CubedNumber(dynamic a);
    }
    public class Cubed
    {
        public dynamic result;
        public dynamic CubedNumber(dynamic a)
        {
            result = Cube.cubed(a);
                return result;


        }
    }
}
