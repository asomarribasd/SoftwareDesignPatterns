using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.GOF.Creational;

namespace DesignPatternsTest
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void TestMethod1()
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
