using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Collections;
using System.Windows.Forms;
using BaseDeDatosProyecto.Clases;

namespace BaseDeDatosProyecto.Controladores
{
    class ControladorArmas
    {
        public static ArrayList retArmas(string armCodigo, NpgsqlConnection con)
        {
            NpgsqlCommand comando;
            NpgsqlDataReader res = null;
            Arma arma;
            ArrayList armas = new ArrayList();
            if (armCodigo != null)
            {
                comando = new NpgsqlCommand(string.Format("SELECT *FROM armas WHERE armCodigo = '{0}'",
                armCodigo), con);
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
                comando = new NpgsqlCommand(string.Format("SELECT *FROM armas"), con);
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
                    arma = new Arma(res.GetString(0), res.GetString(1), res.GetInt32(2), res.GetInt32(3),
                                       res.GetBoolean(4), res.GetBoolean(5), res.GetInt32(6));
                    armas.Add(arma);
                }
            }
            else
            {
                MessageBox.Show("No se encontró Armas.\n");
                res.Close();
                return null;
            }
            res.Close();
            return armas;
        }

    }
}
