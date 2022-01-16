using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public long Dni 
        { 
            get
            {
                return dni;
            }    
            set
            {
                dni = value;
            }
        
        }
        public string Nombre 
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string MostrarDatos()
        {

        }

        public Persona(long dni, string nombre) :this(nombre)
        {

        }

        public Persona(string nombre)
        {

        }
    }
}
