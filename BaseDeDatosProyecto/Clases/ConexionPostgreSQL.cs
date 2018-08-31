using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace BaseDeDatosProyecto
{
    public class ConexionPostgreSQL
    {
        public NpgsqlConnection conexion()
        {
            NpgsqlConnection conexion = new NpgsqlConnection();
            var cadenaConexion = "Server=localhost;Port=5432;User Id=postgres;Password=7271;Database=MUCU";

            if (!string.IsNullOrWhiteSpace(cadenaConexion))
            {
                try
                {
                    conexion = new NpgsqlConnection(cadenaConexion);
                    conexion.Open();
                    Console.WriteLine("La conexión se abrió correctamente");
                    MessageBox.Show("La conexión se abrió correctamente");
                }
                catch(Exception)
                {
                    conexion.Close();
                    Console.WriteLine("No se pudo abrir la conexión.");
                    MessageBox.Show("No se pudo abrir la conexión.");
                }
            }
            return conexion;
        }
    }
}
