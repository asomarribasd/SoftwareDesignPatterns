using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GOF.Creational
{
    /// <summary>
    /// Implementacion del Patron Singleton (Singleton Design Pattern)
    /// La clase es sealed por que no hay por que heredarla para su uso
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton _instance = new Singleton();
        // El constructor es privado, nadie fuera de la clase puede instanciarlo 
        private Singleton()
        {
        }

        /// <summary>
        /// Unico accesso a la instancia
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }

        # region Implementacion del singleton

        // Adicionalmente puedes agregar tantos miembros como te sean necesarios   
        public string SayHello()
        {
            string returnText;
            returnText = "Hello World!";
            return returnText;
        }

        # endregion
    }
}
