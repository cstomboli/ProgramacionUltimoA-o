using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    public class Libro
    {
        private List<string> paginas;

        public string this [int indice] //indexador
        {
            get
            {
                string retorno;
                if(paginas.Count < indice && indice >= 0)
                {
                    retorno = "";
                }
                else
                {
                    retorno= paginas[indice];
                }
                return retorno;
            }
            set
            {
                if(indice>=0)
                {
                    if (indice < paginas.Count)
                    {
                        this.paginas[indice] = value;
                    }
                    else
                    {
                        this.paginas.Add(value);
                    }
                }
                
            }
        }

        public Libro ()
        {
            this.paginas = new List<string>();
            
        }
    }
}
