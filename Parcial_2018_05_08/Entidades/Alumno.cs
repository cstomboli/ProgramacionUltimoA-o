using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        protected short anio;
        protected Divisiones division;

        public string AnioDivision 
        { 
            get 
            {
                StringBuilder sb = new StringBuilder();                
                sb.AppendFormat("{0}°, {1}\n", this.anio, this.division);              
                return sb.ToString();
            }         
        }

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division):base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine(this.AnioDivision);
            //sb.AppendFormat("Anio: {0}\n", this.anio);
            //sb.AppendFormat("Division: {0}\n", this.division);
            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = true;
            for (int i = 0; doc[i] <= 9; i++)
            {
                if ((doc[i] < '0' || doc[i] > '9') && (doc[i] != '-'))
                {
                    retorno = false;
                }
            }
            return retorno;
        }
    }
}
