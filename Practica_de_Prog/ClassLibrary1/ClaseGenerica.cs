using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClaseGenerica<T,U> : Interfaz2<U> where U : class, new()
    //public class ClaseGenerica<T,U> : Interfaz2<T> where T : class, new() Punto 16, pareceria que si se puede
    {
        void Metodo1()
        {

        }

        void Metodo2()

       /// ClaseGenerica generi = new ClaseGenerica<Object, string>();

    }
}
