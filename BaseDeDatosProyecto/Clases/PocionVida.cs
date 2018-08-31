using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class PocionVida : Pocion
    {
        public enum TipoPocion { Maná, Vida };

        TipoPocion tipo;

        internal TipoPocion Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public PocionVida(string xNombre, int xTamaño, int xPrecio, int xEfectividad)
            :base(xNombre, xTamaño, xPrecio, xEfectividad)
        {
            this.Tipo = TipoPocion.Vida;
        }
    }
}
