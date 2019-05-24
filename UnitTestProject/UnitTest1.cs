using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] str = { "s" };
            var expectedOutput = "104616";
            var actualOutput = InputConverter.ConvertInput(str);
            Assert.AreEqual(expectedOutput, actualOutput);

        }
    }
}
