using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
         
            double operant1 = 4;
            double operant2 = 2;
            double expected = 20;
            var dimensions = new Dimensions();

            double factresult = dimensions.Sqrt(operant1, operant2);

            Assert.AreEqual(expected, factresult);

        }
    }
}
