using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAtencionAlCliente
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente { get; set; }
        public int ClientesPendientes { get; set; }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = caja;
        }

        public Negocio(string nombre)
        {

        }

        public static bool operator !=(Negocio n, Cliente c)
        {

        }

        public static bool operator ~(Negocio n)
        {

        }

        public static bool operator +(Negocio n, Cliente c)
        {

        }

        public static bool operator !=(Negocio n, Cliente c)
        {

        }
    }
}
