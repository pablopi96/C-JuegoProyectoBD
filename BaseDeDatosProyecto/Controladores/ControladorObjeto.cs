using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace BaseDeDatosProyecto.Controladores
{
    class ControladorObjeto
    {
        public static int retDefCas(string objCodigo, NpgsqlConnection con)
        {
            NpgsqlCommand comando;
            NpgsqlDataReader res = null;
            int defensa = 0;
            if (objCodigo != null)
            {
                comando = new NpgsqlCommand(string.Format("SELECT cscDefensa FROM cascos WHERE cscCodigo = '{0}'",
                objCodigo), con);
                try
                {
                    res = comando.ExecuteReader();
                }
                catch (NpgsqlException e)
                {
                    MessageBox.Show("No se encontró Casco.\n" + e);
                }
                if (res.HasRows)
                {
                    while (res.Read())
                    {
                        defensa = res.GetInt32(0);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró Casco.\n");
                    res.Close();
                }
                res.Close();
            }

            
            return defensa;
        }

        public static int retDefGua(string objCodigo, NpgsqlConnection con)
        {
            NpgsqlCommand comando;
            NpgsqlDataReader res = null;
            int defensa = 0;
            if (objCodigo != null)
            {
                comando = new NpgsqlCommand(string.Format("SELECT guaDefensa FROM guantes WHERE guaCodigo = '{0}'",
                objCodigo), con);
                try
                {
                    res = comando.ExecuteReader();
                }
                catch (NpgsqlException e)
                {
                    MessageBox.Show("No se encontró guante.\n" + e);
                }
                if (res.HasRows)
                {
                    while (res.Read())
                    {
                        defensa = res.GetInt32(0);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró guante.\n");
                    res.Close();
                }
                res.Close();
            }

            
            return defensa;
        }

        public static int retDefPec(string objCodigo, NpgsqlConnection con)
        {
            NpgsqlCommand comando;
            NpgsqlDataReader res = null;
            int defensa = 0;
            if (objCodigo != null)
            {
                comando = new NpgsqlCommand(string.Format("SELECT pchDefensa FROM pecheras WHERE pchCodigo = '{0}'",
                objCodigo), con);
                try
                {
                    res = comando.ExecuteReader();
                }
                catch (NpgsqlException e)
                {
                    MessageBox.Show("No se encontró pechera.\n" + e);
                }
                if (res.HasRows)
                {
                    while (res.Read())
                    {
                        defensa = res.GetInt32(0);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró pechera.\n");
                    res.Close();
                }
                res.Close();
            }
            
            return defensa;
        }

        public static int retDefPan(string objCodigo, NpgsqlConnection con)
        {
            NpgsqlCommand comando;
            NpgsqlDataReader res = null;
            int defensa = 0;
            if (objCodigo != null)
            {
                comando = new NpgsqlCommand(string.Format("SELECT pantDefensa FROM pantalones WHERE pantCodigo = '{0}'",
                objCodigo), con);
                try
                {
                    res = comando.ExecuteReader();
                }
                catch (NpgsqlException e)
                {
                    MessageBox.Show("No se encontró pantalon.\n" + e);
                }
                if (res.HasRows)
                {
                    while (res.Read())
                    {
                        defensa = res.GetInt32(0);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró pantalon.\n");
                    res.Close();
                }
                res.Close();
            }

            
            return defensa;
        }

        public static int retDefBot(string objCodigo, NpgsqlConnection con)
        {
            NpgsqlCommand comando;
            NpgsqlDataReader res = null;
            int defensa = 0;
            if (objCodigo != null)
            {
                comando = new NpgsqlCommand(string.Format("SELECT botDefensa FROM botas WHERE botCodigo = '{0}'",
                objCodigo), con);
                try
                {
                    res = comando.ExecuteReader();
                }
                catch (NpgsqlException e)
                {
                    MessageBox.Show("No se encontró botas.\n" + e);
                }
                if (res.HasRows)
                {
                    while (res.Read())
                    {
                        defensa = res.GetInt32(0);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró botas.\n");
                    res.Close();
                }
                res.Close();
            }

            
            return defensa;
        }
    }

}
