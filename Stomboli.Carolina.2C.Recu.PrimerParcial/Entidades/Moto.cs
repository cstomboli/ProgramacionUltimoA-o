using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;

        /// <summary>
        /// Constructor de la Clase
        /// </summary>
        /// <param name="patente">Que se lo pasa a la base.</param>
        /// <param name="dueño">Que se lo pasa a la base.</param>
        /// <param name="dni">Que se lo pasa a la base.</param>
        /// <param name="cilindrada">Setea el atributo.</param>
        /// <param name="color">Que se lo pasa a la base.</param>
        public Moto(string patente, string dueño, int dni, int cilindrada, string color) :base(patente, dueño, dni, color)
        {
            this.cilindrada = cilindrada;
        }

        /// <summary>
        /// El metodo sobrecarga al metodo Seguridad, para 
        /// mostrar el texto solicitado.
        /// </summary>
        /// <returns>Una cadena del texto solicitado.</returns>
        public override string Seguridad()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Estimado cliente: Recuerde utilizar casco y mantener las luces encendidas al circular por el garage");            
            return sb.ToString();
        }

        /// <summary>
        /// El metodo sobrecarga al metodo ToString, para mostrar toda la informacion
        /// de la moto, reutilizando codigo llamando al ToString de la base.       
        /// </summary>
        /// <returns>Una cadena con toda la informacion.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("Cilindrada: {0}\n", this.cilindrada);
            sb.AppendLine(Seguridad());
            return sb.ToString();
        }
    }
}
