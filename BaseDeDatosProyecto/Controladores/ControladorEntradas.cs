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
    class ControladorEntradas
    {
        public static int crearEntrada(string xNombre, Mundo xMundoTel, Mundo xMundo, int xCoordX, int xCoordY, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("INSERT INTO entradas (entnombre, entmundoteletransporta, entmundo, entcoordx, entcoordy) VALUES ({0},{1},{2},{3},{4})", 
                xNombre, xMundoTel.Nombre, xMundo.Nombre, xCoordX, xCoordY), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puede insertar la entrada.\n" + e);
            }

            return res;
        }

        public static int modificarEntrada(string xCod, string xNombre, Mundo xMundoTel, Mundo xMundo, int xCoordX, int xCoordY, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE entradas SET entnombre ={0}, entmundoteletransporta ={1}, entmundo ={2}, entcoordx ={3}, entcoordy ={4} WHERE entcodigo = {5}", xNombre, xMundoTel.Nombre, xMundo.Nombre, xCoordX, xCoordY, xCod), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes modificar la entrada.\n" + e);
            }

            return res;
        }

        public static int eliminarEntrada(string xCod, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE FROM entradas WHERE entcodigo = {0}", xCod), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes eliminar la entrada.\n" + e);
            }

            return res;
        }
        public static NpgsqlDataReader entradas(NpgsqlConnection con)
        {
            NpgsqlDataReader res = null;
            NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM entradas", con);
            try
            {
                res = comando.ExecuteReader();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes ver las entradas.\n" + e);
            }

            return res;
        }
    }
}
