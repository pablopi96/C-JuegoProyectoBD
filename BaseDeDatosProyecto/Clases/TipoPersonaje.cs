using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class TipoPersonaje
    {
        private string tperNombre;
        private int tperAtaque;
        private int tperDefensa;
        private int tperVida;
        private int tperMana;

        public TipoPersonaje(string tperNombre, int tperAtaque, int tperDefensa, int tperVida, int tperMana)
        {
            this.tperNombre = tperNombre;
            this.tperAtaque = tperAtaque;
            this.tperDefensa = tperDefensa;
            this.tperVida = tperVida;
            this.tperMana = tperMana;
        }

        public string TperNombre
        {
            get
            {
                return tperNombre;
            }

            set
            {
                tperNombre = value;
            }
        }

        public int TperAtaque
        {
            get
            {
                return tperAtaque;
            }

            set
            {
                tperAtaque = value;
            }
        }

        public int TperDefensa
        {
            get
            {
                return tperDefensa;
            }

            set
            {
                tperDefensa = value;
            }
        }

        public int TperVida
        {
            get
            {
                return tperVida;
            }

            set
            {
                tperVida = value;
            }
        }

        public int TperMana
        {
            get
            {
                return tperMana;
            }

            set
            {
                tperMana = value;
            }
        }
    }
}
