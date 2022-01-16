using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        private PeriodicidadDePagos periodicidad;

        public float Intereses 
        { 
            get
            {
                return CalcularIntereses();
            }
        
        }
        public PeriodicidadDePagos Periodicidad { get; }

        private float CalcularIntereses()
        {
            float retorno = 40;

            if(PeriodicidadDePagos.Mensual == periodicidad)
            {
                retorno = 25; 
            }
            else if (PeriodicidadDePagos.Bimestral == periodicidad)
            {
                retorno = 35;
            }

            return retorno;

        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            //DateTime oldDate = new DateTime(2002, 7, 15);
            DateTime newDate = DateTime.Now;

            // Difference in days, hours, and minutes.
            TimeSpan ts = nuevoVencimiento- newDate;

            // Difference in days.
            int differenceInDays = ts.Days;

            float montoMasPlazo = (float)Convert.ToDouble( differenceInDays * 2.5);
            this.monto += montoMasPlazo;
            this.vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("Monto: {0}", this.periodicidad);
            return sb.ToString();
        }

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad) : base(monto, vencimiento)
        {
            this.Periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad) : this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
        {

        }
    }
}
