using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleLib;

namespace TriangleTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WrongArguments()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            Triangle triangle = new Triangle(a, b, c);
        }
      
        [TestMethod]
        public void GetSquare()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            Triangle triangle = new Triangle(a, b, c);
            
            double expected = 6;
            double actual = triangle.GetSquare();

            Assert.AreEqual(expected, actual, 0.1, "Method 'Square' doesn't work.");
        }
       
        [TestMethod]
        public void GetPerimeter()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            Triangle triangle = new Triangle(a, b, c);

            double expected = 12;
            double actual = triangle.GetPerimeter();

            Assert.AreEqual(expected, actual, 0.1, "Method 'Perimeter' doesn't work.");
        }

        [TestMethod]
        public void GetNormalType()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            Triangle triangle = new Triangle(a, b, c);

            string expected = "normal";
            string actual = triangle.Type;

            Assert.AreEqual(expected, actual,"Method 'Type' doesn't work.");
        }

        [TestMethod]
        public void GetIsoscelesType()
        {
            int a = 1;
            int b = 2;
            int c = 2;
            Triangle triangle = new Triangle(a, b, c);

            string expected = "isosceles";
            string actual = triangle.Type;

            Assert.AreEqual(expected, actual, "Method 'Type' doesn't work.");
        }

        [TestMethod]
        public void GetEquileteralType()
        {
            int a = 1;
            int b = 1;
            int c = 1;
            Triangle triangle = new Triangle(a, b, c);

            string expected = "equileteral";
            string actual = triangle.Type;

            Assert.AreEqual(expected, actual, "Method 'Type' doesn't work.");
        }
    }
}
