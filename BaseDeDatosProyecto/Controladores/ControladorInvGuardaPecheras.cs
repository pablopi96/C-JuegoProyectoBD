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
    class ControladorInvGuardaPecheras
    {
        public static int guardarPechera(string invgpchCodigoPersonaje, string invgpchCodigoPechera, int invgpchCantidad, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("INSERT INTO invGuardaPecheras (invgpchCodigoPersonaje,invgpchCodigoPechera,invgpchCantidad) VALUES ('{0}','{1}','{2}')",
                                invgpchCodigoPersonaje, invgpchCodigoPechera, invgpchCantidad, con));
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puedes insertar la Pechera.\n" + e);
            }

            return res;
        }

        public static int modificarCantPechera(string invgpchCodigoPersonaje, string invgpchCodigoPechera, int invgpchCantidad, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE invGuardaPecheras SET invgpchCantidad = '{2}' WHERE invgpchCodigoPersonaje= '{0}' AND invgpchCodigoPechera = '{1}'", invgpchCodigoPersonaje, invgpchCodigoPechera, invgpchCantidad), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes cambiar la cantidad de Pechera.\n" + e);
            }

            return res;
        }

        public static int eliminarPec(string invgpchCodigoPersonaje, string invgpchCodigoPechera, NpgsqlConnection con)
        {
            int res = 0;
            if (invgpchCodigoPersonaje != null)
            {
                if (invgpchCodigoPechera != null)
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaPecheras WHERE invgpchCodigoPersonaje= '{0}' AND invgpchCodigoPechera= '{1}'", invgpchCodigoPersonaje, invgpchCodigoPechera), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar la Pechera.\n" + e);
                    }
                }
                else
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaPecheras WHERE invgpchCodigoPersonaje= '{0}'",invgpchCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar la Pechera.\n" + e);
                    }
                }
            }

            return res;
        }

        public static ArrayList retPechera(string invgpchCodigoPersonaje, string invgpchCodigoPechera, NpgsqlConnection con)
        {
            NpgsqlCommand comando;
            NpgsqlDataReader res = null;
            ArrayList invPecheras = new ArrayList();
            InvGuardaPecheras invGuaPec;
            if (invgpchCodigoPersonaje != null)
            {
                if (invgpchCodigoPechera == null)
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaPecheras WHERE invgpchCodigoPersonaje = '{0}'",
                    invgpchCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se encontró Pechera.\n" + e);
                    }
                }
                else
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaPecheras WHERE invgpchCodigoPersonaje = '{0}' AND invgpchCodigoPechera= '{1}'",
                    invgpchCodigoPersonaje, invgpchCodigoPechera), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se encontró Pechera.\n" + e);
                    }
                }
            }
            else if (invgpchCodigoPechera != null)
            {
                comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaPecheras WHERE invgpchCodigoPechera = '{1}'",
                invgpchCodigoPersonaje, invgpchCodigoPechera), con);
                try
                {
                    res = comando.ExecuteReader();
                }
                catch (NpgsqlException e)
                {
                    MessageBox.Show("No se encontró Pechera.\n" + e);
                }
            }

            if (res.HasRows)
            {
                while (res.Read())
                {
                    //Console.WriteLine("{0}\t{1}", res.GetInt32(0),
                    //    res.GetString(1));
                    //Devuelvo InvPechera, TODO:
                    invGuaPec = new InvGuardaPecheras(res.GetString(0), res.GetString(1), res.GetInt16(2));
                    invPecheras.Add(invGuaPec);
                }
            }
            else
            {
                MessageBox.Show("No se encontró Pechera.\n");
                res.Close();
                return null;
            }
            res.Close();
            return invPecheras;
        }
    }
}
