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
    class ControladorBichos
    {

        public static TipoDeBicho retTipoBicho(string xtipoBicho, NpgsqlConnection con)
        {
            TipoDeBicho tbicho = null;
            NpgsqlDataReader res = null;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("SELECT * FROM tiposdebicho WHERE tbchnombre ='{0}'", xtipoBicho), con);
            try
            {
                res = comando.ExecuteReader();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puedes insertar la poción.\n" + e);
            }
            if (res.HasRows)
            {
                while (res.Read())
                {
                    tbicho = new TipoDeBicho(res.GetString(0), res.GetInt32(1), res.GetInt32(2), res.GetInt32(3));
                    break;
                }
            }
            else
            {
                MessageBox.Show("No se encontró Pechera.\n");
                res.Close();
            }
            res.Close();

            return tbicho;
        }
        public static int insertarBicho(string xTipo, Mundo xMundo, int xCoordX, int xCoordY, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("INSERT INTO bichos (bchtipo, bchmundo, bchcoordx, bchcoordy) VALUES ({0},{1},{2},{3})", xTipo, xMundo.Nombre, xCoordX, xCoordY), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puede insertar el bicho.\n" + e);
            }

            
            return res;
        }

        public static int modificarBicho(string xCod, string xTipo, Mundo xMundo, int xCoordX, int xCoordY, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE bichos SET bchtipo={0}, bchmundo={1} bchcoordx={2} bchcoordy={3} WHERE bchcodigo={4}", xTipo, xMundo.Nombre, xCoordX, xCoordY, xCod), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes modificar el bicho.\n" + e);
            }

            return res;
        }

        public static int eliminarBicho(string xCod, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE FROM bichos WHERE bchcodigo = {0}", xCod), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes eliminar el bicho.\n" + e);
            }

            return res;
        }

        public static NpgsqlDataReader bichos(NpgsqlConnection con)
        {
            NpgsqlDataReader res = null;
            NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM bichos", con);
            try
            {
                res = comando.ExecuteReader();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes ver los bichos.\n" + e);
            }

            return res;
        }

        public static int modificarCooBicho(string xCod, string xMundo, NpgsqlConnection con)
        {
            bool bien = false;

            Random rnd = new Random();
            int x = rnd.Next(0, ControladorMundos.retXFin(xMundo, SplashScreen.conexion));
            int y = rnd.Next(0, ControladorMundos.retYFin(xMundo, SplashScreen.conexion));

            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE bichos SET bchcoordx='{1}', bchcoordy='{2}' WHERE bchcodigo='{0}'", xCod, x, y), con);
            //while (!bien)
            
                try
                {
                    res = comando.ExecuteNonQuery();
                    
                }
                catch (NpgsqlException e)
                {
                    
                }

            return res;
        }
    }
}
