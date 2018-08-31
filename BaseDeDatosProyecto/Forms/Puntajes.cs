using BaseDeDatosProyecto.Clases;
using BaseDeDatosProyecto.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatosProyecto.Forms
{
    public partial class Puntajes : Form
    {
        int puntos = 5;
        public Puntajes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            puntos -= 1;
            ControladorPersonajes.modificarPuntos(VarGlobal.percodigo, 1, 0, 0, 0, SplashScreen.conexion);
            labelPuntos.Text = puntos.ToString();
            Personaje personaje = ControladorPersonajes.retPersonaje(VarGlobal.percodigo, SplashScreen.conexion);
            labelPtosAtaque.Text = personaje.PuntosAtaque.ToString();
            labelPtosDefensa.Text = personaje.PuntosDefensa.ToString();
            labelPtosEnergia.Text = personaje.PuntosEnergia.ToString();
            labelPtosVitalidad.Text = personaje.PuntosVida.ToString();
            if (puntos == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
            }
        }

        private void Puntajes_Load(object sender, EventArgs e)
        {
            labelPuntos.Text = puntos.ToString();
            Personaje personaje     = ControladorPersonajes.retPersonaje(VarGlobal.percodigo, SplashScreen.conexion);
            labelPtosAtaque.Text    = personaje.PuntosAtaque.ToString();
            labelPtosDefensa.Text   = personaje.PuntosDefensa.ToString();
            labelPtosEnergia.Text   = personaje.PuntosEnergia.ToString();
            labelPtosVitalidad.Text = personaje.PuntosVida.ToString();
            button5.Enabled = false;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            puntos -= 1;
            ControladorPersonajes.modificarPuntos(VarGlobal.percodigo, 0, 1, 0, 0, SplashScreen.conexion);
            labelPuntos.Text = puntos.ToString();
            Personaje personaje = ControladorPersonajes.retPersonaje(VarGlobal.percodigo, SplashScreen.conexion);
            labelPtosAtaque.Text = personaje.PuntosAtaque.ToString();
            labelPtosDefensa.Text = personaje.PuntosDefensa.ToString();
            labelPtosEnergia.Text = personaje.PuntosEnergia.ToString();
            labelPtosVitalidad.Text = personaje.PuntosVida.ToString();
            if (puntos == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            puntos -= 1;
            ControladorPersonajes.modificarPuntos(VarGlobal.percodigo, 0, 0, 1, 0, SplashScreen.conexion);
            labelPuntos.Text = puntos.ToString();
            Personaje personaje = ControladorPersonajes.retPersonaje(VarGlobal.percodigo, SplashScreen.conexion);
            labelPtosAtaque.Text = personaje.PuntosAtaque.ToString();
            labelPtosDefensa.Text = personaje.PuntosDefensa.ToString();
            labelPtosEnergia.Text = personaje.PuntosEnergia.ToString();
            labelPtosVitalidad.Text = personaje.PuntosVida.ToString();
            if (puntos == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            puntos -= 1;
            ControladorPersonajes.modificarPuntos(VarGlobal.percodigo, 0, 0, 0, 1, SplashScreen.conexion);
            labelPuntos.Text = puntos.ToString();
            Personaje personaje = ControladorPersonajes.retPersonaje(VarGlobal.percodigo, SplashScreen.conexion);
            labelPtosAtaque.Text = personaje.PuntosAtaque.ToString();
            labelPtosDefensa.Text = personaje.PuntosDefensa.ToString();
            labelPtosEnergia.Text = personaje.PuntosEnergia.ToString();
            labelPtosVitalidad.Text = personaje.PuntosVida.ToString();
            if (puntos == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
