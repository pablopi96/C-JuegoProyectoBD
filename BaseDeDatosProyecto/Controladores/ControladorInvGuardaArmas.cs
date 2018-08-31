using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using BaseDeDatosProyecto.Clases;
using System.Windows.Forms;
using System.Collections;

namespace BaseDeDatosProyecto.Controladores
{
    class ControladorInvGuardaArmas
    {
        public static int guardarArmas(string invgarmCodigoPersonaje, string invgarmCodigoArma, int invgarmCantidad, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("INSERT INTO invGuardaArmas (invgarmCodigoPersonaje,invgarmCodigoArma,invgarmCantidad) VALUES ('{0}','{1}','{2}')",
                                invgarmCodigoPersonaje, invgarmCodigoArma, invgarmCantidad, con));
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puedes insertar el Armas.\n" + e);
            }

            return res;
        }

        public static int modificarCantArmas(string invgarmCodigoPersonaje, string invgarmCodigoArma, int invgarmCantidad, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE invGuardaArmas SET invgarmCantidad = '{2}' WHERE invgarmCodigoPersonaje= '{0}' AND invgarmCodigoArma = '{1}'", invgarmCodigoPersonaje, invgarmCodigoArma, invgarmCantidad), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes cambiar la cantidad de Armas.\n" + e);
            }

            return res;
        }

        public static int eliminarArmas(string invgarmCodigoPersonaje, string invgarmCodigoArma, NpgsqlConnection con)
        {
            int res = 0;
            if (invgarmCodigoPersonaje != null)
            {
                if (invgarmCodigoArma != null)
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaArmas WHERE invgarmCodigoPersonaje= '{0}' AND invgarmCodigoArma= '{1}'", invgarmCodigoPersonaje, invgarmCodigoArma), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar el Armas.\n" + e);
                    }
                }
                else
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaArmas WHERE invgarmCodigoPersonaje= '{0}' ", invgarmCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar el Armas.\n" + e);
                    }
                }
            }
            return res;
        }

        public static ArrayList retArmas(string invgarmCodigoPersonaje, string invgarmCodigoArma, NpgsqlConnection con)
        {
            NpgsqlCommand comando;
            NpgsqlDataReader res = null;
            InvGuardaArmas invGuaArmas;
            ArrayList invArmas = new ArrayList();
            if (invgarmCodigoPersonaje != null)
            {
                if (invgarmCodigoArma == null)
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaArmas WHERE invgarmCodigoPersonaje = '{0}'",
                    invgarmCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se encontró Armas.\n" + e);
                    }
                }
                else
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaArmas WHERE invgarmCodigoPersonaje = '{0}' AND invgarmCodigoArma= '{1}'",
                    invgarmCodigoPersonaje, invgarmCodigoArma), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se encontró Armas.\n" + e);
                    }
                }
            }
            else if (invgarmCodigoArma != null)
            {
                comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaArmas WHERE invgarmCodigoArma = '{1}'",
                invgarmCodigoPersonaje, invgarmCodigoArma), con);
                try
                {
                    res = comando.ExecuteReader();
                }
                catch (NpgsqlException e)
                {
                    MessageBox.Show("No se encontró Armas.\n" + e);
                }
            }

            if (res.HasRows)
            {
                while (res.Read())
                {
                    invGuaArmas = new InvGuardaArmas(res.GetString(0), res.GetString(1), res.GetInt16(2));
                    invArmas.Add(invGuaArmas);
                }
            }
            else
            {
                MessageBox.Show("No se encontró Armas.\n");
                res.Close();
                return null;
            }
            res.Close();
            return invArmas;
        }
    }
}
