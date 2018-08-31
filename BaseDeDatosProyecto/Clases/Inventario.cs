using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class Inventario
    {
        ArrayList objEspeciales;
        ArrayList pociones;
        ArrayList armas;
        ArrayList cascos;
        ArrayList pecheras;
        ArrayList pantalones;
        ArrayList guantes;
        ArrayList botas;
        int ctdLibreInv;

        public ArrayList ObjEspeciales
        {
            get
            {
                return objEspeciales;
            }

            set
            {
                objEspeciales = value;
            }
        }

        public ArrayList Pociones
        {
            get
            {
                return pociones;
            }

            set
            {
                pociones = value;
            }
        }

        public ArrayList Armas
        {
            get
            {
                return armas;
            }

            set
            {
                armas = value;
            }
        }

        public ArrayList Cascos
        {
            get
            {
                return cascos;
            }

            set
            {
                cascos = value;
            }
        }

        public ArrayList Pecheras
        {
            get
            {
                return pecheras;
            }

            set
            {
                pecheras = value;
            }
        }

        public ArrayList Pantalones
        {
            get
            {
                return pantalones;
            }

            set
            {
                pantalones = value;
            }
        }

        public ArrayList Guantes
        {
            get
            {
                return guantes;
            }

            set
            {
                guantes = value;
            }
        }

        public ArrayList Botas
        {
            get
            {
                return botas;
            }

            set
            {
                botas = value;
            }
        }

        public int CtdLibreInv
        {
            get
            {
                return ctdLibreInv;
            }

            set
            {
                ctdLibreInv = value;
            }
        }

        public Inventario()
        {
            this.ObjEspeciales = new ArrayList();
            this.Pociones = new ArrayList();
            this.Armas = new ArrayList();
            this.Cascos = new ArrayList();
            this.Pecheras = new ArrayList();
            this.Pantalones = new ArrayList();
            this.Guantes = new ArrayList();
            this.Botas = new ArrayList();
            this.CtdLibreInv = 0;
        }

        public Inventario(ArrayList objEspeciales, ArrayList pociones, ArrayList armas, ArrayList cascos, ArrayList pecheras, ArrayList pantalones, ArrayList guantes, ArrayList botas, int ctdLibreInv)
        {
            this.ObjEspeciales = objEspeciales;
            this.Pociones = pociones;
            this.Armas = armas;
            this.Cascos = cascos;
            this.Pecheras = pecheras;
            this.Pantalones = pantalones;
            this.Guantes = guantes;
            this.Botas = botas;
            this.CtdLibreInv = ctdLibreInv;
        }
    }
}
