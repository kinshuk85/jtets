using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using test.Controllers;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "weldone0";
        [TestMethod]
        public void TestMethod1()
        {
            
               
                var result = HomeController.test();
                Assert.AreEqual(Expected, result);
           
        }
    }
}
