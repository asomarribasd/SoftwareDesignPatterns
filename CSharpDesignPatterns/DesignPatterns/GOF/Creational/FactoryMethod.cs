using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GOF.Creational
{
    /// <summary>
    /// The 'Product' abstract class
    /// </summary>
    public abstract class baseProduct
    {
        public string name;
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class ConcreteProductA : baseProduct
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class ConcreteProductB : baseProduct
    {
    }

    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    public abstract class baseCreator
    {
        public abstract baseProduct FactoryMethod();
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteCreatorA : baseCreator
    {
        public override baseProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteCreatorB : baseCreator
    {
        public override baseProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
