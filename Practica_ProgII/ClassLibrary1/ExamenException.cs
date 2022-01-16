using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ExamenException :Exception
    {
        public ExamenException(string message, Exception innerException) :base(message, innerException)
        {

        }
    }
}
