using System;
using NUnit.Framework;
using HelloworldLib;

namespace HelloworldTest
{
    [TestFixture]
    public class HelloworldTest
    {
        [Test]
        public void TestMethodGetName()
        {
            MyLibClass classObject = new MyLibClass();
            string output = classObject.GetName();
            //string actual = "HelloworldLib";
            //Assert.AreEqual<string>(actual, output);
        }

        [Test]
        public void TestMethodGetDate()
        {
            MyLibClass classObject = new MyLibClass();
            DateTime output = classObject.getDate();
            //Assert.AreEqual<DateTime>(DateTime.Now, output);
        }
    }
}
