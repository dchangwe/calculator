using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;


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
        public void AddIntTest()
        {

            Assert.AreEqual(15, calculator.Add(a, b));
            

            
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
        public void CubeIntTest()
        {
            int x = a * a * a;
            int y = calculator.CubedNumber(a);
            Assert.AreEqual(x, y);
            

        }

        [TestMethod()]
        public void RootIntTest()
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
            double z = calculator.CubedNumber(e);
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
            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(a, c));
        }

       
    }
}