using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        public float GetPromedioGoles()
        {
            return this.totalGoles / this.partidosJugados; 
        }

        private Jugador()
        {
            this.promedioGoles = 0;
            this.totalGoles = 0;

        }

        public Jugador(int dni, string nombre) :this()
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) :this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}", this.nombre);
            sb.AppendFormat("DNI: {0}", this.dni);
            sb.AppendFormat("Partidos Jugados: {0}", this.partidosJugados);
            sb.AppendFormat("Total Goles: {0}", this.totalGoles);
            sb.AppendFormat("Promedio de Goles: {0}", GetPromedioGoles().ToString());

            return sb.ToString();
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if(j1.dni == j2.dni)
            {
                retorno = true;
            }
            return retorno;
        }


    }
}
