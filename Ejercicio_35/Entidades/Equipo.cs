using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidad;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = true;
            if (!(e is null) && !(j is null))
            {

                if (e.cantidadDeJugadores >= e.jugadores.Count)
                {
                    foreach (Jugador jugador in e.jugadores)
                    {
                        if (jugador == j)
                        {
                            retorno = false;
                            break;

                        }
                    }
                    if (!retorno)
                    {
                        e.jugadores.Add(j);
                    }
                    return retorno;
                }
            }           
            return retorno;
        }
    }
}
