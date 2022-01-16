using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador :Persona
    {        
        private int partidosJugados;
        //private float promedioGoles;
        private int totalGoles;

        public int PartidosJugados
        {
            get
            {
                return partidosJugados;
            }
            set
            {
                partidosJugados = value;
            }

        }
       
        public int TotalGoles
        {
            get
            {
                return totalGoles;
            }
            set
            {
                totalGoles = value;
            }
        }
        public float PromedioGoles
        {
            get
            {
                return this.totalGoles / this.partidosJugados;
            }

        }

        public Jugador(int dni, string nombre) : base(dni, nombre)
        {
            
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}", this.Nombre);
            sb.AppendFormat("DNI: {0}", this.Dni);
            sb.AppendFormat("Partidos Jugados: {0}", this.PartidosJugados);
            sb.AppendFormat("Total Goles: {0}", this.TotalGoles);
            sb.AppendFormat("Promedio de Goles: {0}", this.PromedioGoles);

            return sb.ToString();
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if (j1.Dni == j2.Dni)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
