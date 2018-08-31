using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    abstract class Pocion
    {
        string nombre;
        int tamaño;
        int precio;
        int efectividad;

        public Pocion(string nombre, int tamaño, int precio, int efectividad)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.precio = precio;
            this.efectividad = efectividad;
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

        public int Tamaño
        {
            get
            {
                return tamaño;
            }

            set
            {
                tamaño = value;
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

        public int Efectividad
        {
            get
            {
                return efectividad;
            }

            set
            {
                efectividad = value;
            }
        }
    }
}
