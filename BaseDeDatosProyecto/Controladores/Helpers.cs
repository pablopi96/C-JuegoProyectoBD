using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace BaseDeDatosProyecto.Controladores
{
    public class Helpers
    {
        public static int codigo(int xCodAnterior)
        {
            return xCodAnterior + 1;
        }
        public static bool validarMismaPass(String xPass1, String xPass2)
        {
            if (xPass1.CompareTo(xPass2) == 0)
                return true;
            else
                return false;
        }

        public static bool validarMail(String mail, out string errorMessage)
        {
            // Confirm that the e-mail address string is not empty.
            if (mail.Length == 0)
            {
                errorMessage = "El mail es requerido.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
            if (mail.IndexOf("@") > -1)
            {
                if (mail.IndexOf(".", mail.IndexOf("@")) > mail.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "El mail debe tener un formato válido.\n" +
               "Por ejemplo 'nombre@ejemplo.com' ";
            return false;
        }

        public static bool validarPass(String pass)
        {
            if (pass != String.Empty)
            {
                bool contNum = false;
                bool contString = false;
                foreach (char item in pass)
                {
                    if (Char.IsNumber(item))
                    {
                        contNum = true;
                    }
                    else if (Char.IsLetter(item))
                    {
                        contString = true;
                    }
                    else if(contNum.CompareTo(true) == 0 && contString.CompareTo(true) == 0)
                    {
                        break;
                    }
                }

                if (contString && contNum)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        public static bool validarNombre(String xNombre)
        {
            bool res = false;
            if (xNombre != String.Empty)
            {
                foreach(Char i in xNombre)
                {
                    if (Char.IsLetter(i))
                        res = true;
                    else
                        res = false;
                }
            }
            return res;
        }

        /// <summary>
        /// Verifica si hay un personaje con determinado nombre para ese usuario. Si hay devuelve 1. De lo contrario devuelve 0.
        /// </summary>
        /// <param name="xNombre"></param>
        /// <param name="xUsuario"></param>
        /// <param name="con"></param>
        /// <returns></returns>
        public static int validarInsPersonaje(string xNombre, string xUsuario, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("SELECT * FROM personajes WHERE pernombre = {0} AND perusuario = {1}", xUsuario, xUsuario), con);
            try
            {
                NpgsqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    res = 1;
                }

            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("" + e);
            }

            return res;
        }

        public static void actualizarEtiquetasCoord(Label l1, Label l2, int x, int y)
        {
            l1.Text = x.ToString();
            l2.Text = y.ToString();
        }

        public static void actualizarEtiquetasAtt(Label lus, Label lper, Label lnivel, Label lexp, Label lata, Label ldef, Label len, Label lvit, 
            string us, string per, int nivel, int exp, int ata, int def, int en, int vit)
        {
            lus.Text = us;
            lper.Text = per;
            lnivel.Text = nivel.ToString();
            lexp.Text = exp.ToString();
            lata.Text = ata.ToString();
            ldef.Text = def.ToString();
            len.Text = en.ToString();
            lvit.Text = vit.ToString();
        }
    }
}
