using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA=330;
        private Tipo tipo;

        public Cerveza (int capacidadML, int contenidoML, string marca) : this(capacidadML, contenidoML, marca, Tipo.Vidrio)
        {
           
        }

        public Cerveza(int capacidadML, int contenidoML, string marca, Tipo tipo) : base (capacidadML, contenidoML, marca)
        {
           this.tipo = tipo;
        }

        public override float PorcentajeContenido()
        {
            return (this.contenidoML * 90) / this.capacidadML;
        }

        protected override string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder();            
            cadena.AppendLine("Cerveza:");
            cadena.AppendFormat("Medida: {0} ml\n", MEDIDA);
            cadena.AppendLine(base.GenerarInforme());
            cadena.AppendFormat("Porcentaje Contenido: {0} %", this.PorcentajeContenido());
            cadena.AppendFormat("Tipo: {0} \n", this.tipo);
            return cadena.ToString();
        }

        public static implicit operator  Botella.Tipo (Cerveza cerveza)
        {
            return cerveza.tipo;
        }

        public override int ServirMedida()
        {
            int retorno;
            if (MEDIDA <= this.contenidoML)
            {
                 this.contenidoML= contenidoML-(int)(MEDIDA*0.80);
                retorno = (int)(MEDIDA * 0.80);
            }
            else 
            {
                this.contenidoML=0;
                retorno = 0;
            }            
            return retorno;
        }
    }
}
