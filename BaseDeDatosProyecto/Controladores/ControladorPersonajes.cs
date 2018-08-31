using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using BaseDeDatosProyecto.Clases;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace BaseDeDatosProyecto.Controladores
{
    class ControladorPersonajes
    {
        public static int insertarPersonaje(string xNombre, int xptosAtaque, int xptosDef, int xptosVida,
             int xptosEnergia, int xptosExp, int xNivel, string xCasco, string xPechera, string xPant,
             string xGuantes, string xBotas, string xArmaIzq, string xArmaDer, Usuario xUsuario, string xTipo,
             Mundo xMundo, int xCoordX, int xCoordY, int xCtdLibreInv, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("INSERT INTO personajes (pernombre, perpuntosataque, perpuntosdefensa, perpuntosvitalidad," +
            "perpuntosenergia, perexperiencia, pernivel, percasco, perpechera," +
            "perpantalon, perguantes, perbotas, perarmaizquierda, perarmaderecha," +
            "perusuario, pertipo, permundo, percoordx, percoordy, percantidadlibreinventario) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19})",
            xNombre, xptosAtaque, xptosDef, xptosVida, xptosEnergia, xptosExp, xNivel, xCasco, xPechera, xPant,
            xGuantes, xBotas, xArmaIzq, xArmaDer, xUsuario.NombreUsuario, xTipo, xMundo.Nombre, xCoordX, xCoordY, xCtdLibreInv), con);
            try
            {
                if (Helpers.validarInsPersonaje(xNombre, xUsuario.NombreUsuario, con) == 0)
                    res = comando.ExecuteNonQuery();
                else
                    MessageBox.Show("No puedes tener personajes con el mismo nombre.\nPor favor cambialo.");
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puede insertar el personaje.\n" + e);
            }

            return res;
        }

        public static int insertarPersonaje2(string xNombre, int xptosAtaque, int xptosDef, int xptosVida,
            int xptosEnergia, int xptosExp, int xNivel, Usuario xUsuario, string xTipo,
            string xMundo, int xCoordX, int xCoordY, int xCtdLibreInv, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("INSERT INTO personajes (pernombre, perpuntosataque, perpuntosdefensa, perpuntosvitalidad," +
            "perpuntosenergia, perexperiencia, pernivel, " +
            "perusuario, pertipo, permundo, percoordx, percoordy, percantidadlibreinventario) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
            xNombre, xptosAtaque, xptosDef, xptosVida, xptosEnergia, xptosExp, xNivel, xUsuario.NombreUsuario, xTipo, xMundo, xCoordX, xCoordY, xCtdLibreInv), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Ya existe un personaje con ese nombre, seleccione otro");
            }

            return res;
        }

        public static int actualizarPersonaje(string xNombre, int xptosAtaque, int xptosDef, int xptosVida,
             int xptosEnergia, int xptosExp, int xNivel, string xCasco, string xPechera, string xPant,
             string xGuantes, string xBotas, string xArmaIzq, string xArmaDer, Usuario xUsuario, string xTipo,
             Mundo xMundo, int xCoordX, int xCoordY, int xCtdLibreInv, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE personajes " +
            "SET perpuntosataque ={1}, perpuntosdefensa ={2}," +
            "perpuntosvitalidad ={3}, perpuntosenergia ={4}, perexperiencia ={5}, pernivel ={6}," +
            "percasco ={7}, perpechera ={8}, perpantalon ={9}, perguantes ={10}, perbotas ={11}, " +
            "perarmaizquierda ={12}, perarmaderecha ={13}, " +
            "permundo ={16}, percoordx ={17}, percoordy ={18}, percantidadlibreinventario ={19} " +
            "WHERE  pernombre={0} AND pertipo={15} AND perusuario={14}",
            xNombre, xptosAtaque, xptosDef, xptosVida, xptosEnergia, xptosExp, xNivel, xCasco, xPechera, xPant,
            xGuantes, xBotas, xArmaIzq, xArmaDer, xUsuario.NombreUsuario, xTipo, xMundo.Nombre, xCoordX, xCoordY, xCtdLibreInv), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puede actualizar el personaje.\n" + e);
            }

            return res;
        }

        public static int actualizarCoord(string xNombre, Usuario xUsuario, string xTipo,
             int xCoordX, int xCoordY, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE personajes " +
            "SET percoordx ={3}, percoordy ={4} " +
            "WHERE  pernombre={0} AND pertipo={2} AND perusuario={1}",
            xNombre, xUsuario.NombreUsuario, xTipo, xCoordX, xCoordY), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se pueden actualizar las coordenadas.\n" + e);
            }

            return res;
        }

        public static int eliminarPersonaje(string xNombre, NpgsqlConnection con)
        {
            int res = 0;

            NpgsqlCommand comando = new NpgsqlCommand(string.Format("DELETE FROM personajes " +
            "WHERE pernombre='{0}'", xNombre), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puede eliminar el personaje.\n" + e);
            }

            return res;
        }
        public static NpgsqlDataReader personajes(NpgsqlConnection con)
        {
            NpgsqlDataReader res = null;
            NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM personajes", con);
            try
            {
                res = comando.ExecuteReader();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes ver los personajes.\n" + e);
            }
            
            return res;
        }

        public static string codigoDadoNombrePers(string xNombre, NpgsqlConnection con)
        {
            string res = null;
            NpgsqlDataReader dr = null;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("SELECT * FROM personajes WHERE pernombre = '{0}'",xNombre), con);
            try
            {
                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        res = dr.GetString(0);
                    }
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes ver los personajes.\n" + e);
            }

            dr.Close();
            return res;
        }

        public static DataTable personajesUsuario(Usuario xUsuario, NpgsqlConnection con)
        {
            DataTable dt = new DataTable();
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("SELECT * FROM personajes WHERE perusuario = '{0}'",xUsuario.NombreUsuario), con);
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter(comando);
            adap.Fill(dt);

            return dt;
        }

        public static ArrayList bichosMasCercanos(string xMundo, int xCoordXP, int xCoordYP, NpgsqlConnection con)
        {
            ArrayList resultado = new ArrayList();
            NpgsqlDataReader dr = null;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("SELECT * FROM bichos WHERE bchmundo = '{0}'"+
                "AND sqrt(({1} - bchcoordx)^2 + ({2} - bchcoordy)^2) <= 25", xMundo,xCoordXP,xCoordYP), con);
            try
            {
                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        resultado.Add(new Bicho(dr.GetString(0), dr.GetString(1), xMundo, dr.GetInt32(3), dr.GetInt32(4)));
                    }
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes traer los bichos.\n" + e);
            }

            dr.Close();

            return resultado;
        }

        public static Personaje retPersonaje(string xcodigo, NpgsqlConnection con)
        {
            string casco = null;
            string pech = null;
            string pant = null;
            string gua = null;
            string bot = null;
            string armIzq = null;
            string armDer = null;

            Personaje per = null;
            NpgsqlDataReader dr = null;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("SELECT * FROM personajes WHERE percodigo = '{0}'", xcodigo), con);
            try
            {
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    if (!dr.IsDBNull(8))
                        casco = dr.GetString(8);
                    if (!dr.IsDBNull(9))
                        pech = dr.GetString(9);
                    if (!dr.IsDBNull(10))
                        pant = dr.GetString(10);
                    if (!dr.IsDBNull(11))
                        gua = dr.GetString(11);
                    if (!dr.IsDBNull(12))
                        bot = dr.GetString(12);
                    if (!dr.IsDBNull(13))
                        armIzq = dr.GetString(13);
                    if (!dr.IsDBNull(14))
                        armDer = dr.GetString(14);

                    per = new Personaje(dr.GetString(0), dr.GetString(1), int.Parse(dr.GetString(2)),
                        int.Parse(dr.GetString(3)), int.Parse(dr.GetString(4)), int.Parse(dr.GetString(5)),
                        int.Parse(dr.GetString(6)), int.Parse(dr.GetString(7)), casco, pech, pant, gua, bot, armIzq, armDer,
                        dr.GetString(15), dr.GetString(16), dr.GetString(17), int.Parse(dr.GetString(18)),
                        int.Parse(dr.GetString(19)), int.Parse(dr.GetString(20)), int.Parse(dr.GetString(21)));
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se pudo traer el personaje.\n" + e);
            }

            dr.Close();
            return per;
        }

        public static int modificarCooPersonaje(string codigoPersonaje, int perCoordX, int perCoordY, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE personajes SET perCoordX = '{1}', perCoordY = '{2}' WHERE perCodigo = '{0}'", codigoPersonaje, perCoordX, perCoordY), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes cambiar las coordenadas del personaje.\n" + e);
            }

            return res;
        }

        public static int modificarExpPersonaje(string codigoPersonaje, int exp, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE personajes SET perExperiencia = '{1}' WHERE perCodigo = '{0}'", codigoPersonaje, exp), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes cambiar la experienca del personaje.\n" + e);
            }

            return res;
        }
        public static int modificarNivel(string codigoPersonaje, int nivel, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE personajes SET perNivel = '{1}' WHERE perCodigo = '{0}'", codigoPersonaje, nivel), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes cambiar el nivel del personaje.\n" + e);
            }

            return res;
        }

        public static int modificarPuntos(string codigoPersonaje, int ptosAtaque, int ptosDefensa, int ptosEnergia, int ptosVitalidad, NpgsqlConnection con)
        {
            int res = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("UPDATE personajes SET perPuntosAtaque = perPuntosAtaque+'{1}', perPuntosDefensa = perPuntosDefensa+'{2}', perPuntosEnergia = perPuntosEnergia+'{3}', perPuntosVitalidad = perPuntosVitalidad+'{4}' WHERE perCodigo = '{0}' ", codigoPersonaje, ptosAtaque, ptosDefensa, ptosEnergia, ptosVitalidad), con);
            try
            {
                res = comando.ExecuteNonQuery();
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No puedes cambiar los puntajes.\n" + e);
            }

            return res;
        }
    }
}
