using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class Entrada
    {
        string codigo;
        string nombre;
        Mundo mundoTel;
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

        internal Mundo MundoTel
        {
            get
            {
                return mundoTel;
            }

            set
            {
                mundoTel = value;
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

        public Entrada(string xCod, string xNombre, Mundo xMundoTel, Mundo xMundo, int xCoordX, int xCoordY)
        {
            this.Codigo = xCod;
            this.Nombre = xNombre;
            this.MundoTel = xMundoTel;
            this.Mundo = xMundo;
            this.CoordX = xCoordX;
            this.CoordY = xCoordY;
        }

        
    }
}
