using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Division
    {
        private int numero;
        private int numero2;
        
        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }

        public int Numero2
        {
            get
            {
                return numero2;
            }
            set
            {
                numero2 = value;
            }
        }

        /*
        public static int Operacion (int a, int b)
        {            
            int retorno;
            if (b == 0)
            {
                try
                {
                    retorno = a / b;
                }
                catch (DivideByZeroException e)
                {
                    //Console.WriteLine(e.Message);
                    throw new DivideByZeroException("Intento divir por cero", e);              
                }         
            }
            else { retorno = 0; }
            return retorno;
        }*/
        /*
        public int Operacion (int numero, int numero2)
        {
            return 
        }
        */

        public static int Operacion (int numero, int numero2)
        {            
            if (numero2 == 0)
            {               
                throw new DivideByZeroException("Intento divir por cero");    
            }
            else
            {
                return numero / numero2;
            }
        }

        public Division ()
        {
            try
            {
                Operacion(numero,numero2);
            }
            catch (DivideByZeroException e)     //Este aparada a la del metodo Static
            {                
                throw new UnaExepcion("Error en ",e); 
            }
            /*
            catch (UnaExepcion e) //Este no se va a Ejecutar, porque ya entro al catch anterior.
            {
                Console.WriteLine(e.Message);
                throw new InnerExepcion("Error en ", e);
            }*/
        }

        public Division (int numero, int numero2) : this()
        {
            this.numero = numero;
            this.numero2 = numero2;            
        }   
        
        public string Mostras()
        {
            int resultado = Operacion(numero, numero2);
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("El resultado es: {0}", resultado);

            return sb.ToString();
        }

    }
}
