using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {

        private List<Llamada> listaDeLlamadas; //Declaro la lista
        protected string razonSocial;

        private float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLLamada.LlamadaLocal);
            }
        }
        private float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLLamada.LlamadaProvincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLLamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas; 
            }
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>(); // aca la instancio, en el constructor.
        }

        public Centralita (string nombreEmpresa) :this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia (Llamada.TipoLLamada tipo) 
        {
            
            float acumulador = 0;                       

            foreach (Llamada llamada in listaDeLlamadas)
            {   /*                
                //StringBuilder ab = new StringBuilder();
               // ab.AppendFormat("Esta llamada es {0}", ReferenceEquals(tipo.GetType(),llamada.GetType()));
                Console.WriteLine("Esta llamada es True or false {0}", ReferenceEquals(tipo.GetType(), typeof(CentralitaHerencia.Local)));
                Console.WriteLine("Esta llamada esTipo de typeof  {0}", typeof(CentralitaHerencia.Local));
                Console.WriteLine("Esta llamada esTipo de gettype  {0}", tipo.GetType());
                Console.WriteLine("Esta llamada llamada {0}",  llamada.GetType());
                Console.WriteLine("tipo {0}", tipo);
                Console.WriteLine("tipo {0}", llamada);
                */
                switch(tipo)
                {
                    case Llamada.TipoLLamada.LlamadaLocal:
                        if (llamada is Local)  //(llamada.GetType() == typeof(CentralitaHerencia.Local))  // modifique el que diga solo Local por CentralitaHerencia.Local      
                        {
                            acumulador = acumulador + ((Local)llamada).CostoLlamada;                                                           // porque cuando entra GetType lee eso CentralitaHerencia.Local
                        }
                        break;

                    case Llamada.TipoLLamada.LlamadaProvincial:
                        if (llamada is Provincial)
                        {
                            acumulador = acumulador + ((Provincial)llamada).CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLLamada.Todas :
                        if (llamada is Local)
                        {
                            acumulador = acumulador + ((Local) llamada).CostoLlamada;
                        }
                        else
                        {
                            acumulador = acumulador + ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                }         
            }

            return acumulador;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Razon Social: {0}\n", razonSocial);
            sb.AppendFormat("Ganancia Total: {0}\n", GananciasPorTotal);
            sb.AppendLine(String.Format("Ganancia por Local: {0}", GananciasPorLocal));
            sb.AppendLine(String.Format("Ganancia por Provincial:{0}", GananciasPorProvincial));
            sb.AppendLine("LLAMADAS:");
            
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                sb.AppendLine(llamada.Mostrar());
            }

            return sb.ToString(); 
        }

        public void OrdenarLlamadas ()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion); 
        }
    }
}
