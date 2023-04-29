using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskLibrary;
using MathTaskClassLibrary;
using System.ComponentModel;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void CalculateAreaTest()
        {
            int a = 3;
            int b = 5;
            int expected = 15;
            Geometry g = new Geometry();
            int actual = g.CalculateArea(a, b);
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod]
        public void CalculateAreaTest1()
        {
            bool catched = false;
            try
            {
                int a = -4;
                int b = 10;
                
                Geometry g = new Geometry();
                int actual = g.CalculateArea(a, b);
            }
            catch (ArgumentException e)
            {

                catched = true;
            }

            Assert.IsTrue(catched, "Не обработаны допустимые данные");
        }
        [TestMethod]
        public void CalculateAreaTest2()
        {
            int a = -4;
            int b = 10;
            Geometry g = new Geometry();
            Assert.ThrowsException<ArgumentException>(() => g.CalculateArea(a, b),
                "Не обработаны отрицательные длины сторон треугольника");
        }
        [TestMethod]
        public void GetFirstNLetters_ValidInput_ReturnsCorrectString()
        {
            Task1 a = new Task1();
            
            // Arrange
            int n = 5;
            string expected = "ABCDE";

            // Act
            string actual = a.GetFirstNLetters(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetFirstNLetters_InvalidInput_ThrowsArgumentException()
        {
            Task1 a = new Task1();
            // Arrange
            int n = 0;

            // Act
            string result = a.GetFirstNLetters(n);
        }
        [TestMethod]

        public void TestTwoRealRoots()
        {
            Task2 yoma = new Task2();
            
            double a = 1;
            double b = -3;
            double c = 2;

            double[] expected = { 2, 1 };

            double[] actual = yoma.SolveQuadraticEquation(a, b, c);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UgadayGodTest()
        {
            Task3 god = new Task3();
            int year = 1200;
            string expected = "Вискок";
            string actual = god.UgadayGod(year);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task4Test()
        {
            Task4 reg = new Task4();
            string email = "lol@mail.ru";
            string expected = "lol@mail.ru";
            string actual = reg.EmailChecker(email); 
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Task5Test()
        {
            Task5 w = new Task5();
            string input = "123";
            int expected = 6;
            int actual = w.SumOfNubers(input);
            Assert.AreEqual(expected, actual);

        }



    }
}
