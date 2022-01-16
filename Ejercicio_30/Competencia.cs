using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) :this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Cantidad de competidores: {0}", this.cantidadCompetidores);
            sb.AppendFormat("Cantidad de vueltas: {0}", this.cantidadCompetidores);
            foreach(AutoF1 competidores in competidores)
            {
                sb.AppendFormat("Competidores: {0}",competidores);
            }

            return sb.ToString();

        }

        public static bool operator-(Competencia c, AutoF1 a)
        {
            return (c + a);
        }
        public static bool operator+(Competencia c, AutoF1 a)
        {
            bool retorno = false;

           

                if (c.cantidadCompetidores >= c.competidores.Count) //
                {
                    if (!(c == a))
                    {
                        c.competidores.Add(a);
                        a.EnCompetencia = true;
                        a.VueltasRestantes = c.cantidadVueltas;
                        Random vueltas = new Random();
                        a.CantidadCombustible = Convert.ToInt16(vueltas.Next(15, 100));
                        retorno = true;
                    }
                }
            
            return retorno;
        }
        public static bool operator==(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            
                foreach (AutoF1 competidor in c.competidores)
                {
                    if(competidor==a)
                    {                    
                        retorno = true;
                    }
                }
            
            return retorno;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return (c == a);
        }

    }
}
