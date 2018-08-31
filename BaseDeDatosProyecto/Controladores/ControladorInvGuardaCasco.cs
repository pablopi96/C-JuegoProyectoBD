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
    class ControladorInvGuardaCasco
    {
        public static int guardarCasco(string invgcscCodigoPersonaje, string invgcscCodigoCasco, int invgcscCantidad, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("INSERT INTO invGuardaCascos (invgcscCodigoPersonaje,invgcscCodigoCasco,invgcscCantidad) VALUES ('{0}','{1}','{2}')",
                                invgcscCodigoPersonaje, invgcscCodigoCasco, invgcscCantidad, con));
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puedes insertar el Casco.\n" + e);
            }

            return res;
        }

        public static int modificarCantCasco(string invgcscCodigoPersonaje, string invgcscCodigoCasco, int invgcscCantidad, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE invGuardaCascos SET invgcscCantidad = '{2}' WHERE invgcscCodigoPersonaje= '{0}' AND invgcscCodigoCasco = '{1}'", invgcscCodigoPersonaje, invgcscCodigoCasco, invgcscCantidad), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes cambiar la cantidad de casco.\n" + e);
            }

            return res;
        }

        public static int eliminarCas(string invgcscCodigoPersonaje, string invgcscCodigoCasco, NpgsqlConnection con)
        {
            int res = 0;
            if (invgcscCodigoPersonaje != null)
            {
                if (invgcscCodigoCasco != null)
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaCascos WHERE invgcscCodigoPersonaje= '{0}' AND invgcscCodigoCasco= '{1}'", invgcscCodigoPersonaje, invgcscCodigoCasco), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar el casco.\n" + e);
                    }
                }
                else
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE from invGuardaCascos WHERE invgcscCodigoPersonaje= '{0}'", invgcscCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteNonQuery();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No puedes eliminar el casco.\n" + e);
                    }
                }
            }
            return res;
        }

        public static ArrayList retCasco(string invgcscCodigoPersonaje, string invgcscCodigoCasco, NpgsqlConnection con)
        {
            NpgsqlCommand comando;
            NpgsqlDataReader res = null;
            InvGuardaCascos invGuaCas;
            ArrayList invCascos = new ArrayList();
            if (invgcscCodigoPersonaje != null)
            {
                if (invgcscCodigoCasco == null)
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaCascos WHERE invgcscCodigoPersonaje = '{0}'",
                    invgcscCodigoPersonaje), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se encontró casco.\n" + e);
                    }
                }
                else
                {
                    comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaCascos WHERE invgcscCodigoPersonaje = '{0}' AND invgcscCodigoCasco= '{1}'",
                    invgcscCodigoPersonaje, invgcscCodigoCasco), con);
                    try
                    {
                        res = comando.ExecuteReader();
                    }
                    catch (NpgsqlException e)
                    {
                        MessageBox.Show("No se encontró casco.\n" + e);
                    }
                }
            }
            else if (invgcscCodigoCasco != null)
            {
                comando = new NpgsqlCommand(string.Format("SELECT *FROM invGuardaCascos WHERE invgcscCodigoCasco = '{1}'",
                invgcscCodigoPersonaje, invgcscCodigoCasco), con);
                try
                {
                    res = comando.ExecuteReader();
                }
                catch (NpgsqlException e)
                {
                    MessageBox.Show("No se encontró casco.\n" + e);
                }
            }

            if (res.HasRows)
            {
                while (res.Read())
                {
                    //Console.WriteLine("{0}\t{1}", res.GetInt32(0),
                    //    res.GetString(1));
                    //Devuelvo Casco, TODO:
                    invGuaCas = new InvGuardaCascos(res.GetString(0), res.GetString(1), res.GetInt16(2));
                    invCascos.Add(invGuaCas);
                }
            }
            else
            {
                MessageBox.Show("No se encontró casco.\n");
                res.Close();
                return null;
            }
            res.Close();
            return invCascos;
        }
    }
}
