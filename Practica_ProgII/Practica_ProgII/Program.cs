using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Practica_ProgII
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Examen.CargarAlumno(new Alumno("12345678")); //Ves q comente este paraver el otro, si lo descomento agrega este y el otro no, o no pude verlo yo
                Examen.CargarAlumno(new Alumno("47.864.123"));
                throw new Exception("No hay Execption");
            }
            catch(AlumnoException)
            {
            }
            catch(ExamenException)
            { }
            catch(NullReferenceException)
            { }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }
}
