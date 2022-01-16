using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil :VehiculoTerrestre
    {
        private int cantidadPasajeros;

        Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pasajeros):base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.cantidadPasajeros = pasajeros;
        }
    }
}
