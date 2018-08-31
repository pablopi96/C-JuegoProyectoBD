using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class InvGuardaGuantes
    {
        private string invgguaCodigoPersonaje;
        private string invgguaCodigoGuante;
        private int invgguaCantidad;

        public InvGuardaGuantes(string invgguaCodigoPersonaje, string invgguaCodigoGuante, int invgguaCantidad)
        {
            this.invgguaCodigoPersonaje = invgguaCodigoPersonaje;
            this.invgguaCodigoGuante = invgguaCodigoGuante;
            this.invgguaCantidad = invgguaCantidad;
        }

        public string InvgguaCodigoPersonaje
        {
            get
            {
                return invgguaCodigoPersonaje;
            }

            set
            {
                invgguaCodigoPersonaje = value;
            }
        }

        public string InvgguaCodigoGuante
        {
            get
            {
                return invgguaCodigoGuante;
            }

            set
            {
                invgguaCodigoGuante = value;
            }
        }

        public int InvgguaCantidad
        {
            get
            {
                return invgguaCantidad;
            }

            set
            {
                invgguaCantidad = value;
            }
        }
    }
}
