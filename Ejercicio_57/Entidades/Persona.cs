using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public string file_name = AppDomain.CurrentDomain.BaseDirectory + "TestFile1.txt";

        public Persona (string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        
            static Persona Guardar (Persona p)
            {
                try
                {
                    StreamWriter ser = new StreamWriter(file_name);
                }
                catch
                {

                }
            }

            static Persona Leer (Persona p)
            {
            
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Persona {0}", nombre);
                return sb.ToString();
            }
        
    }
}
