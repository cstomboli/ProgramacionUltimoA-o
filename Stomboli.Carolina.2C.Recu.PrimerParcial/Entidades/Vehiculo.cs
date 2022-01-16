using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected string color;
        protected int dniDueño;
        protected string nombreDueño;
        protected string patente;

        /// <summary>
        /// Metodo a ser implentado en las clases derivadas.
        /// </summary>
        /// <returns>Una cadena de informacion.</returns>
        public abstract string Seguridad();

        /// <summary>
        /// El metodo sobrecarga al metodo ToString, para mostrar toda la informacion
        /// de un vehiculo, reutilizando codigo llamando al ToString de la base.       
        /// </summary>
        /// <returns>Una cadena con toda la informacion.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();            
            sb.AppendFormat("Nombre Dueño: {0}\n", this.nombreDueño);
            sb.AppendFormat("Dni dueño: {0}\n", this.dniDueño);            
            sb.AppendFormat("Color: {0}\n", this.color);
            sb.AppendFormat("Patente: {0}\n", this.patente);
            return sb.ToString();
        }

        /// <summary>
        /// Constructor Privado que inicializa los atributos
        /// con su valor por defecto.
        /// </summary>
        private Vehiculo()
        {
            this.color = string.Empty;
            this.dniDueño = 0;
            this.nombreDueño = string.Empty;
            this.patente = string.Empty;

        }

        /// <summary>
        /// Constructor que inicializa los atributos
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="dueño"></param>
        /// <param name="dni"></param>
        /// <param name="color"></param>
        public Vehiculo(string patente, string dueño, int dni, string color) : this()
        {
            this.color = color;
            this.dniDueño = dni;
            this.nombreDueño = dueño;
            this.patente = patente;
        }

    }

    public enum eTransmision
    {
        Seleccionar, AT, Manual
    }

    public enum eColores
    {
        Seleccionar, Azul, Rojo, Blanco, Negro
    }
}
