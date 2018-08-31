using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class TipoDeBicho
    {
        string nombre;
        int ataque;
        int defensa;
        int vida;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Ataque
        {
            get
            {
                return ataque;
            }

            set
            {
                ataque = value;
            }
        }

        public int Defensa
        {
            get
            {
                return defensa;
            }

            set
            {
                defensa = value;
            }
        }

        public int Vida
        {
            get
            {
                return vida;
            }

            set
            {
                vida = value;
            }
        }

        public TipoDeBicho(string nombre, int ataque, int defensa, int vida)
        {
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Defensa = defensa;
            this.Vida = vida;
        }
    }
}
