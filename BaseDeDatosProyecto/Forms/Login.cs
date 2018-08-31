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
    public partial class Login : Form
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
        public Login()
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Controladores.ControladorUsuarios.login(textBox1.Text, textBox2.Text, SplashScreen.conexion) == 2)
            {
                Clases.VarGlobal.usuLog = textBox1.Text;
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro reg = new Registro();
            this.Hide();
            reg.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
