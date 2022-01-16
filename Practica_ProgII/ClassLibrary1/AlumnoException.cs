using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AlumnoException : Exception
    {
        public AlumnoException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public AlumnoException(string message) :base(message, null) //esto puede ser : this (message, null)
        {

        }
    }
}
