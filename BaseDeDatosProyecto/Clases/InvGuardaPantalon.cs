using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class InvGuardaPantalon
    {
        private string invgpantCodigoPersonaje;
        private string invgpantCodigoPantalon;
        private int invgpantCantidad;

        public InvGuardaPantalon(string invgpantCodigoPersonaje, string invgpantCodigoPantalon, int invgpantCantidad)
        {
            this.invgpantCodigoPersonaje = invgpantCodigoPersonaje;
            this.invgpantCodigoPantalon = invgpantCodigoPantalon;
            this.invgpantCantidad = invgpantCantidad;
        }

        public string InvgpantCodigoPersonaje
        {
            get
            {
                return invgpantCodigoPersonaje;
            }

            set
            {
                invgpantCodigoPersonaje = value;
            }
        }

        public string InvgpantCodigoPantalon
        {
            get
            {
                return invgpantCodigoPantalon;
            }

            set
            {
                invgpantCodigoPantalon = value;
            }
        }

        public int InvgpantCantidad
        {
            get
            {
                return invgpantCantidad;
            }

            set
            {
                invgpantCantidad = value;
            }
        }
    }
}
