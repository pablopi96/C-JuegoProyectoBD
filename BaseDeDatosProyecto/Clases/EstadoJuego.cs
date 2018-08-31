using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class EstadoJuego
    {

        public static bool enCombate;
        public static bool caminando;
        public static bool tomandoPoc;
        public static bool cambSkill;


        public static void aCombate()
        {
            enCombate = true;
            caminando = false;
            tomandoPoc = false;
            cambSkill = false;
        }

        public static void aCaminar()
        {
            enCombate = false;
            caminando = true;
            tomandoPoc = false;
            cambSkill = false;
        }

        public static void aTomarPocion()
        {
            enCombate = false;
            caminando = false;
            tomandoPoc = true;
            cambSkill = false;
        }
        public static void aCambSkill()
        {
            enCombate = false;
            caminando = false;
            tomandoPoc = false;
            cambSkill = true;
        }

    }
}
