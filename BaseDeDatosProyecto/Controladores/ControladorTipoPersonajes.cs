using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using BaseDeDatosProyecto.Clases;
using System.Windows.Forms;

namespace BaseDeDatosProyecto.Controladores
{
    class ControladorTipoPersonajes
    {
        public static NpgsqlDataReader tiposPersonaje(NpgsqlConnection con)
        {
            NpgsqlDataReader res = null;
            NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM tiposdepersonaje", con);
            try
            {
                res = comando.ExecuteReader();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes ver los tipos de personaje.\n" + e);
            }

            return res;
        }

        public static TipoPersonaje retTipoPersonaje(string tperNombre, NpgsqlConnection con)
        {
            TipoPersonaje tipoPersonaje = null;
            NpgsqlDataReader res = null;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("SELECT *FROM tiposdepersonaje WHERE tperNombre = '{0}'",
                    tperNombre), con);
            try
            {
                res = comando.ExecuteReader();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se encontró el Tipo de Personaje.\n" + e);
            }

            if (res.HasRows)
            {
                while (res.Read())
                {
                    tipoPersonaje = new TipoPersonaje(res.GetString(0), res.GetInt32(1), res.GetInt32(2), res.GetInt32(3), res.GetInt32(4));
                    break;
                }
            }
            else
            {
                MessageBox.Show("No se encontró Tipo de Personaje.\n");
                res.Close();
                return null;
            }
            res.Close();
            return tipoPersonaje;
        }
    }
}
