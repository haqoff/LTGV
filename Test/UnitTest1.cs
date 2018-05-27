using System;
using LTGV;
using LTGV.Format;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetExcelColumnName()
        {
            //arrange
            int indexX = 2;
            string expected = "A";
            //act
            string res = StringUtils.GetExcelColumnName(indexX, 2);
            //assert
            Assert.AreEqual(expected,res);
        }

        [TestMethod]
        public void TestReplaceFormatter()
        {
            //arrange
            string input = "04.2018";
            string expected = "04";

            ReplaceFormatter rf = new ReplaceFormatter();
            rf.CbEnabled.Checked = true;
            rf.TbCommand.Text = "{.2018}{}";
            rf.ParseCommand();


            //act
            string act = rf.Format(input);

            //assert
            Assert.AreEqual(expected, act);
        }
    }
}
