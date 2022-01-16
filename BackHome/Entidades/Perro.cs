using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        private Tamaño tamaño;
        public enum Tamaño
        {
            Pequeño,
            Mediano,
            Grande
        }
    }
}
