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
    class ControladorInvGuardaPociones
    {
        public static int guardarPocion(string invgpocCodigoPersonaje, string invgpocCodigoPocion, int invgpocCantidad, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("INSERT INTO invGuardaPociones (invgpocCodigoPersonaje,invgpocCodigoPocion,invgpocCantidad) VALUES ('{0}','{1}','{2}')",
                invgpocCodigoPersonaje, invgpocCodigoPocion, invgpocCantidad, con));
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puedes insertar la poción.\n" + e);
            }

            return res;
        }

        public static int modificarCantPoc(string invgpocCodigoPersonaje, string invgpocCodigoPocion, int invgpocCantidad, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE invGuardaPociones SET invgpocCantidad = '{2}' WHERE invgpocCodigoPersonaje= '{0}' AND invgpocCodigoPocion = '{1}'", invgpocCodigoPersonaje, invgpocCodigoPocion, invgpocCantidad), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes cambiar la cantidad de pociones.\n" + e);
            }

            return res;
        }

        public static int eliminarPoc(string invgpocCodigoPersonaje, string invgpocCodigoPocion,  NpgsqlConnection con)
        {
            int res = 0;
            if (invgpocCodigoPersonaje != null)
            {
                if (invgpocCodigoPocion != null)
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaPociones WHERE invgpocCodigoPersonaje= '{0}' AND invgpocCodigoPocion = '{1}'", invgpocCodigoPersonaje, invgpocCodigoPocion), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar la poción.\n" + e);
                    }
                }
                else
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaPociones WHERE invgpocCodigoPersonaje= '{0}'", invgpocCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar la poción.\n" + e);
                    }
                }
            }

            return res;
        }

        public static ArrayList retPocion(string invgpocCodigoPersonaje,string invgpocCodigoPocion, NpgsqlConnection con)
        {
            NpgsqlCommand comando;
            NpgsqlDataReader res = null;
            ArrayList invPociones = new ArrayList();
            InvGuardaPociones invGuaPoc;
            if (invgpocCodigoPersonaje != null){
                if (invgpocCodigoPocion == null)
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaPociones WHERE invgpocCodigoPersonaje = '{0}'",
                    invgpocCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se puedes insertar la poción.\n" + e);
                    }
                }else
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaPociones WHERE invgpocCodigoPersonaje = '{0}' AND invgpocCodigoPocion = '{1}'",
                    invgpocCodigoPersonaje, invgpocCodigoPocion), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se puedes insertar la poción.\n" + e);
                    }
                }
            }else if (invgpocCodigoPocion != null)
            {
                comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaPociones WHERE invgpocCodigoPocion = '{1}'",
                invgpocCodigoPersonaje,invgpocCodigoPocion), con);
                try
                {
                    res = comando.ExecuteReader();
                }
                catch (NpgsqlException e)
                {
                    MessageBox.Show("No se puedes insertar la poción.\n" + e);
                }
            }

            if (res.HasRows)
            {
                while (res.Read())
                {
                    invGuaPoc = new InvGuardaPociones(res.GetString(0), res.GetString(1), res.GetInt16(2));
                    invPociones.Add(invGuaPoc);
                }
            }
            else
            {
                MessageBox.Show("No se encontró Pechera.\n");
                res.Close();
                return null;
            }
            return invPociones;
        }
    }
}
