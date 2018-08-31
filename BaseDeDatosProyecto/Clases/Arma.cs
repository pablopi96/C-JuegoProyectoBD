using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class Arma
    {
        string armCodigo;
        string nombre;
        int ataque;
        int precio;
        bool esDosManos;
        bool esEscudo;
        int armDefensa;

        public Arma(string armCodigo, string nombre, int precio, int ataque, bool esDosManos, bool esEscudo, int armDefensa)
        {
            this.armDefensa = armDefensa;
            this.armCodigo = armCodigo;
            this.nombre = nombre;
            this.ataque = ataque;
            this.precio = precio;
            this.esDosManos = esDosManos;
            this.esEscudo = esEscudo;
        }

        public string ArmCodigo
        {
            get
            {
                return armCodigo;
            }

            set
            {
                armCodigo = value;
            }
        }

        public int ArmDefensa
        {
            get
            {
                return armDefensa;
            }

            set
            {
                armDefensa = value;
            }
        }
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

        public int Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public bool EsDosManos
        {
            get
            {
                return esDosManos;
            }

            set
            {
                esDosManos = value;
            }
        }

        public bool EsEscudo
        {
            get
            {
                return esEscudo;
            }

            set
            {
                esEscudo = value;
            }
        }
    }
}
