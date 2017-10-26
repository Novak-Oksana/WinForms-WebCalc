using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;



namespace UnitTestProjectCalc_WF
{
    [TestClass]
    public class UnitTestCalcWF
    {/*
         public static Application application = null;
         public static Window window = null;

         [ClassInitialize]
         public static void ClassSetup(TestContext e)
         {
           // application = new Application();
             Application application = Application.Launch(@"E:\work\Calculator\WindowsFormsCalc2\WindowsFormsCalc2\bin\Debug\WindowsFormsCalc2.exe");
             
         }

         [ClassCleanup]
         public static void ClassQuit()
         {
             application.Kill();
         }

         [TestInitialize]
         public void Setup()
         {
            
        }*/

        [DataTestMethod]
        [DataRow("btn0", "btn6", "op_plus", "6")]
        [DataRow("btn9", "btn6", "op_minus", "3")]
        [DataRow("btn2", "btn6", "op_mul", "12")]
        [DataRow("btn8", "btn4", "op_div", "2")]

        [TestMethod]
        public void TestMethodOp(string a, string b, string op, string exp)
        {
            Application application = Application.Launch(@"E:\work\Calculator\WindowsFormsCalc2\WindowsFormsCalc2\bin\Debug\WindowsFormsCalc2.exe");
            Window window = application.GetWindows()[0];
            window.Get<Button>(SearchCriteria.ByAutomationId(a)).Click();
            window.Get<Button>(SearchCriteria.ByAutomationId(op)).Click();
            window.Get<Button>(SearchCriteria.ByAutomationId(b)).Click();
            window.Get<Button>(SearchCriteria.ByAutomationId("btn_equal")).Click();
            string res = window.Get<TextBox>(SearchCriteria.ByAutomationId("txtres")).Text;
            Assert.AreEqual(exp, res);
            application.Kill();
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
            Application application = Application.Launch(@"E:\work\Calculator\WindowsFormsCalc2\WindowsFormsCalc2\bin\Debug\WindowsFormsCalc2.exe");
            Window window = application.GetWindows()[0];
            window.Get<Button>(SearchCriteria.ByAutomationId(btn)).Click();
            string res = window.Get<TextBox>(SearchCriteria.ByAutomationId("txtres")).Text;
            Assert.AreEqual(exp, res);
            application.Kill();
        }

        [TestMethod]
        public void TestComplexChek()
        {
            Application application = Application.Launch(@"E:\work\Calculator\WindowsFormsCalc2\WindowsFormsCalc2\bin\Debug\WindowsFormsCalc2.exe");
            Window window = application.GetWindows()[0];
            window.Get<Button>(SearchCriteria.ByAutomationId("btn1")).Click();
            window.Get<Button>(SearchCriteria.ByAutomationId("btn2")).Click();
            window.Get<Button>(SearchCriteria.ByAutomationId("btn3")).Click();
            window.Get<Button>(SearchCriteria.ByAutomationId("btn4")).Click();
            string res = window.Get<TextBox>(SearchCriteria.ByAutomationId("txtres")).Text;
            Assert.AreEqual("1234", res);
            application.Kill();
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
        [DataRow("op_plus", true)]
        [DataRow("op_minus", true)]
        [DataRow("op_mul", true)]
        [DataRow("op_div", true)]
        [DataRow("btn_equal", true)]
        [DataRow("txtres", true)]
        [TestMethod]
        public void TestElementAvailability(string el, bool exp)
        {
            Application application = Application.Launch(@"E:\work\Calculator\WindowsFormsCalc2\WindowsFormsCalc2\bin\Debug\WindowsFormsCalc2.exe");
            Window window = application.GetWindows()[0];
            bool res = false;
            if (el == "txtres")
            {
                if (window.Get<TextBox>(SearchCriteria.ByAutomationId("txtres")).Visible)
                {
                    res = true;
                }
            }
            else
            {
                if (window.Get<Button>(SearchCriteria.ByAutomationId(el)).Visible)
                {
                    res = true;
                }
            }
            Assert.AreEqual(res, exp);
            application.Kill();
        }

    }
}




