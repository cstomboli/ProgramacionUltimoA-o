using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> palabras = new List<string>();
            Queue cola = new Queue();
            Stack pila = new Stack();
           
            

            for (int i =1 ; i <= 20; i++)
            {
                //palabras.Add(i.ToString());
                cola.Enqueue(i.ToString());
                pila.Push(i.ToString());               
                
            }
            

            foreach (string pones in cola) //palabras, cola o pila.
            {
                Console.WriteLine("Numero:{0}", pones);
            }

            Console.ReadKey();
        }
    }
}
