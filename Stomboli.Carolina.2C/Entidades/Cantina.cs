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
        private static Cantina Singleton;

        public List<Botella> Botellas
        {
            get
            {
                return this.botella;
            }            
        }
        private Cantina (int espacios)
        {
            this.botella = new List<Botella>();
            this.espaciosTotales = espacios;
        }
        public static Cantina GetCantina (int espacios)             //mdi, :this()
        {
            if(Singleton == null)
            {
               //return Cantina.Singleton = new Cantina(espacios);
               Singleton = new Cantina(espacios);
            }
            else
            {
                Singleton.espaciosTotales = espacios;
               //return Cantina.Singleton;
                
            }
            return Singleton;
            
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
    }
}
