using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatosProyecto
{
    public partial class Registro : Form
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
        public Registro()
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Controladores.ControladorUsuarios.crearCuentaUsuario(txtUsuario.Text, txtContraseña.Text, 
            //    txtNombre.Text, txtMail.Text, SplashScreen.conexion);

            if (!Controladores.Helpers.validarMismaPass(txtContraseña.Text, txtContraseña2.Text))
            {
                MessageBox.Show("Los campos Contraseña y Confirmar contraseña no coinciden.");
                return;
            }


            else if (Controladores.ControladorUsuarios.crearCuentaUsuario(txtUsuario.Text, txtContraseña.Text,
                txtNombre.Text, txtMail.Text, SplashScreen.conexion) == 0)
            {
                return;
            }

            MenuPrincipal mp = new MenuPrincipal();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
