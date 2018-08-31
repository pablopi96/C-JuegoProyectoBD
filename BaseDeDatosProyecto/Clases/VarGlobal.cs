using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class VarGlobal
    {
        public static string usuLog = "";
        public static Usuario usLogged = null;
        public static string percodigo = null;
        public static ArrayList nomPersonajes = new ArrayList();
        public static ArrayList ataPersonajes = new ArrayList();
        public static ArrayList defPersonajes = new ArrayList();
        public static ArrayList vidPersonajes = new ArrayList();
        public static ArrayList manPersonajes = new ArrayList();
        public static Bicho bicho = null;
        public static TipoDeBicho tBicho = null;

        public string get(){
            return usuLog;
        }  

        public void set(string xusuLog)
        {
            usuLog = xusuLog;

        }



    }
}
