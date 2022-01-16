using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    sealed class Edificio
    {
        private Cantina[] cantinas;
        private const short limiteCantinas = 2;
        private static Edificio Singleton;


        static  Edificio ()
        {
            if (Singleton == null)
            {
                //return Cantina.Singleton = new Cantina(espacios);
                Singleton = new Edificio();
            }
            /*
            else
            {
                Singleton.cantinas = Edificio.cantinas[limiteCantinas];
                //return Cantina.Singleton;                
            }*/
            
        }

        private  Edificio ()
        {
            this.cantinas[limiteCantinas] = cantinas[limiteCantinas];
        }

        public Edificio GetBar ()
        {
            return Singleton;            
        }

        
        public static bool operator +(Edificio e, Cantina c)
        {
            bool retorno = false;
            short i;

            for (i=0; i>= e.cantinas.Length; i++)
            {
                //e.cantinas[i].Add(c);
                retorno = true;                 
            }        
            return retorno;
        }

        

    }
}
