using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;
using operations;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly int a = 10;
        private readonly int b = 5;
        private readonly int c = 0;
        private readonly double d = 7.5;
        private readonly double e = 3.4;
        private readonly int f = 49;
        Calculator calculator = new Calculator();
        [TestMethod()]
        public void AddTest()
        {

            Assert.AreEqual(15, calculator.Add(a, b));
            

            
        }
        [TestMethod()]
        public void AddIntDoubleTest()
        {
            Calculator calculator = new Calculator();
            int a = 1;
            double b = 2.02;
            double c = calculator.Add(a, b);

            Assert.AreEqual(3.02, c);
            Assert.AreEqual(3.02, calculator.result);


        }

        [TestMethod()]
        public void DivideIntTest()
        { 
            Assert.AreEqual(2, calculator.Divide(a, b));
              
        }
        [TestMethod()]
        public void SubtractIntTest()
        { 
            Assert.AreEqual(5, calculator.Subtract(a, b));
          
        }
        [TestMethod()]
        public void MultiplyIntTest()
        {
            Assert.AreEqual(50, calculator.Multiply(a, b));
            

        }
        [TestMethod()]
        public void SquaredNumberIntTest()
        {
            int x = a * a;
            int z = calculator.SquaredNumber(a);
            Assert.AreEqual(x, z);
            

        }
        [TestMethod()]
        public void CubeTest()
        {
            int x = a * a * a;
            int y = calculator.Cubed(a);
            Assert.AreEqual(x, y);
            

        }

        [TestMethod()]
        public void RootTest()
        {
            
            Assert.AreEqual(7, calculator.Root(f));
            

        }

        [TestMethod()]
        public void AddDoubleTest()
        {

            Assert.AreEqual(10.9, calculator.Add(d,e));
 }

        [TestMethod()]
        public void SubtractDoubleTest()
        {

            Assert.AreEqual(4.1, calculator.Subtract(d,e));


        }

        [TestMethod()]
        public void MultiplyDoubleTest()
        {

            Assert.AreEqual(25.5, calculator.Multiply(d,e));
 }

        [TestMethod()]
        public void DivideDoubleTest()
        {

            Assert.AreEqual(2.20588, calculator.Divide(d,e));


        }

        [TestMethod()]
        public void SquareDoubleTest()
        {
            double x = d * d;
            double z = calculator.SquaredNumber(d);
            Assert.AreEqual(x, z);
         }

        [TestMethod()]
        public void CubeDoubleTest()
        {
            double x = e * e * e;
            double z = calculator.Cubed(e);
            Assert.AreEqual(x, z);
        }


        [TestMethod()]
        public void RootDoubleTest()
        {

            Assert.AreEqual(1.843901, calculator.Root(e));


        }
    
        [TestMethod()]
        public void QuoIntDivideZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Division.Divide(a, c));
        }

       
    }
}