using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : VehiculoTerrestre
    {
        private int pesoCarga;

        Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int peso) :base(cantidadRuedas,cantidadPuertas, color, cantidadMarchas)
        {
            this.pesoCarga = peso;
        }
    }

}
