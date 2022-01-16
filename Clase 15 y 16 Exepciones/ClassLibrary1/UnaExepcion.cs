using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UnaExepcion : Exception
    {
        public UnaExepcion (string mensaje, Exception e) :base(mensaje,e)
        {           

            
        }
    }
}
