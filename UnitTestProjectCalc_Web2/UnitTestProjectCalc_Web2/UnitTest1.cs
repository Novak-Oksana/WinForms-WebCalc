using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace UnitTestProjectCalc_Web2
{
    [TestClass]
    public class UnitTest1
    {

        public static ChromeDriver driver = null;

        [ClassInitialize]
        public static void ClassSetup(TestContext e)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(" file:///E:/work/Calculator/calc2.html");
        }

        [ClassCleanup]
        public static void ClassQuit()
        {
            driver.Quit();
        }

        [TestInitialize]
        public void Setup()
        {
            driver.Navigate().Refresh();
        }


        [DataTestMethod]
        [DataRow("btn0", "btn6", "btnPlus", "6")]
        [DataRow("btn9", "btn6", "btnMinus", "3")]
        [DataRow("btn2", "btn6", "btnMul", "12")]
        [DataRow("btn8", "btn4", "btnDiv", "2")]

        [TestMethod]
        public void TestMethodOp(string a, string b, string op, string exp)
        {
            driver.FindElementById(a).Click();
            driver.FindElementById(op).Click();
            driver.FindElementById(b).Click();
            driver.FindElementById("btnEqual").Click();
            string res = driver.FindElementById("txtres").GetAttribute("value");
            Assert.AreEqual(res, exp);
        }

        [DataTestMethod]
        [DataRow("btn0", "0")]
        [DataRow("btn1", "1")]
        [DataRow("btn2", "2")]
        [DataRow("btn3", "3")]
        [DataRow("btn4", "4")]
        [DataRow("btn5", "5")]
        [DataRow("btn6", "6")]
        [DataRow("btn7", "7")]
        [DataRow("btn8", "8")]
        [DataRow("btn9", "9")]
        [TestMethod]
        public void TestSimpleChek(string btn, string exp)
        {
            driver.FindElementById(btn).Click();
            string res = driver.FindElementById("txtres").GetAttribute("value");
            Assert.AreEqual(res, exp);
        }

        [TestMethod]
        public void TestComplexChek()
        {
            driver.FindElementById("btn1").Click();
            driver.FindElementById("btn2").Click();
            driver.FindElementById("btn3").Click();
            driver.FindElementById("btn4").Click();
            string res = driver.FindElementById("txtres").GetAttribute("value");
            Assert.AreEqual("1234", res);
        }

        [DataTestMethod]
        [DataRow("btn0", true)]
        [DataRow("btn1", true)]
        [DataRow("btn2", true)]
        [DataRow("btn3", true)]
        [DataRow("btn4", true)]
        [DataRow("btn5", true)]
        [DataRow("btn6", true)]
        [DataRow("btn7", true)]
        [DataRow("btn8", true)]
        [DataRow("btn9", true)]
        [DataRow("btnPlus", true)]
        [DataRow("btnMinus", true)]
        [DataRow("btnMul", true)]
        [DataRow("btnDiv", true)]
        [DataRow("btnEqual", true)]
        [DataRow("txtres", true)]
        [TestMethod]
        public void TestElementAvailability(string el, bool exp)
        {
            bool res = false;
            if (driver.FindElementById(el).Displayed)
            {
                res = true;
            }
            Assert.AreEqual(res, exp);
        }

    }
}
