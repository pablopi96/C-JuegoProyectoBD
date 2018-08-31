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
    class ControladorInvGuardaBotas
    {
        public static int guardarBotas(string invgbotCodigoPersonaje, string invgbotCodigoBota, int invgbotCantidad, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("INSERT INTO invGuardaBotas (invgbotCodigoPersonaje,invgbotCodigoBota,invgbotCantidad) VALUES ('{0}','{1}','{2}')",
                                invgbotCodigoPersonaje, invgbotCodigoBota, invgbotCantidad, con));
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puedes insertar el Botas.\n" + e);
            }

            return res;
        }

        public static int modificarCantBotas(string invgbotCodigoPersonaje, string invgbotCodigoBota, int invgbotCantidad, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE invGuardaBotas SET invgbotCantidad = '{2}' WHERE invgbotCodigoPersonaje= '{0}' AND invgbotCodigoBota = '{1}'", invgbotCodigoPersonaje, invgbotCodigoBota, invgbotCantidad), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes cambiar la cantidad de Botas.\n" + e);
            }

            return res;
        }

        public static int eliminarBot(string invgbotCodigoPersonaje, string invgbotCodigoBota, NpgsqlConnection con)
        {
            int res = 0;
            if(invgbotCodigoPersonaje != null)
            {
                if(invgbotCodigoBota != null)
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaBotas WHERE invgbotCodigoPersonaje= '{0}' AND invgbotCodigoBota= '{1}'", invgbotCodigoPersonaje, invgbotCodigoBota), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar el Botas.\n" + e);
                    }
                }else
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaBotas WHERE invgbotCodigoPersonaje= '{0}'", invgbotCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar el Botas.\n" + e);
                    }
                }
            }

            return res;
        }

        public static ArrayList retBotas(string invgbotCodigoPersonaje, string invgbotCodigoBota, NpgsqlConnection con)
        {
            NpgsqlCommand comando;
            NpgsqlDataReader res = null;
            InvGuardaBotas invGuaBot;
            ArrayList invBotas = new ArrayList();
            if (invgbotCodigoPersonaje != null)
            {
                if (invgbotCodigoBota == null)
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaBotas WHERE invgbotCodigoPersonaje = '{0}'",
                    invgbotCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se encontró Botas.\n" + e);
                    }
                }
                else
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaBotas WHERE invgbotCodigoPersonaje = '{0}' AND invgbotCodigoBota= '{1}'",
                    invgbotCodigoPersonaje, invgbotCodigoBota), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se encontró Botas.\n" + e);
                    }
                }
            }
            else if (invgbotCodigoBota != null)
            {
                comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaBotas WHERE invgbotCodigoBota = '{1}'",
                invgbotCodigoPersonaje, invgbotCodigoBota), con);
                try
                {
                    res = comando.ExecuteReader();
                }
                catch (NpgsqlException e)
                {
                    MessageBox.Show("No se encontró Botas.\n" + e);
                }
            }

            if (res.HasRows)
            {
                while (res.Read())
                {
                    invGuaBot = new InvGuardaBotas(res.GetString(0), res.GetString(1), res.GetInt16(2));
                    invBotas.Add(invGuaBot);
                }
            }
            else
            {
                MessageBox.Show("No se encontró Botas.\n");
                res.Close();
                return null;
            }
            res.Close();
            return invBotas;
        }
    }
}
