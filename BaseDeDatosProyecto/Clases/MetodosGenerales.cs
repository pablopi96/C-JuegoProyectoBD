using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using BaseDeDatosProyecto.Controladores;
using System.Windows.Forms;
using System.Collections;

namespace BaseDeDatosProyecto.Clases
{
    class MetodosGenerales
    {
        public static Array retInventario(string codigoPersonaje, NpgsqlConnection con)
        {
            ArrayList[] inventario = new ArrayList[8];

            inventario[0] = ControladorInvGuardaPociones.retPocion(codigoPersonaje, null, con);
            inventario[1] = ControladorInvGuardaCasco.retCasco(codigoPersonaje, null, con);
            inventario[2] = ControladorInvGuardaPecheras.retPechera(codigoPersonaje, null, con);
            inventario[3] = ControladorInvGuardaGuantes.retGuantes(codigoPersonaje, null, con);
            inventario[4] = ControladorInvGuardaArmas.retArmas(codigoPersonaje, null, con);
            inventario[5] = ControladorInvGuardaPantalones.retPantalon(codigoPersonaje, null, con);
            inventario[6] = ControladorInvGuardaBotas.retBotas(codigoPersonaje, null, con);
            inventario[7] = ControladorInvGuardaObjEsp.retObjEsp(codigoPersonaje, null, con);

            return inventario;
        }

        public static bool tirarPocionInv(string codigoPersonaje, string codigoPocion, NpgsqlConnection con)
        {
            ArrayList pociones = ControladorInvGuardaPociones.retPocion(codigoPersonaje, codigoPocion, con);
            if (pociones.Count == 1)
            {
                InvGuardaPociones pocion = (InvGuardaPociones)pociones[0];
                pocion.InvgpocCantidad -= 1;
                if (pocion.InvgpocCantidad == 0)
                {
                    ControladorInvGuardaPociones.modificarCantPoc(pocion.InvgpocCodigoPersonaje, pocion.InvgpocCodigoPocion, pocion.InvgpocCantidad,con);
                }
                else
                {
                    ControladorInvGuardaPociones.eliminarPoc(pocion.InvgpocCodigoPersonaje, pocion.InvgpocCodigoPocion, con);
                }
                return true;
            }
            return false;
        }

        public static bool tirarCascoInv(string codigoPersonaje, string codigoCasco, NpgsqlConnection con)
        {
            ArrayList cascos = ControladorInvGuardaCasco.retCasco(codigoPersonaje, codigoCasco, con);
            if (cascos.Count == 1)
            {
                InvGuardaCascos casco = (InvGuardaCascos)cascos[0];
                casco.InvgcscCantidad -= 1;
                if (casco.InvgcscCantidad== 0)
                {
                    ControladorInvGuardaCasco.modificarCantCasco(casco.InvgcscCodigoPersonaje, casco.InvgcscCodigoCasco, casco.InvgcscCantidad, con);
                }
                else
                {
                    ControladorInvGuardaCasco.eliminarCas(casco.InvgcscCodigoPersonaje, casco.InvgcscCodigoCasco, con);
                }
                return true;
            }
            return false;
        }

        public static bool tirarPecheraInv(string codigoPersonaje, string codigoPechera, NpgsqlConnection con)
        {
            ArrayList pecheras = ControladorInvGuardaPecheras.retPechera(codigoPersonaje, codigoPechera, con);
            if (pecheras.Count == 1)
            {
                InvGuardaPecheras pechera = (InvGuardaPecheras)pecheras[0];
                pechera.InvgpchCantidad -= 1;
                if (pechera.InvgpchCantidad == 0)
                {
                    ControladorInvGuardaPecheras.modificarCantPechera(pechera.InvgpchCodigoPersonaje, pechera.InvgpchCodigoPechera, pechera.InvgpchCantidad, con);
                }
                else
                {
                    ControladorInvGuardaPecheras.eliminarPec(pechera.InvgpchCodigoPersonaje, pechera.InvgpchCodigoPechera, con);
                }
                return true;
            }
            return false;
        }

        public static bool tirarGuantesInv(string codigoPersonaje, string codigoGuantes, NpgsqlConnection con)
        {
            ArrayList guantes = ControladorInvGuardaGuantes.retGuantes(codigoPersonaje, codigoGuantes, con);
            if (guantes.Count == 1)
            {
                InvGuardaGuantes guante = (InvGuardaGuantes)guantes[0];
                guante.InvgguaCantidad-= 1;
                if (guante.InvgguaCantidad == 0)
                {
                    ControladorInvGuardaGuantes.modificarCantGuantes(guante.InvgguaCodigoGuante, guante.InvgguaCodigoGuante, guante.InvgguaCantidad, con);
                }
                else
                {
                    ControladorInvGuardaGuantes.eliminarGua(guante.InvgguaCodigoPersonaje, guante.InvgguaCodigoGuante, con);
                }
                return true;
            }
            return false;
        }

        public static bool tirarPantalonInv(string codigoPersonaje, string codigoPantalon, NpgsqlConnection con)
        {
            ArrayList pantalones = ControladorInvGuardaPantalones.retPantalon(codigoPersonaje, codigoPantalon, con);
            if (pantalones.Count == 1)
            {
                InvGuardaPantalon pantalon = (InvGuardaPantalon)pantalones[0];
                pantalon.InvgpantCantidad -= 1;
                if (pantalon.InvgpantCantidad == 0)
                {
                    ControladorInvGuardaPantalones.modificarCantPantalon(pantalon.InvgpantCodigoPersonaje, pantalon.InvgpantCodigoPantalon, pantalon.InvgpantCantidad, con);
                }
                else
                {
                    ControladorInvGuardaPantalones.eliminarPan(pantalon.InvgpantCodigoPersonaje, pantalon.InvgpantCodigoPantalon, con);
                }
                return true;
            }
            return false;
        }

        public static bool tirarBotasInv(string codigoPersonaje, string codigoBota, NpgsqlConnection con)
        {
            ArrayList botas = ControladorInvGuardaBotas.retBotas(codigoPersonaje, codigoBota, con);
            if (botas.Count == 1)
            {
                InvGuardaBotas bota = (InvGuardaBotas)botas[0];
                bota.InvgbotCantidad -= 1;
                if (bota.InvgbotCantidad == 0)
                {
                    ControladorInvGuardaBotas.modificarCantBotas(bota.InvgbotCodigoPersonaje, bota.InvgbotCodigoBota, bota.InvgbotCantidad, con);
                }
                else
                {
                    ControladorInvGuardaBotas.eliminarBot(bota.InvgbotCodigoPersonaje, bota.InvgbotCodigoBota, con);
                }
                return true;
            }
            return false;
        }

        public static bool tirarArmaInv(string codigoPersonaje, string codigoArma, NpgsqlConnection con)
        {
            ArrayList armas = ControladorInvGuardaArmas.retArmas(codigoPersonaje, codigoArma, con);
            if (armas.Count == 1)
            {
                InvGuardaArmas arma = (InvGuardaArmas)armas[0];
                arma.InvgarmCantidad -= 1;
                if (arma.InvgarmCantidad == 0)
                {
                    ControladorInvGuardaArmas.modificarCantArmas(arma.InvgarmCodigoPersonaje, arma.InvgarmCodigoArma, arma.InvgarmCantidad, con);
                }
                else
                {
                    ControladorInvGuardaArmas.eliminarArmas(arma.InvgarmCodigoPersonaje, arma.InvgarmCodigoArma, con);
                }
                return true;
            }
            return false;
        }

        public static bool tirarObjEspInv(string codigoPersonaje, string codigoObjEsp, NpgsqlConnection con)
        {
            ArrayList objesps = ControladorInvGuardaObjEsp.retObjEsp(codigoPersonaje, codigoObjEsp, con);
            if (objesps.Count == 1)
            {
                InvGuardaObjEsp objesp = (InvGuardaObjEsp)objesps[0];
                objesp.InvgobjeCantidad -= 1;
                if (objesp.InvgobjeCantidad == 0)
                {
                    ControladorInvGuardaObjEsp.modificarCantObjEsp(objesp.InvgobjeCodigoObjEsp, objesp.InvgobjeCodigoObjEsp, objesp.InvgobjeCantidad, con);
                }
                else
                {
                    ControladorInvGuardaObjEsp.eliminarObjEsp(objesp.InvgobjeCodigoPersonaje, objesp.InvgobjeCodigoObjEsp, con);
                }
                return true;
            }
            return false;
        }

        public static int retVidaPersonaje(string codigoPersonaje, NpgsqlConnection con)
        {
            int vida = 0;
            Personaje personaje = ControladorPersonajes.retPersonaje(codigoPersonaje, con);

            if (personaje != null)
            {
                TipoPersonaje tipoPersonaje = ControladorTipoPersonajes.retTipoPersonaje(personaje.Tipo, con);
                vida = tipoPersonaje.TperVida;
                vida += personaje.PuntosVida + personaje.Nivel * 2;
            }
            return vida;
        }

        public static int ataPer(string xcodigoPer, NpgsqlConnection con)
        {
            float ata;
            int ataarm1 = 0;
            int ataarm2 = 0;
            Personaje per = Controladores.ControladorPersonajes.retPersonaje(xcodigoPer, con);
            TipoPersonaje tper = Controladores.ControladorTipoPersonajes.retTipoPersonaje(per.Tipo, con);
            ArrayList armas = Controladores.ControladorArmas.retArmas(per.ArmaDerecha, con);
            if (armas.Count == 1)
            {
                Arma arma = (Arma)armas[0];
                ataarm1 = arma.Ataque;
            }
            armas = Controladores.ControladorArmas.retArmas(per.ArmaIzquierda, con);
            if (armas.Count == 1)
            {
                Arma arma = (Arma)armas[0];
                ataarm2 = arma.Ataque;
            }


            ata = tper.TperAtaque + per.PuntosAtaque + ataarm1 + ataarm2;
            switch (per.Tipo)
            {
                case "Guerrero":
                    ata = ata * (float)0.80;
                    break;
                case "Elfa":
                    ata = ata * (float)0.60;
                    break;
                case "Gladiador magico":
                    ata = ata * (float)0.70;
                    break;
                case "Mago":
                    ata = ata * (float)0.50;
                    break;
                case "Señor oscuro":
                    ata = ata * (float)0.70;
                    break;
                default:
                    break;


            }
            return (int)Math.Round(ata);
        }

        public static int defPer(string xcodigoPer, NpgsqlConnection con)
        {
            float def;
            Personaje per = Controladores.ControladorPersonajes.retPersonaje(xcodigoPer, con);
            TipoPersonaje tper = Controladores.ControladorTipoPersonajes.retTipoPersonaje(per.Tipo, con);
            
            def = tper.TperDefensa + ControladorObjeto.retDefPec(per.Pechera, con) + ControladorObjeto.retDefPan(per.Pantalon, con) + 
                Controladores.ControladorObjeto.retDefGua(per.Guantes, con) + 
            Controladores.ControladorObjeto.retDefBot(per.Botas, con) + Controladores.ControladorObjeto.retDefCas(per.Casco, con);

            return (int)Math.Round(def);
        }

        public static bool subirExp(string codigoPersonaje, NpgsqlConnection con)
        {
            bool res = false;
            Random rnd = new Random();
            int mExp = rnd.Next(5, 13);
            Personaje personaje = ControladorPersonajes.retPersonaje(codigoPersonaje, con);

            int exp = 3 * mExp;
            exp = personaje.PuntosExp + exp;
            if (exp >= (personaje.Nivel * 50))
            {
                exp -= personaje.Nivel * 50;
                ControladorPersonajes.modificarNivel(codigoPersonaje, personaje.Nivel + 1, con);
                res = true;
            }
            ControladorPersonajes.modificarExpPersonaje(codigoPersonaje, exp, con);
            return res;
        }
    }
}
