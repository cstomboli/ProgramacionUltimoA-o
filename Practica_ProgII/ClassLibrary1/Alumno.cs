using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Alumno
    {
        private int dni;

        public Alumno(string dni)
        {
            if(!int.TryParse(dni, out this.dni) || dni.Length !=8)
            {
                throw new AlumnoException("Error: DNI del alumno invalido.");
            }
        }
    }
}
