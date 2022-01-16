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
            set
            { ; }
        }
        public int ContenidoML
        {
            get
            {
                return contenidoML;
                               
            }
            set { ; }
        }

        public float PorcentajeContenido
        {
            get
            {
                return ((contenidoML *100) / capacidadML);
                //return ((capacidadML - ServirMedida()) / 10); Tambien anda!
            }              
        }
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
            cadena.AppendFormat("Capacidad en Litros: {0} l\r\n", this.CapacidadLitros );
            cadena.AppendFormat("Contenido: {0} ml\r\n", this.ContenidoML );
            cadena.AppendFormat("Porcentaje Contenido: {0} %\r\n", this.PorcentajeContenido);
            return cadena.ToString();
        }
        public abstract int ServirMedida();  
        
        public new string ToString()
        {
            return GenerarInforme();
        }
     }
}
