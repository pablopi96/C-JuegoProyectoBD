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
    class ControladorInvGuardaPantalones
    {
        public static int guardarPantalon(string invgpantCodigoPersonaje, string invgpantCodigoPantalon, int invgpantCantidad, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("INSERT INTO invGuardaPantalones (invgpantCodigoPersonaje,invgpantCodigoPantalon,invgpantCantidad) VALUES ('{0}','{1}','{2}')",
                                invgpantCodigoPersonaje, invgpantCodigoPantalon, invgpantCantidad, con));
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puedes insertar el Pantalon.\n" + e);
            }

            return res;
        }

        public static int modificarCantPantalon(string invgpantCodigoPersonaje, string invgpantCodigoPantalon, int invgpantCantidad, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE invGuardaPantalones SET invgpantCantidad = '{2}' WHERE invgpantCodigoPersonaje= '{0}' AND invgpantCodigoPantalon = '{1}'", invgpantCodigoPersonaje, invgpantCodigoPantalon, invgpantCantidad), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes cambiar la cantidad de Pantalon.\n" + e);
            }

            return res;
        }

        public static int eliminarPan(string invgpantCodigoPersonaje, string invgpantCodigoPantalon, NpgsqlConnection con)
        {
            int res = 0;
            if (invgpantCodigoPersonaje != null)
            {
                if (invgpantCodigoPantalon != null)
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaPantalones WHERE invgpantCodigoPersonaje= '{0}' AND invgpantCodigoPantalon= '{1}'", invgpantCodigoPersonaje, invgpantCodigoPantalon), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar el Pantalon.\n" + e);
                    }
                }
                else
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaPantalones WHERE invgpantCodigoPersonaje= '{0}'", invgpantCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar el Pantalon.\n" + e);
                    }
                }
            }

            return res;
        }

        public static ArrayList retPantalon(string invgpantCodigoPersonaje, string invgpantCodigoPantalon, NpgsqlConnection con)
        {
            NpgsqlCommand comando;
            NpgsqlDataReader res = null;
            InvGuardaPantalon invGuaPan;
            ArrayList invPantalon = new ArrayList();
            if (invgpantCodigoPersonaje != null)
            {
                if (invgpantCodigoPantalon == null)
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaPantalones WHERE invgpantCodigoPersonaje = '{0}'",
                    invgpantCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se encontró Pantalon.\n" + e);
                    }
                }
                else
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaPantalones WHERE invgpantCodigoPersonaje = '{0}' AND invgpantCodigoPantalon= '{1}'",
                    invgpantCodigoPersonaje, invgpantCodigoPantalon), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se encontró Pantalon.\n" + e);
                    }
                }
            }
            else if (invgpantCodigoPantalon != null)
            {
                comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaPantalones WHERE invgpantCodigoPantalon = '{1}'",
                invgpantCodigoPersonaje, invgpantCodigoPantalon), con);
                try
                {
                    res = comando.ExecuteReader();
                }
                catch (NpgsqlException e)
                {
                    MessageBox.Show("No se encontró Pantalon.\n" + e);
                }
            }

            if (res.HasRows)
            {
                while (res.Read())
                {
                    invGuaPan = new InvGuardaPantalon(res.GetString(0), res.GetString(1), res.GetInt16(2));
                    invPantalon.Add(invGuaPan);
                }
            }
            else
            {
                MessageBox.Show("No se encontró Pantalon.\n");
                res.Close();
                return null;
            }
            res.Close();
            return invPantalon;
        }

    }
}
