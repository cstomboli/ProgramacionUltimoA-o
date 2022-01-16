using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        public string AnioDivision 
        { get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}°, {1}\n", this.anio, this.division);
                return sb.ToString();
            }
        }

        private Curso()
        {
            this.alumnos = new List<Alumno>();       
        }

        public Curso(short anio, Divisiones division, Profesor profesor):this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendFormat("Division: {0}\n", c.division);
            sb.AppendFormat("Anio: {0}\n", c.anio);
            sb.AppendFormat("Profesor: {0}\n", c.profesor);
            foreach (Alumno nuevo in c.alumnos)
            {
                sb.AppendFormat("Intereses en Pesos: {0}\n", nuevo);
            }
            return sb.ToString();
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            bool retorno = false;

            foreach(Alumno nuevo in c.alumnos)
            {
                if(nuevo.AnioDivision == c.AnioDivision)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            if(c==a)
            {
                c.alumnos.Add(a);
            }
            return c;
        }

    }
}
