using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class InvGuardaArmas
    {
        private string invgarmCodigoPersonaje;
        private string invgarmCodigoArma;
        private int invgarmCantidad;

        public InvGuardaArmas(string invgarmCodigoPersonaje, string invgarmCodigoArma, int invgarmCantidad)
        {
            this.invgarmCodigoPersonaje = invgarmCodigoPersonaje;
            this.invgarmCodigoArma = invgarmCodigoArma;
            this.invgarmCantidad = invgarmCantidad;
        }

        public string InvgarmCodigoPersonaje
        {
            get
            {
                return invgarmCodigoPersonaje;
            }

            set
            {
                invgarmCodigoPersonaje = value;
            }
        }

        public string InvgarmCodigoArma
        {
            get
            {
                return invgarmCodigoArma;
            }

            set
            {
                invgarmCodigoArma = value;
            }
        }

        public int InvgarmCantidad
        {
            get
            {
                return invgarmCantidad;
            }

            set
            {
                invgarmCantidad = value;
            }
        }
    }
}
