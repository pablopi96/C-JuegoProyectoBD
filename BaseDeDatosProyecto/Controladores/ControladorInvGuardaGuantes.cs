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
    class ControladorInvGuardaGuantes
    {
        public static int guardarGuantes(string invgguaCodigoPersonaje, string invgguaCodigoGuante, int invgguaCantidad, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("INSERT INTO invGuardaGuantes (invgguaCodigoPersonaje,invgguaCodigoGuante,invgguaCantidad) VALUES ('{0}','{1}','{2}')",
                                invgguaCodigoPersonaje, invgguaCodigoGuante, invgguaCantidad, con));
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puedes insertar el Guantes.\n" + e);
            }

            return res;
        }

        public static int modificarCantGuantes(string invgguaCodigoPersonaje, string invgguaCodigoGuante, int invgguaCantidad, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE invGuardaGuantes SET invgguaCantidad = '{2}' WHERE invgguaCodigoPersonaje= '{0}' AND invgguaCodigoGuante = '{1}'", invgguaCodigoPersonaje, invgguaCodigoGuante, invgguaCantidad), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes cambiar la cantidad de Guantes.\n" + e);
            }

            return res;
        }

        public static int eliminarGua(string invgguaCodigoPersonaje, string invgguaCodigoGuante, NpgsqlConnection con)
        {
            int res = 0;
            if (invgguaCodigoPersonaje != null)
            {
                if (invgguaCodigoGuante != null)
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaGuantes WHERE invgguaCodigoPersonaje= '{0}' AND invgguaCodigoGuante= '{1}'", invgguaCodigoPersonaje, invgguaCodigoGuante), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar el Guantes.\n" + e);
                    }
                }
                else
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaGuantes WHERE invgguaCodigoPersonaje= '{0}'", invgguaCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar el Guantes.\n" + e);
                    }
                }
            }

            return res;
        }

        public static ArrayList retGuantes(string invgguaCodigoPersonaje, string invgguaCodigoGuante, NpgsqlConnection con)
        {
            NpgsqlCommand comando;
            NpgsqlDataReader res = null;
            InvGuardaGuantes invGuaGua;
            ArrayList invGuantes = new ArrayList();
            if (invgguaCodigoPersonaje != null)
            {
                if (invgguaCodigoGuante == null)
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaGuantes WHERE invgguaCodigoPersonaje = '{0}'",
                    invgguaCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se encontró Guantes.\n" + e);
                    }
                }
                else
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaGuantes WHERE invgguaCodigoPersonaje = '{0}' AND invgguaCodigoGuante= '{1}'",
                    invgguaCodigoPersonaje, invgguaCodigoGuante), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se encontró Guantes.\n" + e);
                    }
                }
            }
            else if (invgguaCodigoGuante != null)
            {
                comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaGuantes WHERE invgguaCodigoGuante = '{1}'",
                invgguaCodigoPersonaje, invgguaCodigoGuante), con);
                try
                {
                    res = comando.ExecuteReader();
                }
                catch (NpgsqlException e)
                {
                    MessageBox.Show("No se encontró Guantes.\n" + e);
                }
            }

            if (res.HasRows)
            {
                while (res.Read())
                {
                    //Console.WriteLine("{0}\t{1}", res.GetInt32(0),
                    //    res.GetString(1));
                    //Devuelvo Guantes, TODO:
                    invGuaGua = new InvGuardaGuantes(res.GetString(0), res.GetString(1), res.GetInt16(2));
                    invGuantes.Add(invGuaGua);
                }
            }
            else
            {
                MessageBox.Show("No se encontró Guantes.\n");
                res.Close();
                return null;
            }
            res.Close();
            return invGuantes;
        }

    }
}
