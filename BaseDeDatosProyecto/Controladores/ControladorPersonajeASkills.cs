using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace BaseDeDatosProyecto.Controladores
{
    class ControladorPersonajeASkills
    {

        public static int eliminarPAS(string xPers, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE FROM personajeaprendioskills WHERE peraskpersonaje= '{0}'", xPers), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes eliminar.\n" + e);
            }

            return res;
        }
    }
}

