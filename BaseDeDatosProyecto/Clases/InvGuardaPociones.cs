using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class InvGuardaPociones
    {
        private string invgpocCodigoPersonaje;
        private string invgpocCodigoPocion;
        private int invgpocCantidad;

        public InvGuardaPociones(string invgpocCodigoPersonaje, string invgpocCodigoPocion, int invgpocCantidad)
        {
            this.InvgpocCodigoPersonaje = invgpocCodigoPersonaje;
            this.InvgpocCodigoPocion = invgpocCodigoPocion;
            this.InvgpocCantidad = invgpocCantidad;
        }

        public string InvgpocCodigoPersonaje
        {
            get
            {
                return invgpocCodigoPersonaje;
            }

            set
            {
                invgpocCodigoPersonaje = value;
            }
        }

        public string InvgpocCodigoPocion
        {
            get
            {
                return invgpocCodigoPocion;
            }

            set
            {
                invgpocCodigoPocion = value;
            }
        }

        public int InvgpocCantidad
        {
            get
            {
                return invgpocCantidad;
            }

            set
            {
                invgpocCantidad = value;
            }
        }
    }
}
