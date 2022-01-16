using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo; //* significa protegido.


        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return this.costo;
        }

        public Local(Llamada llamada, float costo) : this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, costo)
        {
            //new Local(llamada, costo);
        }
        public Local(float duracion, string destino, string origen, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo * duracion;

        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());     ///Llama al Mostrar de Llamada. Que es el metodo padre!
            sb.AppendFormat("{0}", costo);

            return sb.ToString();
        }
    }
}
