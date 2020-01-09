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
    public interface ICalculatorBasic
    {
        public dynamic Add(dynamic a, dynamic b);
        public dynamic Divide(dynamic a, dynamic b);
        public dynamic Subtract(dynamic a, dynamic b);
        public dynamic Multiply(dynamic a, dynamic b);
        public dynamic Square(dynamic a);
        public dynamic Cubed(dynamic a);
        public dynamic Root(dynamic a);
    }
    public class Calculator : IAdd, IDivide,IMultiply,ISquareNumber,ICube,ISquareRoot,ISubtract
    {
        Adding add = new Adding();
        Dividing divide = new Dividing();
        Multiplying multiply = new Multiplying();
        Square square = new Square();
        Cube cube = new Cube();
        RootNumber root = new RootNumber();
        public  dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = addition.Sum(a, b);
            return result;
        }
        public dynamic Divide(dynamic a, dynamic b)
        {
            result = Division.Divide(a, b);
            return result;
        }
        public dynamic Subtract(dynamic a, dynamic b)
        {
            result = Subtraction.Subtract(a, b);
            return result;
        }
        public dynamic Multiply(dynamic a, dynamic b)
        {
            result = Multiplication.Multiply(a, b);
            return result;
        }
public dynamic SquaredNumber(dynamic a)
        {
            result = Square.Squared(a);
            return result;
        }

        public dynamic CubedNumber(dynamic a)
        {
            result = Cube.cubed(a);
            return result;
        }
        public dynamic Root(dynamic a)
        {
            result = SquareRoot.Root(a);
            return result;
        }
    }
}
