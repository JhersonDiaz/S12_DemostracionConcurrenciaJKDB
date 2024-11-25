using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcu_Jherson_Kelvin_Diaz_Bravo
{
    public sealed class Singleton //Clase singleton definido como sealed para que no puedan heredar
    {
        private static Singleton instance = null;
        private static readonly object Bloqueo = new object();//Nos va a permitir el bloqueó

        public string CadenaConexion;
        public Singleton()//Contructor
        {
            instance = this;
        }

        public static Singleton Instance
        {
            get
            {
                lock (Bloqueo)
                {
                    if (instance == null) 
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }
}
