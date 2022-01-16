using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class DirectorTecnico : Persona
    {
        private DateTime fechaDeNacimiento; 

        public DirectorTecnico(string nombre) :base(nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento):this(nombre)
        {
            this.fechaDeNacimiento = fechaNacimiento;
        }

        public string MostrarDatos()
        {

        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            if(dt1.Nombre == dt2.Nombre && dt1.fechaDeNacimiento == dt2.fechaDeNacimiento)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }

    }
}
