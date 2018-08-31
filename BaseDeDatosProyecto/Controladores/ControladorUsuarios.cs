using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using BaseDeDatosProyecto.Clases;

namespace BaseDeDatosProyecto.Controladores
{
    class ControladorUsuarios
    {
        public static int crearCuentaUsuario(string xUsuario, string xPass, string xNombre, string xMail, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("INSERT INTO usuarios (usnombredeusuario, uspassword, usnombre, usmail) VALUES ('{0}','{1}','{2}','{3}')", xUsuario, xPass, xNombre, xMail), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                //if (e.ErrorCode == -2147467259)
                //{
                MessageBox.Show("Introduzca un mail valido.");

            }

            return res;
        }

        public static int modificarNombreUsuario(String xUsuario, String xNombre, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE usuarios SET usnombre = {1} WHERE usnombredeusuario= {0}", xUsuario, xNombre), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes cambiar tu nombre.\n" + e);
            }

            return res;
        }
        public static int modificarPassUsuario(String xUsuario, String xPass, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE usuarios SET uspassword = {1} WHERE usnombredeusuario= {0}", xUsuario, xPass), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes cambiar tu Contraseña.\n" + e);
            }

            return res;
        }

        public static int modificarMailUsuario(String xUsuario, String xMail, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE usuarios SET usmail = {1} WHERE usnombredeusuario = {0}", xUsuario, xMail), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes cambiar tu mail.\n" + e);
            }

            return res;
        }

        public static int eliminarUsuario(string xUsuario, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE FROM usuarios WHERE usnombredeusuario = {0}", xUsuario), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes eliminar el usuario.\n" + e);
            }

            return res;
        }

        public static int login(string xUsuario, string xPass, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("SELECT * FROM usuarios WHERE usnombredeusuario = '{0}'", xUsuario), con);
            NpgsqlDataReader reader = comando.ExecuteReader();
            try
            {


                while (reader.Read())
                {
                    res = 1;
                }


            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("" + e);
            }


            reader.Close();

            if (res == 1)
            {

                comando = new NpgsqlCommand(string.Format("SELECT * FROM usuarios WHERE usnombredeusuario = '{0}' AND uspassword = '{1}'", xUsuario, xPass), con);
                reader = comando.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        res = 2;
                        VarGlobal.usLogged = new Usuario(xUsuario,xPass, reader.GetString(2),reader.GetString(3));
                    }

                }
                catch (NpgsqlException e)
                {
                    MessageBox.Show("" + e);
                }

                reader.Close();
            }
                if (res == 0)
                {
                    MessageBox.Show("El usuario ingresado no existe. Puede registrar un usuario accediendo al menú principal.");
                }
                else if (res == 1)
                {
                    MessageBox.Show("Los datos ingresados no son correctos.");
                }

                return res;
            
        }
        public static NpgsqlDataReader usuarios(NpgsqlConnection con)
        {
            NpgsqlDataReader res = null;
            NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM usuarios", con);
            try
            {
                res = comando.ExecuteReader();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes ver los usuarios.\n" + e);
            }

            return res;
        }
    }
}
