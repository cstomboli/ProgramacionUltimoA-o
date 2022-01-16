using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia        //Enumerado: Conjuntos de variables numericas con nombres.
{
    public class Llamada
    {
        public enum TipoLLamada
        {
            LlamadaLocal, LlamadaProvincial, Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Duracion: {0}\nNumero de Destino: {1}\nNumero de Origen: {2}\n", duracion, nroDestino, nroOrigen);

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;

            if (llamada1.duracion > llamada2.duracion) retorno = -1;
            else if (llamada1.duracion < llamada2.duracion) retorno = 1;

            return retorno;
        }
    }
}
