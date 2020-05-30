using System;
using SpellNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpellNumber_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Check 13456 result 
        public void TestMethod1()
        {
            string result = SpellNumber.Program.NumberTowords(13456);
            Assert.IsTrue(result == "Thirteen Thousand  Four Hundred And Fifty Six");
        }

        [TestMethod]
        //Check 13456 result 
        public void TestMethod2()
        {
            string result = SpellNumber.Program.NumberTowords(null);
            Assert.IsTrue(result == "Thirteen Thousand  Four Hundred And Fifty Six");
        }
    }
}
