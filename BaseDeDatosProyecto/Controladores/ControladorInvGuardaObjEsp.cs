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
    class ControladorInvGuardaObjEsp
    {
        public static int guardarObjEsp(string invgobjeCodigoPersonaje, string invgobjeCodigoObjEsp, int invgobjeCantidad, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("INSERT INTO invGuardaObjEsp (invgobjeCodigoPersonaje,invgobjeCodigoObjEsp,invgobjeCantidad) VALUES ('{0}','{1}','{2}')",
                                invgobjeCodigoPersonaje, invgobjeCodigoObjEsp, invgobjeCantidad, con));
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puedes insertar el ObjEsp.\n" + e);
            }

            return res;
        }

        public static int modificarCantObjEsp(string invgobjeCodigoPersonaje, string invgobjeCodigoObjEsp, int invgobjeCantidad, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE invGuardaObjEsp SET invgobjeCantidad = '{2}' WHERE invgobjeCodigoPersonaje= '{0}' AND invgobjeCodigoObjEsp = '{1}'", invgobjeCodigoPersonaje, invgobjeCodigoObjEsp, invgobjeCantidad), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes cambiar la cantidad de ObjEsp.\n" + e);
            }

            return res;
        }

        public static int eliminarObjEsp(string invgobjeCodigoPersonaje, string invgobjeCodigoObjEsp, NpgsqlConnection con)
        {
            int res = 0;
            if (invgobjeCodigoPersonaje != null)
            {
                if (invgobjeCodigoObjEsp != null)
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaObjEsp WHERE invgobjeCodigoPersonaje= '{0}' AND invgobjeCodigoObjEsp= '{1}'", invgobjeCodigoPersonaje, invgobjeCodigoObjEsp), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar el ObjEsp.\n" + e);
                    }
                }
                else
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaObjEsp WHERE invgobjeCodigoPersonaje= '{0}'", invgobjeCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar el ObjEsp.\n" + e);
                    }
                }
            }

            return res;
        }

        public static ArrayList retObjEsp(string invgobjeCodigoPersonaje, string invgobjeCodigoObjEsp, NpgsqlConnection con)
        {
            NpgsqlCommand comando;
            NpgsqlDataReader res = null;
            InvGuardaObjEsp invGuaObjEsp;
            ArrayList invObjEsp = new ArrayList();
            if (invgobjeCodigoPersonaje != null)
            {
                if (invgobjeCodigoObjEsp == null)
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaObjEsp WHERE invgobjeCodigoPersonaje = '{0}'",
                    invgobjeCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se encontró ObjEsp.\n" + e);
                    }
                }
                else
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaObjEsp WHERE invgobjeCodigoPersonaje = '{0}' AND invgobjeCodigoObjEsp= '{1}'",
                    invgobjeCodigoPersonaje, invgobjeCodigoObjEsp), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se encontró ObjEsp.\n" + e);
                    }
                }
            }
            else if (invgobjeCodigoObjEsp != null)
            {
                comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaObjEsp WHERE invgobjeCodigoObjEsp = '{1}'",
                invgobjeCodigoPersonaje, invgobjeCodigoObjEsp), con);
                try
                {
                    res = comando.ExecuteReader();
                }
                catch (NpgsqlException e)
                {
                    MessageBox.Show("No se encontró ObjEsp.\n" + e);
                }
            }

            if (res.HasRows)
            {
                while (res.Read())
                {
                    invGuaObjEsp = new InvGuardaObjEsp(res.GetString(0), res.GetString(1), res.GetInt16(2));
                    invObjEsp.Add(invGuaObjEsp);
                }
            }
            else
            {
                MessageBox.Show("No se encontró ObjEsp.\n");
                res.Close();
                return null;
            }
            res.Close();
            return invObjEsp;
        }
    }
}
