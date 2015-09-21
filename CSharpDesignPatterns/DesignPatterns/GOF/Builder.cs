using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GOF
{
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    public abstract class ProductBuilder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetProductCreated();
    }

    /// <summary>
    /// The 'Director' class, handle the steps of the build process
    /// </summary>
    public class Director
    {
        // Builder have the same steps, but the implementation of each step is different
        public void Construct(ProductBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    /// <summary>
    /// The 'ProductBuilderA' class is an implemntation of a Product Builder
    /// </summary>
    public class ProductBuilderA : ProductBuilder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("Component A");
        }

        public override void BuildPartB()
        {
            _product.Add("Component C");
        }

        public override Product GetProductCreated()
        {
            return _product;
        }
    }

    /// <summary>
    /// The 'ProductBuilderB' class class is an implemntation of a Product Builder
    /// </summary>
    public class ProductBuilderB : ProductBuilder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("Component D");
        }

        public override void BuildPartB()
        {
            _product.Add("Component T");
        }

        public override Product GetProductCreated()
        {
            return _product;
        }
    }

    /// <summary>
    /// The 'Product' class to be builded, in this case a container of components
    /// </summary>
    public class Product
    {
        private List<string> _components = new List<string>();

        public void Add(string components)
        {
            _components.Add(components);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Components -------");
            foreach (string component in _components)
            { 
                Console.WriteLine(component);
            }
        }

        public List<string> Components
        {
            get { return this._components; }
        }
    }

}
