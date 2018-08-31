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

namespace BaseDeDatosProyecto.Forms
{
    public partial class Administrador : Form
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
        public Administrador()
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

        private static DataTable getData(string sqlCommand)
        {

            NpgsqlConnection conexion = SplashScreen.conexion;

            NpgsqlCommand command = new NpgsqlCommand(sqlCommand, conexion);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From usuarios");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            gridConsultas.Font = new Font("Maiandra GD",12);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Forms.Acceso acc = new Acceso();
            this.Hide();
            acc.ShowDialog();
            this.Close();
        }

        private void gridConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMundos_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From mundos");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnArmas_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From armas");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnBotas_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From botas");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnCascos_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From cascos");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnPecheras_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From pecheras");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnGuantes_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From guantes");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnPantalones_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From pantalones");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnSkills_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From skills");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnPersonajes_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From personajes");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnBichos_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From bichos");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnPociones_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From pociones");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnSkillsAp_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From personajeaprendioskills");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnTiposB_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From tiposdebicho");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnTiposP_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From tiposdepersonaje");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From entradas");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnNPCs_Click(object sender, EventArgs e)
        {
            // Seteo el contenido del grid
            gridConsultas.DataSource = getData("Select * From npc");

            // Ajusto celdas automáticamente
            gridConsultas.AutoSizeRowsMode =
              DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            gridConsultas.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

            // Seteo borde
            gridConsultas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
