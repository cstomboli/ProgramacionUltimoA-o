using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private const int capacidad = 5;
        static Estacionamiento estacionamiento_singleton;
        private string nombre;
        private int precioAuto;
        private int precioMoto;
        private List<Vehiculo> vehiculos;

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        private Estacionamiento(string nombre, int precioMoto, int precioAuto) :this()
        {
            this.nombre = nombre;
            this.precioMoto = precioMoto;
            this.precioAuto = precioAuto;
        }

        public static explicit operator int(Estacionamiento e)
        {
            return e.vehiculos.Count;
        }

        public static  Estacionamiento InstanciarEstacionamiento(string nombre, int precioMoto, int precioAuto)
        {
            if (estacionamiento_singleton == null)
            {
                return Estacionamiento.estacionamiento_singleton = new Estacionamiento(nombre, precioMoto ,precioAuto);
            }
            else
            {
                return Estacionamiento.estacionamiento_singleton;

            }            
        }

        public static bool operator +(Estacionamiento e, Vehiculo v)
        {
            bool retorno = false;
            if(capacidad > (int)e)
            {
                e.vehiculos.Add(v);
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\n", this.nombre);
            sb.AppendFormat("Precio Auto: {0}\n", this.precioAuto);            
            sb.AppendFormat("Precio Moto: {0}\n", this.precioMoto);
            foreach (Vehiculo nuevo in vehiculos)
            {
                sb.AppendFormat("Vehiculo: {0}\n", nuevo);               
            }            
            return sb.ToString();
        }

    }
}
