using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        double cantidad;
        static double cotizRepectoDolar;

        static Pesos()
        {
            cotizRepectoDolar = 38.33;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRepectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.GetCantidad() / Pesos.GetCotizacion());
        }

        /*
        public static explicit operator Euro(Pesos p)
        {
            return new Euro(((Dolar)p).GetCantidad() / Pesos.GetCotizacion());
        }*/

        
        public static explicit operator Euro(Pesos p)
        {
            return new Euro((p.GetCantidad() / (Pesos.GetCotizacion()))/ (Euro.GetCotizacion()));
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRepectoDolar;
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad() - ((Pesos)d).GetCantidad());
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.GetCantidad() - ((Pesos)e).GetCantidad());
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad() + ((Pesos)d).GetCantidad());
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.GetCantidad() + ((Pesos)e).GetCantidad());
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            bool retorno = false;

            if (p == d) retorno = true;
            return retorno;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            bool retorno = false;

            if (p == e) retorno = true;
            return retorno;
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool retorno = false;

            if (p1 == p2) retorno = true;
            return retorno;

        }
    }
}
