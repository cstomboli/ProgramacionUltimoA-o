using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAtencionAlCliente
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre 
        { 
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        
        }
        public int Numero 
        { 
            get
            {
                return numero;
            }
        
        }

        public Cliente(int numero)
        {

        }

        public Cliente(int numero, string nombre) :this(numero)
        {
            this.numero = numero;
            this.nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool retorno = false;

            if(c1.numero == c2.numero)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}

