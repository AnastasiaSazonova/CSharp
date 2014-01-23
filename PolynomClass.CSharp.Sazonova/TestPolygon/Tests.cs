using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolynomLib;
using System.Collections.Generic;

namespace TestPolygon
{
    [TestClass]
    public class Tests
    {
       /* [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorTestException()
        {
            List<double> list1 = new List<double> { };
            Polynom firstPolynom = new Polynom(list1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorTestException2()
        {
            List<double> list1 = new List<double> { 0 };
            Polynom firstPolynom = new Polynom(list1);
        }
       
        [TestMethod]
        public void AdditionTest()
        {
            List<double> list1 = new List<double> { 1, 1, 1 };
            List<double> list2 = new List<double> { 1, 1 };
            Polynom firstPolynom = new Polynom(list1);
            Polynom secondPolynom = new Polynom(list2);
            Polynom actualPolynom = firstPolynom + secondPolynom;
            List<double> actualResult = actualPolynom.GetPolynomsCoeffs();
            List<double> list3 = new List<double> { 1, 2, 2 };
            Polynom expectedPolynom = new Polynom(list3);
            List<double> expectedResult = actualPolynom.GetPolynomsCoeffs();
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            List<double> list1 = new List<double> { 1, 1, 1 };
            List<double> list2 = new List<double> { 1, 1 };
            Polynom firstPolynom = new Polynom(list1);
            Polynom secondPolynom = new Polynom(list2);
            Polynom actualPolynom = firstPolynom - secondPolynom;
            List<double> actualResult = actualPolynom.GetPolynomsCoeffs();
            List<double> list3 = new List<double> { 1, 0, 0 };
            Polynom expectedPolynom = new Polynom(list3);
            List<double> expectedResult = actualPolynom.GetPolynomsCoeffs();
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MultiplyingTest()
        {
            List<double> list1 = new List<double> { 1, 1, 1 };
            List<double> list2 = new List<double> { 1, 1 };
            Polynom firstPolynom = new Polynom(list1);
            Polynom secondPolynom = new Polynom(list2);
            Polynom actualPolynom = firstPolynom * secondPolynom;
            List<double> actualResult = actualPolynom.GetPolynomsCoeffs();
            List<double> list3 = new List<double> { 1, 2, 2, 1 };
            Polynom expectedPolynom = new Polynom(list3);
            List<double> expectedResult = actualPolynom.GetPolynomsCoeffs();
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MultiplyingTest2()
        {
            List<double> list1 = new List<double> { 1, 0, 0 };
            List<double> list2 = new List<double> { 1, 1 };
            Polynom firstPolynom = new Polynom(list1);
            Polynom secondPolynom = new Polynom(list2);
            Polynom actualPolynom = firstPolynom * secondPolynom;
            List<double> actualResult = actualPolynom.GetPolynomsCoeffs();
            List<double> list3 = new List<double> { 1, 1, 1, 1 };
            Polynom expectedPolynom = new Polynom(list3);
            List<double> expectedResult = actualPolynom.GetPolynomsCoeffs();
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DividingTest()
        {
            List<double> list1 = new List<double> { 1, 2, 2, 1 };
            List<double> list2 = new List<double> { 1, 1 };
            Polynom firstPolynom = new Polynom(list1);
            Polynom secondPolynom = new Polynom(list2);
            Polynom actualPolynom = firstPolynom / secondPolynom;
            List<double> actualResult = actualPolynom.GetPolynomsCoeffs();
            List<double> list3 = new List<double> { 1, 1, 1 };
            Polynom expectedPolynom = new Polynom(list3);
            List<double> expectedResult = actualPolynom.GetPolynomsCoeffs();
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DividingTestException()
        {
            List<double> list1 = new List<double> { 1, 2, 2, 1 };
            List<double> list2 = new List<double> { 1, 1 };
            Polynom firstPolynom = new Polynom(list2);
            Polynom secondPolynom = new Polynom(list1);
            Polynom actualPolynom = firstPolynom / secondPolynom;
        }*/
    }
}
