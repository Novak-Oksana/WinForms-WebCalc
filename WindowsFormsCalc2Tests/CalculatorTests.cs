using Microsoft.VisualStudio.TestTools.UnitTesting;
//using WindowsFormsCalc2.Form1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalc2 //.Form1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [DataTestMethod]
        [DataRow(1, 2, '+', 3)]
        [DataRow(1, 2, '*', 2)]
        [DataRow(1, 2, '-', -1)]
        [DataRow(2, 2, '/', 1)]

        [TestMethod()]
        public void funct_calcTest(int a, int b, char op, int exp)
        {
            int res = Form1.Calculator.funct_calc(a, b, op);
            Assert.AreEqual(exp, res); ;
        }
    }
}