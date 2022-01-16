using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string documento;
        private string nombre;

        public string Apellido { get { return apellido;  }  }
        public string Documento 
        { 
            get 
            { return documento; } 
            set 
            {
                if (ValidarDocumentacion(value))
                {
                    documento = value;
                }
            } 
        }
        public string Nombre { get { return nombre;  } }

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Appelido: {0}\n", this.Apellido);
            sb.AppendFormat("Documento: {0}\n", this.Documento);
            sb.AppendFormat("Nombre: {0}\n", this.Nombre);
            return sb.ToString();
        }

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }

        protected abstract bool ValidarDocumentacion(string doc);

    }

    public enum Divisiones
    {
        A, B, C, D, E
    }
}
