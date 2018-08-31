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

namespace BaseDeDatosProyecto
{
    public partial class SplashScreen : Form
    {
        public static NpgsqlConnection conexion;

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
        public SplashScreen()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.AutoSize = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            Region ptr = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.Region = ptr;

            Tiempo.Enabled = true;
            Tiempo.Interval = 3000;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            ConexionPostgreSQL objCon = new ConexionPostgreSQL();
            conexion = objCon.conexion();
            Tiempo.Stop();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
