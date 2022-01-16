using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public float Monto { get; }
        public DateTime Vencimiento 
        { 
            get
            {
                return vencimiento;
            }            
            set
            {
                if(value > DateTime.Now)
                {
                    vencimiento = value;
                }
                else
                {
                    vencimiento = DateTime.Now;
                }
            }    
        
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Vencimiento: {0}", this.Vencimiento);
            sb.AppendFormat("Monto: {0}", this.Monto);
            return sb.ToString();
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            int retorno = 0;

            if(p1.vencimiento>p2.vencimiento)
            {
                retorno = -1;
            }
            else if(p1.vencimiento < p2.vencimiento)
            {
                retorno = 1;
            }

            return retorno;
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.vencimiento = vencimiento;
            this.monto = monto;
        }


    }

    public enum PeriodicidadDePagos
    {
        Mensual, Bimestral, Trimestral
    }

    public enum TipoDePrestamo
    {
        Pesos, Dolares, Todos
    }
}
