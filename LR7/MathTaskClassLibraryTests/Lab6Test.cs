using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskLibrary;
using MathTaskClassLibrary;
using System.ComponentModel;
using static MathTaskClassLibrary.Integrator;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class Lab6Test
    {
        [TestMethod]
        [DataRow(0,20,0, 8000)]
        [DataRow(1,20,40, 17466.67)]
        [DataRow(15,23,41, 1.7651665)]
        public void IntegrastorTest(double a, double b, double c, double expectedResult)
        {
            Equation e = new QuadEquation(a, b, c);
            Integrator i1 = new Integrator(e);
            double integrValue = i1.Integrate(10, 30);
            double actual = integrValue;
            Assert.AreEqual(expectedResult, actual, 0.2);
            
        }

    }
}
