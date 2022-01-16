using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float retorno = 0;

            if (franjaHoraria == Franja.Franja_1)
            {
                retorno = 0.99f * this.duracion;    //0.99f = (float) 0.99
            }
            else if (franjaHoraria == Franja.Franja_2)
            {
                retorno = 1.25f * this.duracion; // 1.25f = (float) 1.25
            }
            else if (franjaHoraria == Franja.Franja_3)
            {
                retorno = 0.66f * this.duracion;  // 0.66f = (float) 1.25
            }
            return retorno;
        }

        public Provincial(Franja miFranja, Llamada llamada) : this(miFranja, llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {

        }
        public Provincial(Franja miFranja, float duracion, string destino, string origen) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}", franjaHoraria, CostoLlamada);
            sb.AppendLine(base.Mostrar()); ///Llama al Mostrar de quien? 

            return sb.ToString();
        }
    }
}
