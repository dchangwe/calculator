using System;
using operations;

namespace CubeNumber
{
    public interface ICube
    {
        public dynamic CubeNumber(dynamic a);
    }
    public class Cubed
    {
        public dynamic result;
        public dynamic CubeNumber(dynamic a)
        {
            result = Cube.cubed(a);
                return result;

        }
    }
}
