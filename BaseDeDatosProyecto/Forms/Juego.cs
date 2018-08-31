using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDeDatosProyecto.Clases;
using System.IO;
using System.Threading;
using System.Collections;
using BaseDeDatosProyecto.Controladores;

namespace BaseDeDatosProyecto
{
    public partial class Juego : Form

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

        static Clases.Mundo mundo;
        string l = Environment.NewLine;
        Personaje p;

        public Juego()
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

        ArrayList bichos;
        private void agregarMasCercanos()
        {
            bichos = ControladorPersonajes.bichosMasCercanos(p.MundoN, p.CoordX, p.CoordY,SplashScreen.conexion);

            foreach(Bicho b in bichos)
            {
                    lstCercanos.Items.Add(b.ToString());
            }
        }

        int vidaPIni = 0;
        private void Juego_Load(object sender, EventArgs e)
        {
            p = ControladorPersonajes.retPersonaje(VarGlobal.percodigo, SplashScreen.conexion);
            vidaP = MetodosGenerales.retVidaPersonaje(VarGlobal.percodigo, SplashScreen.conexion);
            vidaPIni = MetodosGenerales.retVidaPersonaje(VarGlobal.percodigo, SplashScreen.conexion);

            EstadoJuego.aCaminar();
            Controladores.Helpers.actualizarEtiquetasCoord(lblCoordX, lblCoordY, p.CoordX, p.CoordY);
            Controladores.Helpers.actualizarEtiquetasAtt(lblUs, lblPer, lblNivel, lblExp, lblAta, lblDef, lblEne, lblVit,
                p.UsuarioN, p.Nombre,p.Nivel, p.PuntosExp, p.PuntosAtaque, p.PuntosDefensa,
                p.PuntosEnergia, p.PuntosVida);
            
            agregarMasCercanos();
            

            txtJuego.Multiline = true;
            // Add vertical scroll bars to the TextBox control.
            txtJuego.ScrollBars = ScrollBars.Vertical;
            // Allow the TAB key to be entered in the TextBox control.
            txtJuego.AcceptsReturn = true;
            // Allow the TAB key to be entered in the TextBox control.
            txtJuego.AcceptsTab = true;
            // Set WordWrap to true to allow text to wrap to the next line.
            txtJuego.WordWrap = true;

            txtJuego.ReadOnly = true;

            txtJuego.Text = "Bienvenido al juego!" + l;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Juego_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(e.KeyChar == Keys.A)
            //{
            //    MessageBox.Show("Hlla");
            //}
        }

        private int gana(int vidaBicho, int vidaPersonaje)
        {
            if (vidaBicho <= 0)
                return 1;
            else if (vidaPersonaje <= 0)
                return 0;
            else
                return -1;
        }

        bool batalla = false;
        int vidaB = 0;
        int vidaP = 0;

        private void actEt()
        {
            Helpers.actualizarEtiquetasAtt(lblUs, lblPer, lblNivel, lblExp, lblAta, lblDef, lblEne, lblVit,
                p.UsuarioN, p.Nombre, p.Nivel, p.PuntosExp, p.PuntosAtaque, p.PuntosDefensa,
                p.PuntosEnergia, p.PuntosVida);
        }
        private void Juego_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Left:
                    if (EstadoJuego.caminando)
                    {
                        if (p.caminarIzq())
                        {
                            Controladores.Helpers.actualizarEtiquetasCoord(lblCoordX, lblCoordY, p.CoordX, p.CoordY);
                            txtJuego.Text += "Me muevo a la izquierda" + l;
                            lstCercanos.Items.Clear();
                            agregarMasCercanos();
                            p = ControladorPersonajes.retPersonaje(VarGlobal.percodigo, SplashScreen.conexion);
                            actEt();

                            Bicho bch = p.toparseConBicho(bichos);
                            if (bch != null)
                            {
                                EstadoJuego.aCombate();
                                VarGlobal.bicho = bch;
                                TipoDeBicho tbicho = ControladorBichos.retTipoBicho(VarGlobal.bicho.TipoS, SplashScreen.conexion);
                                VarGlobal.tBicho = tbicho;
                                vidaB = tbicho.Vida;
                                txtJuego.Text += l + "Entraste en combate!" + l + l;

                                txtJuego.Text += "Vida personaje:" + vidaP + l;
                                txtJuego.Text += "Vida bicho:" + vidaB + l;
                                txtJuego.Text += l + "Que empiece! Atacá!" + l;

                            }
                        }
                    }
                    else
                    {
                        txtJuego.Text += "Estás en batalla!" + l;
                    }
                    break;
                case Keys.Right:
                    if (EstadoJuego.caminando)
                    {
                        if (p.caminarDer())
                        {
                            Controladores.Helpers.actualizarEtiquetasCoord(lblCoordX, lblCoordY, p.CoordX, p.CoordY);
                            txtJuego.Text += "Me muevo a la derecha" + l;
                            lstCercanos.Items.Clear();
                            agregarMasCercanos();
                            p = ControladorPersonajes.retPersonaje(VarGlobal.percodigo, SplashScreen.conexion);
                            actEt();


                            Bicho bch = p.toparseConBicho(bichos);
                            if (bch != null)
                            {
                                EstadoJuego.aCombate();
                                VarGlobal.bicho = bch;
                                TipoDeBicho tbicho = ControladorBichos.retTipoBicho(VarGlobal.bicho.TipoS, SplashScreen.conexion);
                                VarGlobal.tBicho = tbicho;
                                vidaB = tbicho.Vida;
                                txtJuego.Text += l + "Entraste en combate!" + l +l;
                                
                                txtJuego.Text += "Vida personaje:" + vidaP + l;
                                txtJuego.Text += "Vida bicho:" + vidaB + l;
                                txtJuego.Text += l+ "Que empiece! Atacá!" + l;
                            }
                        }
                    }
                    else
                    {
                        txtJuego.Text += "Estás en batalla!" + l;
                    }
                    break;
                case Keys.Up:
                    if (EstadoJuego.caminando)
                    {
                        if (p.caminarArriba())
                        {
                            Controladores.Helpers.actualizarEtiquetasCoord(lblCoordX, lblCoordY, p.CoordX, p.CoordY);
                            txtJuego.Text += "Me muevo arriba" + l;
                            lstCercanos.Items.Clear();
                            agregarMasCercanos();
                            p = ControladorPersonajes.retPersonaje(VarGlobal.percodigo, SplashScreen.conexion);
                            actEt();


                            Bicho bch = p.toparseConBicho(bichos);
                            if (bch != null)
                            {
                                EstadoJuego.aCombate();
                                VarGlobal.bicho = bch;
                                TipoDeBicho tbicho = ControladorBichos.retTipoBicho(VarGlobal.bicho.TipoS, SplashScreen.conexion);
                                VarGlobal.tBicho = tbicho;
                                vidaB = tbicho.Vida;
                                txtJuego.Text += l + "Entraste en combate!" + l + l;

                                txtJuego.Text += "Vida personaje:" + vidaP + l;
                                txtJuego.Text += "Vida bicho:" + vidaB + l;
                                txtJuego.Text += l + "Que empiece! Atacá!" + l;
                            }
                        }
                    }
                    else
                    {
                        txtJuego.Text += "Estás en batalla!" + l;
                    }
                    break;
                case Keys.Down:
                    if (EstadoJuego.caminando)
                    {
                        if (p.caminarAbajo())
                        {
                            Controladores.Helpers.actualizarEtiquetasCoord(lblCoordX, lblCoordY, p.CoordX, p.CoordY);
                            txtJuego.Text += "Me muevo abajo" + l;
                            lstCercanos.Items.Clear();
                            agregarMasCercanos();
                            p = ControladorPersonajes.retPersonaje(VarGlobal.percodigo, SplashScreen.conexion);
                            actEt();


                            Bicho bch = p.toparseConBicho(bichos);
                            if (bch != null)
                            {
                                EstadoJuego.aCombate();
                                VarGlobal.bicho = bch;
                                TipoDeBicho tbicho = ControladorBichos.retTipoBicho(VarGlobal.bicho.TipoS, SplashScreen.conexion);
                                VarGlobal.tBicho = tbicho;
                                vidaB = tbicho.Vida;
                                txtJuego.Text += l + "Entraste en combate!" + l + l;

                                txtJuego.Text += "Vida personaje:" + vidaP + l;
                                txtJuego.Text += "Vida bicho:" + vidaB + l;
                                txtJuego.Text += l + "Que empiece! Atacá!" + l;
                            }
                        }
                    }
                    else
                    {
                        txtJuego.Text += "Estás en batalla!" + l;
                    }
                    break;
                case Keys.A:
                    if (EstadoJuego.enCombate)
                    {
                        txtJuego.Text += l+"--------------------------------"+l+l;
                        if (vidaB>0 && vidaP > 0)
                        {
                            txtJuego.Text += "Ataque!" + l;
                            //Le resto a la vida del bicho el ataque personaje - defensa del bicho
                            int v = MetodosGenerales.ataPer(VarGlobal.percodigo, SplashScreen.conexion);
                            int d = VarGlobal.tBicho.Defensa;
                            int c = (v - d);
                            if (c < 0)
                            {
                                vidaB -= 0;
                            }
                            else
                            {
                                vidaB -= c;
                            }
                            txtJuego.Text += l + "Ahora:" + l;

                            txtJuego.Text += l+ "Vida personaje:" + vidaP + l;
                            txtJuego.Text += "Vida bicho:" + vidaB + l;

                            if (vidaB > 0 && vidaP > 0)
                            {
                                
                                txtJuego.Text += l + "-----------------------" + l;
                                txtJuego.Text += l+"Turno bicho!" + l;
                                //Thread.Sleep(1000);
                                v = VarGlobal.tBicho.Ataque;
                                d = MetodosGenerales.defPer(VarGlobal.percodigo, SplashScreen.conexion);
                                c = (v - d);
                                if (c < 0)
                                {
                                    vidaP -= 0;
                                }
                                else
                                {
                                    vidaP -= c;
                                }
                                txtJuego.Text += l + "Ahora:" + l;
                                txtJuego.Text += l+ "Vida personaje:" + vidaP + l;
                                txtJuego.Text += "Vida bicho:" + vidaB + l;
                            }
                            else
                            {
                                int gan = gana(vidaB, vidaP);
                                if (gan == 0)
                                {
                                    txtJuego.Text += l + "Vida personaje:" + vidaP + l;
                                    txtJuego.Text += "Vida bicho:" + vidaB + l;
                                    txtJuego.Text += l + "Perdiste!" + l;

                                    ControladorPersonajes.modificarCooPersonaje(VarGlobal.percodigo, 0, 0, SplashScreen.conexion);
                                    p = ControladorPersonajes.retPersonaje(VarGlobal.percodigo, SplashScreen.conexion);
                                    vidaP = vidaPIni;
                                    txtJuego.Text += l + "------------" + l;
                                    txtJuego.Text += l + "Fin Batalla" + l;
                                    txtJuego.Text += "------------" + l;
                                    EstadoJuego.aCaminar();


                                }
                                else if (gan == 1)
                                {
                                    txtJuego.Text += l + "Vida personaje:" + vidaP + l;
                                    txtJuego.Text += "Vida bicho:" + vidaB + l;
                                    txtJuego.Text += l + "Ganaste!" + l;
                                    bool subio = MetodosGenerales.subirExp(VarGlobal.percodigo, SplashScreen.conexion);
                                    if (subio)
                                    {
                                        MessageBox.Show("Subiste de nivel!");
                                        Forms.Puntajes punt = new Forms.Puntajes();
                                        punt.Show();
                                        
                                    }
                                    p = ControladorPersonajes.retPersonaje(VarGlobal.percodigo, SplashScreen.conexion);
                                    actEt();

                                    ControladorBichos.modificarCooBicho(VarGlobal.bicho.Codigo, p.MundoN, SplashScreen.conexion);
                                    agregarMasCercanos();
                                    vidaP = vidaPIni;
                                    txtJuego.Text += l + "------------";
                                    txtJuego.Text += l + "Fin Batalla" + l;
                                    txtJuego.Text += "------------" + l;
                                    EstadoJuego.aCaminar();
                                }
                            }
                        
                        }
                        else
                        {
                            int gan = gana(vidaB, vidaP);
                            if (gan == 0)
                            {
                                txtJuego.Text += l + "Vida personaje:" + vidaP + l;
                                txtJuego.Text += "Vida bicho:" + vidaB + l;
                                txtJuego.Text += l + "Perdiste!" + l;

                                ControladorPersonajes.modificarCooPersonaje(VarGlobal.percodigo, 0, 0, SplashScreen.conexion);
                                p = ControladorPersonajes.retPersonaje(VarGlobal.percodigo, SplashScreen.conexion);
                                vidaP = vidaPIni;

                                txtJuego.Text += l + "------------";
                                txtJuego.Text += l + "Fin Batalla" + l;
                                txtJuego.Text += "------------" + l;
                                EstadoJuego.aCaminar();

                            }
                            else if (gan == 1)
                            {
                                txtJuego.Text += l + "Vida personaje:" + vidaP + l;
                                txtJuego.Text += "Vida bicho:" + vidaB + l;
                                txtJuego.Text += l + "Ganaste!" + l;

                                bool subio = MetodosGenerales.subirExp(VarGlobal.percodigo, SplashScreen.conexion);
                                if (subio)
                                {
                                    MessageBox.Show("Subiste de nivel!");
                                    Forms.Puntajes punt = new Forms.Puntajes();
                                    punt.Show();
                                }
                                p = ControladorPersonajes.retPersonaje(VarGlobal.percodigo, SplashScreen.conexion);
                                actEt();

                                ControladorBichos.modificarCooBicho(VarGlobal.bicho.Codigo, p.MundoN, SplashScreen.conexion);
                                agregarMasCercanos();
                                vidaP = vidaPIni;

                                txtJuego.Text += l + "------------" + l;
                                txtJuego.Text += l + "Fin Batalla" + l;
                                txtJuego.Text += "------------" + l;
                                EstadoJuego.aCaminar();
                            }
                        }
                    }
                    else
                    {
                        txtJuego.Text += "No estás en batalla!" + l;
                    }
                    break;
            }

            txtJuego.Select(txtJuego.Text.Length, 0);
            txtJuego.ScrollToCaret();
            actEt();
        }
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtJuego_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
