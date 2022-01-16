using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface Interfaz2<Z> : Interfaz1 where Z : new()
    {
        void Metodo2(Z paraml);
        Q MetodoGenerico<Q>(object param);

        /*
        public override void  OtroMetodo(Interfaz1 param, string messsage) // No se puede sobreescribir en esta versio, en la 8.0 parece q si.
        {

        }*/
    }
}
