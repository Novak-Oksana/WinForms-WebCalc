using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JSTest;
using JSTest.ScriptLibraries;



namespace UnitTestProjectCalc_Web2
{
    [TestClass]
    public class UnitTest2
    {
        private readonly TestScript commonTestScript = new TestScript();
       
        public void CommonJavaScriptTests()
        {
            commonTestScript.AppendFile(@":///E:/work/Calculator/calc2.js");
            commonTestScript.AppendBlock(new JsAssertLibrary());
        }
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void funcTest()
        {
           
            
            commonTestScript.RunTest(@"assert.equal(15, funct_calc(3, 5, '*'));");
            //Assert.AreEqual();
        }
       
    }
    
}
