using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class InvGuardaBotas
    {
        private string invgbotCodigoPersonaje;
        private string invgbotCodigoBota;
        private int invgbotCantidad;

        public InvGuardaBotas(string invgbotCodigoPersonaje, string invgbotCodigoBota, int invgbotCantidad)
        {
            this.invgbotCodigoPersonaje = invgbotCodigoPersonaje;
            this.invgbotCodigoBota = invgbotCodigoBota;
            this.invgbotCantidad = invgbotCantidad;
        }

        public string InvgbotCodigoPersonaje
        {
            get
            {
                return invgbotCodigoPersonaje;
            }

            set
            {
                invgbotCodigoPersonaje = value;
            }
        }

        public string InvgbotCodigoBota
        {
            get
            {
                return invgbotCodigoBota;
            }

            set
            {
                invgbotCodigoBota = value;
            }
        }

        public int InvgbotCantidad
        {
            get
            {
                return invgbotCantidad;
            }

            set
            {
                invgbotCantidad = value;
            }
        }
    }
}
