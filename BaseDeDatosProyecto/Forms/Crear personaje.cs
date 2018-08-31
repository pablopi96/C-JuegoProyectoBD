using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Collections;
using BaseDeDatosProyecto.Clases;

namespace BaseDeDatosProyecto.Forms
{
    public partial class Crear_personaje : Form
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern System.IntPtr CreateRoundRectRgn
           (
               int nLeftRect, // x-coordinate of upper-left corner
               int nTopRect, // y-coordinate of upper-left corner
               int nRightRect, // x-coordinate of lower-right corner
               int nBottomRect, // y-coordinate of lower-right corner
               int nWidthEllipse, // height of ellipse
               int nHeightEllipse // width of ellipse
           );
        public Crear_personaje()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.AutoSize = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();
            Region ptr = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            this.Region = ptr;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string per = cmbTiposPers.Text;
            int numper = Clases.VarGlobal.nomPersonajes.IndexOf(per);
            Controladores.ControladorPersonajes.insertarPersonaje2(textBox1.Text, Int32.Parse(Clases.VarGlobal.ataPersonajes[numper].ToString()), 
                Int32.Parse(Clases.VarGlobal.defPersonajes[numper].ToString()), 
                Int32.Parse(Clases.VarGlobal.vidPersonajes[numper].ToString()), 
                Int32.Parse(Clases.VarGlobal.manPersonajes[numper].ToString()), 0, 1, 
                VarGlobal.usLogged, per, "Lorencia", 0, 0, 50, SplashScreen.conexion);

            Eleccion eleccion = new Eleccion();
            this.Hide();
            eleccion.ShowDialog();
            this.Close();
        }

        private void Crear_personaje_Load(object sender, EventArgs e)
        {
            NpgsqlDataReader tipoPer = Controladores.ControladorTipoPersonajes.tiposPersonaje(SplashScreen.conexion);
            ArrayList personajes = new ArrayList();
            while (tipoPer.Read())
            {
                personajes.Add(tipoPer.GetString(0));
                Clases.VarGlobal.nomPersonajes.Add(tipoPer.GetString(0));
                Clases.VarGlobal.ataPersonajes.Add(tipoPer.GetString(1));
                Clases.VarGlobal.defPersonajes.Add(tipoPer.GetString(2));
                Clases.VarGlobal.vidPersonajes.Add(tipoPer.GetString(3));
                Clases.VarGlobal.manPersonajes.Add(tipoPer.GetString(4));
            }
            cmbTiposPers.DataSource = personajes;
            tipoPer.Close();

        }

        private void cmbTiposPers_SelectedIndexChanged(object sender, EventArgs e)
        {

            string per = cmbTiposPers.Text;
            int numper = Clases.VarGlobal.nomPersonajes.IndexOf(per);
            lblAtaque.Text = "" + Clases.VarGlobal.ataPersonajes[numper];
            lblDefensa.Text = "" + Clases.VarGlobal.defPersonajes[numper];
            lblVida.Text = "" + Clases.VarGlobal.vidPersonajes[numper];
            lblMana.Text = "" + Clases.VarGlobal.manPersonajes[numper];
        }
    }
}
