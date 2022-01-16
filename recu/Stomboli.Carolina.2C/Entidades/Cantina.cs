using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botella;
        private int espaciosTotales;        

        public List<Botella> Botellas
        {
            get
            {
                return this.botella;
            }            
        }

        public Cantina (int espacios)
        {
            this.botella = new List<Botella>();
            this.espaciosTotales = espacios;
        }

        
        public static bool operator +(Cantina c, Botella b)
        {
            bool retorno = false; 

            if(c.espaciosTotales>c.botella.Count)//(c.espaciosTotales >=0)
            {
                c.botella.Add(b);                    //AGREGA LA BOTELLA   
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Cantina c, Botella b)
        {

            bool retorno = false;
            foreach (Botella cantina in c.botella)
            {
                if (cantina == b)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;            
        }

        public static bool operator !=(Cantina c, Botella b)
        {
            return !(c == b);         
        }



    }
}
