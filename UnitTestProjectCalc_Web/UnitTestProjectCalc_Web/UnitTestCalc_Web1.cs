using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace UnitTestProjectCalc_Web
{
    [TestClass]
    public class UnitTestCalc_Web1
    {

        [DataTestMethod]
        [DataRow("0", "6", "+", "6")]
        [DataRow("9", "6", "-", "3")]
        [DataRow("2", "6", "*", "12")]
        [DataRow("8", "4", "/", "2")]

        [TestMethod]
        public void TestMethodPlus(string a, string b, string op, string exp)
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(" file:///E:/work/Calculator/calc1.html");
            driver.FindElementById("atxt").SendKeys(a);
            driver.FindElementById("btxt").SendKeys(b);
            driver.FindElementById("op").SendKeys(op);
            driver.FindElementById("btncalc").Click();
            string res = driver.FindElementById("txtres").GetAttribute("value");
            Assert.AreEqual(exp, res);
            driver.Close();
        }
        
    }
}
