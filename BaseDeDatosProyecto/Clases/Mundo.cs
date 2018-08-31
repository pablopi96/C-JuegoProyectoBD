using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class Mundo
    {
        string nombre;
        int coordXFinMundo;
        int coordYFinMundo;
        int coordXIniCiudad;
        int coordXFinCiudad;
        int coordYIniCiudad;
        int coordYFinCiudad;
        Personaje personaje;
        ArrayList bichos;
        ArrayList npcs;
        ArrayList entradas;


        public Mundo(string xNombre, int xCoordXFinMundo, int xCoordYFinMundo, int xCoordXIniCiudad,
            int xCoordXFinCiudad, int xCoordYIniCiudad, int xCoordYFinCiudad, Personaje xPers, ArrayList xBichos,
            ArrayList xNpcs, ArrayList xEntradas)
        {
            this.nombre = xNombre;
            this.CoordXFinMundo = xCoordXFinMundo;
            this.CoordYFinMundo = xCoordYFinMundo;
            this.coordXIniCiudad = xCoordXIniCiudad;
            this.coordXFinCiudad = xCoordXFinCiudad;
            this.coordYIniCiudad = xCoordYIniCiudad;
            this.coordYFinCiudad = xCoordYFinCiudad;
            this.personaje = xPers;
            this.bichos = xBichos;
            this.npcs = xNpcs;
            this.entradas = xEntradas;
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

        public int CoordXFinMundo
        {
            get
            {
                return coordXFinMundo;
            }

            set
            {
                coordXFinMundo = value;
            }
        }

        public int CoordYFinMundo
        {
            get
            {
                return coordYFinMundo;
            }

            set
            {
                coordYFinMundo = value;
            }
        }

        public int CoordXIniCiudad
        {
            get
            {
                return coordXIniCiudad;
            }

            set
            {
                coordXIniCiudad = value;
            }
        }

        public int CoordXFinCiudad
        {
            get
            {
                return coordXFinCiudad;
            }

            set
            {
                coordXFinCiudad = value;
            }
        }

        public int CoordYIniCiudad
        {
            get
            {
                return coordYIniCiudad;
            }

            set
            {
                coordYIniCiudad = value;
            }
        }

        public int CoordYFinCiudad
        {
            get
            {
                return coordYFinCiudad;
            }

            set
            {
                coordYFinCiudad = value;
            }
        }

        internal Personaje Personaje
        {
            get
            {
                return personaje;
            }

            set
            {
                personaje = value;
            }
        }

        internal ArrayList Bichos
        {
            get
            {
                return bichos;
            }

            set
            {
                bichos = value;
            }
        }

        internal ArrayList Npcs
        {
            get
            {
                return npcs;
            }

            set
            {
                npcs = value;
            }
        }

        internal ArrayList Entradas
        {
            get
            {
                return entradas;
            }

            set
            {
                entradas = value;
            }
        }
    }
}
