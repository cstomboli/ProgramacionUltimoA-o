using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA=330;
        private Tipo tipo;

        public Cerveza (int capacidadML, int contenidoML, string marca) : this(capacidadML, contenidoML, marca, Tipo.Vidrio)
                                                                      //:this(capacidadML, contenidoML, marca, Tipo.Vidrio)
        {
           
        }

        public Cerveza(int capacidadML, int contenidoML, string marca, Tipo tipo) : base (capacidadML, contenidoML, marca)
                                                                                //: base (capacidadML, contenidoML, marca)
        {
           this.tipo = tipo;
        }

        protected override string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder();
            //cadena.AppendLine(base.Mostrar());
            cadena.AppendLine("Cerveza:");
            cadena.AppendFormat("Medida: {0} ml\r\n", MEDIDA);
            cadena.AppendFormat("Capacidad en Litros: {0} l\r\n", this.CapacidadLitros);
            cadena.AppendFormat("Contenido: {0} ml\r\n ", this.ContenidoML);
            cadena.AppendFormat("Porcentaje Contenido: {0} %\r\n", this.PorcentajeContenido);
            return cadena.ToString();
        }

        public static implicit operator  Botella.Tipo (Cerveza cerveza)
        {
            return cerveza.tipo;
        }

        public override int ServirMedida()
        {
            int retorno;
            if (MEDIDA <= contenidoML)
            {
                 this.contenidoML = Convert.ToInt32(contenidoML - (MEDIDA*0.8));
                retorno = contenidoML;
            }
            else 
            {
                 this.contenidoML = 0;
                retorno = 0;
            }            
            return retorno;
        }

    }
}
