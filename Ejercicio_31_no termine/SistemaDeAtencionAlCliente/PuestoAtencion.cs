using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAtencionAlCliente
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public enum Puesto
        {
            Caja1,
            caja2
        }

        public int NumeroActual 
        { 
            get
            {
                return numeroActual +=  numeroActual;
            }
                
        }

        public bool Atender(Cliente cli)
        {
            //cli.Thread
        }

        static PuestoAtencion()
        {
           PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) :this()
        {
            this.puesto = puesto;
        }
    }
}
