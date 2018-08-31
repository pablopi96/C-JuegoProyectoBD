using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class InvGuardaPecheras
    {
        private string invgpchCodigoPersonaje;
        private string invgpchCodigoPechera;
        private int invgpchCantidad;

        public InvGuardaPecheras(string invgpchCodigoPersonaje, string invgpchCodigoPechera, int invgpchCantidad)
        {
            this.invgpchCodigoPersonaje = invgpchCodigoPersonaje;
            this.invgpchCodigoPechera = invgpchCodigoPechera;
            this.invgpchCantidad = invgpchCantidad;
        }

        public string InvgpchCodigoPersonaje
        {
            get
            {
                return invgpchCodigoPersonaje;
            }

            set
            {
                invgpchCodigoPersonaje = value;
            }
        }

        public string InvgpchCodigoPechera
        {
            get
            {
                return invgpchCodigoPechera;
            }

            set
            {
                invgpchCodigoPechera = value;
            }
        }

        public int InvgpchCantidad
        {
            get
            {
                return invgpchCantidad;
            }

            set
            {
                invgpchCantidad = value;
            }
        }
    }
}
