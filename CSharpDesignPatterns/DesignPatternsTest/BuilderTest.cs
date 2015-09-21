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

            ProductBuilder b1 = new ProductBuilderA();
            ProductBuilder b2 = new ProductBuilderB();

            // Construct two products
            director.Construct(b1);
            Product p1 = b1.GetProductCreated();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetProductCreated();
            p2.Show();
            Assert.IsTrue(p2.Components.Count == 2);
            // Wait for user
            //Console.ReadKey();
        }
    }
}
