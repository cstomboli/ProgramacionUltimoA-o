using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        double cantidad;
        static double cotizRepectoDolar;

        static Euro()
        {
            cotizRepectoDolar = 1.16;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRepectoDolar = cotizacion;

        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() * Euro.GetCotizacion());

        }

        public static explicit operator Pesos(Euro e)
        {
            return new Pesos((e.GetCantidad() * Euro.GetCotizacion()) * Pesos.GetCotizacion()); /// Modifique aca tmb.
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRepectoDolar;
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static bool operator !=(Euro e, Dolar d)
        {

            return !(e == d);

        }

        public static bool operator !=(Euro e, Pesos p)
        {

            return !(e == p);

        }

        public static bool operator !=(Euro e1, Euro e2)
        {

            return !(e1 == e2);

        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.GetCantidad() + ((Euro)p).GetCantidad());
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool retorno = false;

            if (e == d) retorno = true;

            return retorno;
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            bool retorno = false;

            if (e == p) retorno = true;

            return retorno;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool retorno = false;

            if (e1 == e2) retorno = true;

            return retorno;
        }
    }
}
