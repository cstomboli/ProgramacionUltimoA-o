using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public int Antiguedad 
        { 
            get 
            {
                DateTime newDate = DateTime.Now;

                // Difference in days, hours, and minutes.
                TimeSpan ts = fechaIngreso - newDate;
                // Difference in days.
                int differenceInDays = ts.Days;
                return differenceInDays;
            }         
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendFormat("Fecha Ingreso: {0}\n", this.fechaIngreso.ToString());
            return sb.ToString();
        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : base(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        public Profesor(string nombre, string apellido, string documento) :this(nombre, apellido, documento, DateTime.Now)
        {
            
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;
            if(doc.Length == 8)
            {
                retorno = true;
            }
            return retorno;
           
        }
    } 
}
