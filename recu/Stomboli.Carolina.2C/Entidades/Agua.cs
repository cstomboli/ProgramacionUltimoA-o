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
            cadena.AppendLine("Agua:");
            cadena.AppendFormat("Medida: {0}\n", MEDIDA);
            cadena.AppendLine(base.GenerarInforme());
            cadena.AppendFormat("Porcentaje Contenido: {0} %", this.PorcentajeContenido());
            return cadena.ToString();
        }


        /// <summary>
        /// El metodo Sobrecarga Porcentaje Contenido.
        /// </summary>
        /// <returns>Devuelve en float el Porcentaje Contenido.</returns>
        public override float PorcentajeContenido ()
        {
            return (this.contenidoML * 100) / this.capacidadML;
        }

        /// <summary>
        /// El metodo es una Sobre carga de ServirMedida().   
        /// </summary>
        /// <returns>La meddida servida en entero.</returns>
        public override int ServirMedida ()
        {
            return ServirMedida(MEDIDA);
        }

        /// <summary>
        /// El metodo Calcula la medida Servida, restando
        /// al contenido la constante Medida.
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
