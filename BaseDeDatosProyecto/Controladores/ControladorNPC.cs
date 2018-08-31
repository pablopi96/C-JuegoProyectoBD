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
    class ControladorNPC
    {
        public static int crearNPC(string xNombre, Mundo xMundo, int xCoordX, int xCoordY, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("INSERT INTO npc (npcnombre, npcmundo, npccoordx, npccoordy) VALUES ({0},{1},{2},{3})", xNombre, xMundo.Nombre, xCoordX, xCoordY), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puede insertar el NPC.\n" + e);
            }

            return res;
        }

        public static int modificarNPC(string xCod, string xNombre, Mundo xMundo, int xCoordX, int xCoordY, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE npc SET npcnombre={0}, npcmundo={1}, npccoordx={2}, npccoordy={3} WHERE npccodigo = {4}", xNombre, xMundo.Nombre, xCoordX, xCoordY, xCod), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes modificar el NPC.\n" + e);
            }

            return res;
        }

        public static int eliminarNPC(string xCod, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE FROM npc WHERE npccodigo = {0}", xCod), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes eliminar el NPC.\n" + e);
            }

            return res;
        }
        public static NpgsqlDataReader NPCs(NpgsqlConnection con)
        {
            NpgsqlDataReader res = null;
            NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM npc", con);
            try
            {
                res = comando.ExecuteReader();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes ver los NPCs.\n" + e);
            }

            return res;
        }

        public static NpgsqlDataReader obtenerNPCsegunCoord(NpgsqlConnection con, string nombreMundo, int xCoordX, int xCoordY)
        {
            NpgsqlDataReader res = null;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("SELECT * FROM npc WHERE npcmundo={0} AND npccoordx={1} AND npccoordy={2}",
                nombreMundo,xCoordX,xCoordY), con);
            try
            {
                res = comando.ExecuteReader();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes ver los NPCs.\n" + e);
            }

            return res;
        }

        public static bool obtenerSiHayNPCsegunCoord(NpgsqlConnection con, string nombreMundo, int xCoordX, int xCoordY)
        {
            bool res = false;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("SELECT * FROM npc WHERE npcmundo={0} AND npccoordx={1} AND npccoordy={2}",
                nombreMundo, xCoordX, xCoordY), con);
            try
            {
                res = comando.ExecuteReader().HasRows;
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes ver los NPCs.\n" + e);
            }

            return res;
        }
    }
}
