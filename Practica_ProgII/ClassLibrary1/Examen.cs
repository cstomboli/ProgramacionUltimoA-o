using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Examen
    {
        private static List<Alumno> alumnos;

        public static void CargarAlumno(Alumno alumno)
        {
            try
            {
                Examen.alumnos.Add(alumno);
            }
            catch (AlumnoException ex)
            {
                throw new ExamenException("Error en la carga de alumno", ex);
            }
            catch (NullReferenceException ex)       //Ya se xq entra aca! 
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Ocurrio un error inesperado, contactar al administrador"); //lanza esta exception.
                new Exception("Mirar bien el constructor", ex);
            }
        }
    }
}
