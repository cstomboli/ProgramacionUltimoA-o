using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeIntereses; 

        public float Interes
        {
            get
            {
               return CalcularIntereses();
            }

        }
        

        private float CalcularIntereses()
        {
            return this.monto + ((this.monto * this.porcentajeIntereses) /100);

        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            //DateTime oldDate = new DateTime(2002, 7, 15);
            DateTime newDate = DateTime.Now;
            // Difference in days, hours, and minutes.
            TimeSpan ts = nuevoVencimiento - newDate;
            // Difference in days.
            int differenceInDays = ts.Days;

            float interesActual = (float)Convert.ToDouble(differenceInDays+(differenceInDays * 0.25));
            this.porcentajeIntereses += interesActual;
            this.vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("Vencimiento: {0}", this.porcentajeIntereses);
            return sb.ToString();
        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes) :base(monto, vencimiento)
        {

        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres) :this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
        {
            this.porcentajeIntereses = porcentajeInteres;
        }
    }
}
