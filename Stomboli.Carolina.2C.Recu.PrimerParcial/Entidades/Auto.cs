using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        private string transmision;

        public Auto(string patente, string dueño, int dniDueño, string transmision, string color) : base(patente, dueño, dniDueño, color)
        {
            this.transmision = transmision;
        }

        /// <summary>
        /// El metodo sobrecarga al metodo Seguridad, para 
        /// mostrar el texto solicitado.
        /// </summary>
        /// <returns>Una cadena del texto solicitado.</returns>
        public override string Seguridad()
        {
            StringBuilder sb = new StringBuilder();           
            sb.AppendLine("Estimado cliente: Recuerde utilizar el cinturon de seguridad, encender las luces bajas al entrar y salir del garage");
            if(transmision == "Manual")
            {
                sb.AppendLine("Dentro del garage, solo puede circular en primera marcha");
            }
            return sb.ToString();
        }

        /// <summary>
        /// El metodo sobrecarga al metodo ToString, para mostrar toda la informacion
        /// del auto, reutilizando codigo llamando al ToString de la base.       
        /// </summary>
        /// <returns>Una cadena con toda la informacion.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("Transmision: {0}\n", this.transmision);
            sb.AppendLine(Seguridad());
            return sb.ToString();
        }
    }
}
