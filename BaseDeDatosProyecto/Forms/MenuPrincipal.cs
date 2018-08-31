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
    public partial class MenuPrincipal : Form
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

        public MenuPrincipal()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clases.VarGlobal.usuLog == "")
            {
                MessageBox.Show("Debe loguearse antes de comenzar a jugar.");
                return;
            }
            Eleccion eleccion = new Eleccion();
            this.Hide();
            eleccion.ShowDialog();
            this.Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            label2.Text = Clases.VarGlobal.usuLog;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SplashScreen.conexion.Close();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            this.Hide();
            registro.ShowDialog();
            this.Close();
            
        }
    }
}
