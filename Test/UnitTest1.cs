using System;
using LTGV;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEngChar()
        {
            //arrange
            int indexX = 2;
            string expected = "A";
            //act
            string res = StringUtils.GetExcelColumnName(indexX, 2);
            //assert
            Assert.AreEqual(expected,res);
        }
    }
}
