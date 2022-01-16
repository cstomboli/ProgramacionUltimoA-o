using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        public enum Tipo
        {
            Plastico,
            Vidrio
        }

        /// <summary>
        /// Devuelve la capacidad en Litros.
        /// </summary>
        public int CapacidadLitros
        {
            get
            {
                return (capacidadML / 1000);
            }             
        }
        public int ContenidoML
        {
            get
            {
                return contenidoML;
                               
            }
            set
           {
                contenidoML = value;
           }
        }

        public abstract float PorcentajeContenido();      

        protected Botella(int capacidadML, int contenidoML, string marca)
        {
            this.capacidadML = capacidadML;
            this.contenidoML = contenidoML;
            this.marca = marca;

            if(capacidadML<contenidoML)
            {
                this.contenidoML = capacidadML;
            }
        }
        protected virtual string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Capacidad en Litros: {0} l\n", this.CapacidadLitros );
            cadena.AppendFormat("Contenido: {0} ml\n", this.ContenidoML );            
            return cadena.ToString();
        }
        public abstract int ServirMedida(); 
        

        public new string ToString()
        {
            return   GenerarInforme();
        }

        public static bool operator ==(Botella b1, Botella b2)
        {

            bool retorno = false;

            if(b1.marca == b2.marca)            
            {
                retorno = true;                  
            }
            return retorno;

            //return (c.listaDeLlamadas.Contains(llamada));
        }

        public static bool operator !=(Botella b1, Botella b2)
        {
            return !(b1 == b2);
        }







    }
}
