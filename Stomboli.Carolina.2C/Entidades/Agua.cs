using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int MEDIDA = 400;
       
        /// <summary>
        /// El metodo sobreescribe al constructor de Botella, con sus 
        /// mismo parametros.
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="contenidoML"></param>
        /// <param name="marca"></param>
        public Agua(int capacidadML, int contenidoML, string marca) : base(capacidadML, contenidoML, marca)
        {

        }

        /// <summary>
        /// El metodo muestra de Agua, la medida, capacidad,
        /// contenido y porcentaje de contenido.
        /// </summary>
        /// <returns>En una cadena de String toda la informacion.</returns>
        protected new string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder();
            //cadena.AppendLine(base.Mostrar());
            cadena.AppendLine("Agua:");
            cadena.AppendFormat("Medida: {0} \r\n", MEDIDA);
            cadena.AppendFormat("Capacidad en Litros: {0} \r\n", this.CapacidadLitros);
            cadena.AppendFormat("Contenido: {0} \r\n", this.ContenidoML);
            cadena.AppendFormat("Porcentaje Contenido: {0} \r\n", this.PorcentajeContenido);
            return cadena.ToString();
        }

        /// <summary>
        /// El metodo Calcula la medida Servida, restando
        /// al contenido la constante Medida.
        /// </summary>
        /// <returns>La meddida servida en entero.</returns>
        public override int ServirMedida ()
        {
            return ServirMedida(MEDIDA);
        }

        /// <summary>
        /// El metodo es una Sobre carga de ServirMedida().
        /// </summary>
        /// <param name="medida"></param>
        /// <returns>La medida servida en entero</returns>
        public int ServirMedida (int medida) 
        {
            int retorno;
            if (MEDIDA <= contenidoML)
            {
                 this.contenidoML = contenidoML - MEDIDA;
                retorno = MEDIDA;
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
