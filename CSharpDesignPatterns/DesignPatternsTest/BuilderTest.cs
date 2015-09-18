using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.GOF;

namespace DesignPatternsTest
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Director director = new Director();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            // Construct two products
            director.Construct(b1);
            Product p1 = b1.GetProductCreated();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetProductCreated();
            p2.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}
