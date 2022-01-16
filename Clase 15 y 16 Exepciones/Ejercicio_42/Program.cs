using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ejercicio_42
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Division operadores = new Division(10, 0);
            try
            {
                //UnaExepcion una = new UnaExepcion("Mi excepcion",e);            
                Division operadores = new Division(10, 0);
            }
            catch (UnaExepcion e)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(e.Message);
                Exception excepcionInterna = e.InnerException; 

                while (!(excepcionInterna is null))
                {
                    sb.AppendLine(excepcionInterna.Message);
                    excepcionInterna = excepcionInterna.InnerException;
                }
                Console.WriteLine(sb);
            }
                Console.ReadKey();            

        }
    }
}
