using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.GOF.Creational;

namespace DesignPatternsTest
{
    [TestClass]
    public class CreationalPatternsTest
    {

        [TestMethod]
        public void BuilderTest()
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

        }

        [TestMethod]
        public void SingletonTest()
        {
            Assert.AreEqual<string>(Singleton.Instance.SayHello(), "Hello World!");
        }

        [TestMethod]
        public void FactoryMethodTest()
        {
            // An array of creators
            baseCreator[] creators = new baseCreator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products
            foreach (baseCreator creator in creators)
            {
                baseProduct product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }

        }
    }
}
