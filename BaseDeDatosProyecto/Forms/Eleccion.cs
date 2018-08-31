using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDeDatosProyecto.Controladores;
using BaseDeDatosProyecto.Clases;

namespace BaseDeDatosProyecto
{
    public partial class Eleccion : Form
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
        public Eleccion()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.Crear_personaje crearP = new Forms.Crear_personaje();
            this.Hide();
            crearP.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VarGlobal.percodigo = (string)cmbPers.SelectedValue;
            Juego juego = new Juego();
            this.Hide();
            juego.ShowDialog();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void Eleccion_Load(object sender, EventArgs e)
        {
            DataTable dt = ControladorPersonajes.personajesUsuario(VarGlobal.usLogged, SplashScreen.conexion);
            this.cmbPers.DataSource = dt;
            this.cmbPers.DisplayMember = "pernombre";
            this.cmbPers.ValueMember = "perCodigo";
            this.cmbPers.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombrePers = cmbPers.Text;
            string codigoPers = ControladorPersonajes.codigoDadoNombrePers(nombrePers, SplashScreen.conexion);
            ControladorPersonajes.eliminarPersonaje(nombrePers, SplashScreen.conexion);
            ControladorInvGuardaArmas.eliminarArmas(codigoPers, null, SplashScreen.conexion);
            ControladorInvGuardaBotas.eliminarBot(codigoPers, null, SplashScreen.conexion);
            ControladorInvGuardaCasco.eliminarCas(codigoPers, null, SplashScreen.conexion);
            ControladorInvGuardaGuantes.eliminarGua(codigoPers, null, SplashScreen.conexion);
            ControladorInvGuardaObjEsp.eliminarObjEsp(codigoPers, null, SplashScreen.conexion);
            ControladorInvGuardaPantalones.eliminarPan(codigoPers, null, SplashScreen.conexion);
            ControladorInvGuardaPecheras.eliminarPec(codigoPers, null, SplashScreen.conexion);
            ControladorInvGuardaPociones.eliminarPoc(codigoPers, null, SplashScreen.conexion);
            ControladorPersonajeASkills.eliminarPAS(codigoPers, SplashScreen.conexion);
        }

        private void cmbPers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
