using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class InvGuardaCascos
    {
        private string invgcscCodigoPersonaje;
        private string invgcscCodigoCasco;
        private int invgcscCantidad;

        public InvGuardaCascos(string invgcscCodigoPersonaje, string invgcscCodigoCasco, int invgcscCantidad)
        {
            this.InvgcscCodigoPersonaje = invgcscCodigoPersonaje;
            this.InvgcscCodigoCasco = invgcscCodigoCasco;
            this.InvgcscCantidad = invgcscCantidad;
        }


        public string InvgcscCodigoPersonaje
        {
            get
            {
                return invgcscCodigoPersonaje;
            }

            set
            {
                invgcscCodigoPersonaje = value;
            }
        }

        public string InvgcscCodigoCasco
        {
            get
            {
                return invgcscCodigoCasco;
            }

            set
            {
                invgcscCodigoCasco = value;
            }
        }

        public int InvgcscCantidad
        {
            get
            {
                return invgcscCantidad;
            }

            set
            {
                invgcscCantidad = value;
            }
        }
    }
}
