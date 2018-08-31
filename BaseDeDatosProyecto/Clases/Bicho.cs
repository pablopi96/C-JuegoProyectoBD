using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class Bicho
    {
        string codigo;
        TipoDeBicho tipo;
        string tipoS;
        Mundo mundo;
        string mundoNombre;
        int coordX;
        int coordY;

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        internal TipoDeBicho Tipo
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

        internal Mundo Mundo
        {
            get
            {
                return mundo;
            }

            set
            {
                mundo = value;
            }
        }

        public int CoordX
        {
            get
            {
                return coordX;
            }

            set
            {
                coordX = value;
            }
        }

        public int CoordY
        {
            get
            {
                return coordY;
            }

            set
            {
                coordY = value;
            }
        }

        public string TipoS
        {
            get
            {
                return tipoS;
            }

            set
            {
                tipoS = value;
            }
        }

        public string MundoNombre
        {
            get
            {
                return mundoNombre;
            }

            set
            {
                mundoNombre = value;
            }
        }

        public Bicho() { }

        public Bicho(string codigo, TipoDeBicho tipo, Mundo mundo, int coordX, int coordY)
        {
            this.Codigo = codigo;
            this.Tipo = tipo;
            this.Mundo = mundo;
            this.CoordX = coordX;
            this.CoordY = coordY;
        }

        public Bicho(string codigo, string tipoS, string mundo, int coordX, int coordY)
        {
            this.Codigo = codigo;
            this.TipoS = tipoS;
            this.mundoNombre = mundo;
            this.CoordX = coordX;
            this.CoordY = coordY;
        }
        public override string ToString()
        {
            return this.TipoS + " (" + this.CoordX + ", " + this.CoordY + ")";
        }
    }
}
