using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{

    public class Dolar
    {
        private double cantidad;
        private static double cotizRepectoDolar;

        static Dolar()
        {
            cotizRepectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRepectoDolar = cotizacion;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad / Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRepectoDolar;
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(e == d);
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            bool retorno = false;

            if (d == e) retorno = true;

            return retorno;
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            bool retorno = false;

            if (d == p) retorno = true;

            return retorno;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool retorno = false;

            if (d1 == d2) retorno = true;

            return retorno;
        }
    }
}
