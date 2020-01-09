using System;
using operations;
using Add;
using Divide;
using Multiply;
using SquaredNumber;
namespace BasicCalculator
{
    public interface ICalculatorBasic
    {
        public dynamic Add(dynamic a, dynamic b);
        public dynamic Divide(dynamic a, dynamic b);
        public dynamic Subtract(dynamic a, dynamic b);
        public dynamic Multiply(dynamic a, dynamic b);
        public dynamic Square(dynamic a);
    }
    public class Calculator : IAdd, IDivide,IMultiply
    {
        Adding add = new Adding();
        Dividing divide = new Dividing();
        Multiplying multiply = new Multiplying();
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
public int Square(int a)
        {

        }


    }
}
