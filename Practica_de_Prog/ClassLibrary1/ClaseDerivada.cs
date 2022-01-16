using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClaseDerivada : ClaseGenerica<Persona, int>, //Interfaz1
    {
        public void OtroMetodo(Interfaz1 param)
        {

        }

        public void Metodo1()
        {

        }

        ClaseDerivada der = new ClaseDerivada();
       
    }
}
