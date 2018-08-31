using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class NPC
    {
        string codigo;
        string nombre;
        string tipo;
        Mundo mundo;
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

        public string Tipo
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

        public NPC(string xCod, string xNombre, string xTipo, Mundo xMundo, int xCoordX, int xCoordY)
        {
            this.Codigo = xCod;
            this.Nombre = xNombre;
            this.Tipo = xTipo;
            this.Mundo = xMundo;
            this.CoordX = xCoordX;
            this.CoordY = xCoordY;
        }
    }
}
