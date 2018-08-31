using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class InvGuardaObjEsp
    {
        private string invgobjeCodigoPersonaje;
        private string invgobjeCodigoObjEsp;
        private int invgobjeCantidad;

        public InvGuardaObjEsp(string invgobjeCodigoPersonaje, string invgobjeCodigoObjEsp, int invgobjeCantidad)
        {
            this.invgobjeCodigoPersonaje = invgobjeCodigoPersonaje;
            this.invgobjeCodigoObjEsp = invgobjeCodigoObjEsp;
            this.invgobjeCantidad = invgobjeCantidad;
        }

        public string InvgobjeCodigoPersonaje
        {
            get
            {
                return invgobjeCodigoPersonaje;
            }

            set
            {
                invgobjeCodigoPersonaje = value;
            }
        }

        public string InvgobjeCodigoObjEsp
        {
            get
            {
                return invgobjeCodigoObjEsp;
            }

            set
            {
                invgobjeCodigoObjEsp = value;
            }
        }

        public int InvgobjeCantidad
        {
            get
            {
                return invgobjeCantidad;
            }

            set
            {
                invgobjeCantidad = value;
            }
        }
    }
}
