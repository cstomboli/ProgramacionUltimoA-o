using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadCombustible { get; set; }
        public bool EnCompetencia { get; set; }
        public int VueltasRestantes { get; set; }

        public AutoF1(short numero, string escuderia)
        {
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
            this.enCompetencia = false;
            this.escuderia = escuderia;
            this.numero = numero;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Cantidad de combustible: {0}", this.CantidadCombustible);
            sb.AppendFormat("En competencia: {0}", this.EnCompetencia);
            sb.AppendFormat("Escuderia: {0}", this.escuderia);
            sb.AppendFormat("Numero: {0}", this.numero);
            sb.AppendFormat("Vueltas restantes: {0}", this.VueltasRestantes);

            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if(a1.numero == a2.numero && a1.escuderia ==a2.escuderia)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return (a1 == a2);
        }

    }
}
