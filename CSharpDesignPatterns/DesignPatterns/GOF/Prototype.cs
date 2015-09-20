using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GOF
{
    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    abstract class Prototype
    {
        private string _id;

        // Constructor
        public Prototype(string id)
        {
            this._id = id;
        }

        // Gets id
        public string Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }

    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>
    class ImplementPrototypeA : Prototype
    {
        // Constructor
        public ImplementPrototypeA(string id)
            : base(id)
        {
        }

        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>
    class ImplementPrototypeB : Prototype
    {
        // Constructor
        public ImplementPrototypeB(string id)
            : base(id)
        {
        }

        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    } 
}
