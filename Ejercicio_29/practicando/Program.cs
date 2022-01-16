using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace practicando
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador(34998577, "Carolina", 3, 3);
            Jugador j2 = new Jugador(34990577, "Rocio", 3, 3);

            Equipo eq = new Equipo(2, "Tito");

            if(eq + j1)
            {
                Console.WriteLine(j1.MostrarDatos());
                if (eq + j2)
                {
                    
                    Console.WriteLine(j2.MostrarDatos());
                }
            }

            Console.ReadKey();
        }
    }
}
