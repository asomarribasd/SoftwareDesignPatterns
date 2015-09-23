using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.GOF.Creational;

namespace DesignPatternsTest
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void TestSayHello()
        {
            Assert.AreEqual<string>(Singleton.Instance.SayHello(), "Hello World!");
        }
    }
}
