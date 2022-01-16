using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        public float InteresesEnDolares { get { return CalcularInteresesGanado(TipoDePrestamo.Dolares); } }
        public float InteresesEnPersos { get { return CalcularInteresesGanado(TipoDePrestamo.Pesos); } }
        public float Interesestotales { get { return CalcularInteresesGanado(TipoDePrestamo.Todos); }  }
        public List<Prestamo> ListaDePrestamos { get { return listaDePrestamos;  } }
        public string RazonSocial { get { return razonSocial; }  }

        private float CalcularInteresesGanado(TipoDePrestamo tipoPrestamo)
        {
            float retorno = 0;
           
            foreach(Prestamo prestamo in listaDePrestamos)
            {
                if (tipoPrestamo == TipoDePrestamo.Dolares && prestamo is PrestamoDolar)
                {
                    retorno += ((PrestamoDolar)prestamo).Intereses;                  
                }
                else if (tipoPrestamo == TipoDePrestamo.Pesos && prestamo is PrestamoPesos)
                {
                    retorno += ((PrestamoPesos)prestamo).Interes;
                }
                else if(tipoPrestamo == TipoDePrestamo.Todos)
                {
                    if(prestamo is PrestamoDolar)
                    {
                        retorno += ((PrestamoDolar)prestamo).Intereses;
                    }
                    if(prestamo is PrestamoPesos)
                    {
                        retorno += ((PrestamoPesos)prestamo).Interes;
                    }                        
                }
            }
            return retorno;
        }

        public static explicit operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Razon Social: {0}\n", financiera.RazonSocial );
            sb.AppendFormat("Intereses en Dolares: {0}\n", financiera.InteresesEnDolares);
            sb.AppendFormat("Intereses en Pesos: {0}\n", financiera.InteresesEnPersos);
            foreach(Prestamo nuevo in financiera.ListaDePrestamos)
            {
                sb.AppendFormat("Intereses en Pesos: {0}\n", nuevo);
            }            
            return sb.ToString();
            
        }

        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial) :this()
        {
            this.razonSocial = razonSocial;
        }

        public string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {            
            if(financiera!= prestamoNuevo)
            {
                financiera.listaDePrestamos.Add(prestamoNuevo);
                
            }
            return financiera;
        }

        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            bool retorno = false;
            if( !(financiera is null) && !(prestamo is null))
            {
                foreach (Prestamo nuevo in financiera.listaDePrestamos)
                {
                    if (nuevo == prestamo)
                    {
                        retorno = true;
                    }
                }
            }           
            return retorno;
        }

        public void OrdenarPrestamos()
        {
            listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }


    }
}
