using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        private Edad edad;
        private Raza raza;
        private Zona zona;
        

        public enum Edad
        {
            Cachorro,
            Joven,
            Adulto
        }

        public enum Raza
        {
            BullDogFrances,
            BullDog,
            Caniche,
            Labrador
        }

        public enum Zona
        {
            ZonaSur,
            ZonaOeste,
            ZonaNorte,
            CapitalFederal
        }

        public Mascota()
        {

        }

        public Mascota(Zona zona, Raza raza, Edad edad)
        {
            this.zona = zona; 
            this.raza = raza; 
            this.edad = edad;
        }


    }
}
