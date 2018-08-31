using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace BaseDeDatosProyecto.Controladores
{
    class ControladorMundos
    {
        public static int retXFin(string xNombreMundo,NpgsqlConnection con)
        {
            NpgsqlDataReader dr = null;
            int coord = 0;
            try
            {
                NpgsqlCommand com = new NpgsqlCommand(string.Format("SELECT mocoordxfin FROM mundos WHERE monombre='{0}'", xNombreMundo), con);

                dr = com.ExecuteReader();

                while (dr.Read())
                {
                    coord = dr.GetInt32(0);
                    break;
                }
            }
            catch(NpgsqlException e)
            {
                MessageBox.Show("No se puede retornar la coordenada\n" + e.Message);
            }

            dr.Close();

            return coord;
        }

        public static int retYFin(string xNombreMundo, NpgsqlConnection con)
        {
            NpgsqlDataReader dr = null;
            int coord = 0;
            try
            {
                NpgsqlCommand com = new NpgsqlCommand(string.Format("SELECT mocoordyfin FROM mundos WHERE monombre='{0}'", xNombreMundo), con);

                dr = com.ExecuteReader();

                while (dr.Read())
                {
                    coord = dr.GetInt32(0);
                    break;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puede retornar la coordenada\n" + e.Message);
            }

            dr.Close();

            return coord;
        }

        public static int[] retCoordCiudad(string xNombreMundo, NpgsqlConnection con)
        {
            int[] coordCiudad = new int[4];
            NpgsqlDataReader dr = null;
            try
            {
                NpgsqlCommand com = new NpgsqlCommand(string.Format("SELECT mocoordxciudadini,mocoordyciudadini,"+
                    "mocoordxciudadfin,mocoordyciudadfin FROM mundos WHERE monombre='{0}'", xNombreMundo), con);

                dr = com.ExecuteReader();

                while (dr.Read())
                {
                    coordCiudad = new int[4] {dr.GetInt32(0),dr.GetInt32(1),dr.GetInt32(2),dr.GetInt32(3)};
                    break;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puede retornar la coordenada\n" + e.Message);
            }
            dr.Close();
            
            return coordCiudad;
        }
    }
}
