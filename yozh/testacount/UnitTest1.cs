using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testacount
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testcounta()
        {
            string test = "чебурашка";
            int actcount = 2;

            yozh.Form1 f = new yozh.Form1();

            int count = f.acount(test);

            Assert.AreEqual(actcount, count);
        }

    }
}
