using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsBookExpertSystem;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestisFactInWorkMemory()
        {
            Fact FakeFact = new Fact("Fake", "");
        }
    }
}
