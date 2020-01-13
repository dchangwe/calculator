using System;
using operations;
using Add;
using Divide;
using Multiply;
using SquaredNumber;
using SquareRootNumber;
using CubeNumber;
using Subtract;
namespace BasicCalculator
{
   
    public class Calculator : IAdd, IDivide,IMultiply,ISquareNumber,ICube,ISquareRoot,ISubtract
    {
        Adding add = new Adding();
        Dividing divide = new Dividing();
        Multiplying multiply = new Multiplying();
        Square square = new Square();
        Cube cube = new Cube();
        RootNumber root = new RootNumber();
        Subtracting subtract = new Subtracting();
        public  dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = add.Add(a, b);
            return result;
        }
        public dynamic Divide(dynamic a, dynamic b)
        {
            result = divide.Divide(a, b);
            return result;
        }
        public dynamic Subtract(dynamic a, dynamic b)
        {
            result = subtract.Subtract (a, b);
            return result;
        }
        public dynamic Multiply(dynamic a, dynamic b)
        {
            result = multiply.Multiply(a, b);
            return result;
        }
public dynamic SquaredNumber(dynamic a)
        {
            result = square.SquaredNumber(a);
            return result;
        }

        public dynamic Cubed(dynamic a)
        {
            result = cube.Cubed(a);
            return result;
        }
        public dynamic Root(dynamic a)
        {
            result = root.Root(a);
            return result;
        }
    }
}
