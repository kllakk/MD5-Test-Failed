using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual<string>(ClassLibrary.Class1.GetMd5Hash(""), "d41d8cd98f00b204e9800998ecf8427e");
        }
    }
}
