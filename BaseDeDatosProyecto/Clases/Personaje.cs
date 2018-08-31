using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using BaseDeDatosProyecto.Controladores;

namespace BaseDeDatosProyecto.Clases
{
    class Personaje
    {
        string codigo;
        string nombre;
        int puntosAtaque;
        int puntosDefensa;
        int puntosVida;
        int puntosEnergia;
        int puntosExp;
        int nivel;
        string casco;
        string pechera;
        string pantalon;
        string guantes;
        string botas;
        string armaIzquierda;
        string armaDerecha;
        Usuario usuario;
        string usuarioN;
        string tipo;
        Mundo mundo;
        string mundoN;
        int coordX;
        int coordY;
        int dinero;
        Inventario inv;
        ArrayList skills;
        Skill skillAsigned;
        int xInvCantLibre;

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int PuntosAtaque
        {
            get
            {
                return puntosAtaque;
            }

            set
            {
                puntosAtaque = value;
            }
        }

        public int PuntosDefensa
        {
            get
            {
                return puntosDefensa;
            }

            set
            {
                puntosDefensa = value;
            }
        }

        public int PuntosVida
        {
            get
            {
                return puntosVida;
            }

            set
            {
                puntosVida = value;
            }
        }

        public int PuntosEnergia
        {
            get
            {
                return puntosEnergia;
            }

            set
            {
                puntosEnergia = value;
            }
        }

        public int PuntosExp
        {
            get
            {
                return puntosExp;
            }

            set
            {
                puntosExp = value;
            }
        }

        public int Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                nivel = value;
            }
        }

        public string Casco
        {
            get
            {
                return casco;
            }

            set
            {
                casco = value;
            }
        }

        public string Pechera
        {
            get
            {
                return pechera;
            }

            set
            {
                pechera = value;
            }
        }

        public string Pantalon
        {
            get
            {
                return pantalon;
            }

            set
            {
                pantalon = value;
            }
        }

        public string Guantes
        {
            get
            {
                return guantes;
            }

            set
            {
                guantes = value;
            }
        }

        public string Botas
        {
            get
            {
                return botas;
            }

            set
            {
                botas = value;
            }
        }

        public string ArmaIzquierda
        {
            get
            {
                return armaIzquierda;
            }

            set
            {
                armaIzquierda = value;
            }
        }

        public string ArmaDerecha
        {
            get
            {
                return armaDerecha;
            }

            set
            {
                armaDerecha = value;
            }
        }

        internal Usuario Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        internal Mundo Mundo
        {
            get
            {
                return mundo;
            }

            set
            {
                mundo = value;
            }
        }

        public int CoordX
        {
            get
            {
                return coordX;
            }

            set
            {
                coordX = value;
            }
        }

        public int CoordY
        {
            get
            {
                return coordY;
            }

            set
            {
                coordY = value;
            }
        }

        internal Inventario Inv
        {
            get
            {
                return inv;
            }

            set
            {
                inv = value;
            }
        }

        public int Dinero
        {
            get
            {
                return dinero;
            }

            set
            {
                dinero = value;
            }
        }

        public string UsuarioN
        {
            get
            {
                return usuarioN;
            }

            set
            {
                usuarioN = value;
            }
        }

        public string MundoN
        {
            get
            {
                return mundoN;
            }

            set
            {
                mundoN = value;
            }
        }

        public int XInvCantLibre
        {
            get
            {
                return xInvCantLibre;
            }

            set
            {
                xInvCantLibre = value;
            }
        }

        public Personaje(string xCod, string xNombre, int xptosAtaque, int xptosDef, int xptosVida, 
            int xptosEnergia, int xptosExp, int xNivel, string xCasco, string xPechera, string xPant,
            string xGuantes, string xBotas, string xArmaIzq, string xArmaDer, Usuario xUsuario, string xTipo,
            Mundo xMundo, int xCoordX, int xCoordY, int xDinero, Inventario xInv)
        {
            this.Codigo = xCod;
            this.Nombre = xNombre;
            this.PuntosAtaque = xptosAtaque;
            this.PuntosDefensa = xptosDef;
            this.PuntosVida = xptosVida;
            this.PuntosEnergia = xptosEnergia;
            this.PuntosExp = xptosExp;
            this.Nivel = xNivel;
            this.Casco = xCasco;
            this.Pechera = xPechera;
            this.Pantalon = xPant;
            this.Guantes = xGuantes;
            this.Botas = xBotas;
            this.ArmaIzquierda = xArmaIzq;
            this.ArmaDerecha = xArmaDer;
            this.Usuario = xUsuario;
            this.Tipo = xTipo;
            this.Mundo = xMundo;
            this.CoordX = xCoordX;
            this.CoordY = xCoordY;
            this.inv = xInv;
            this.dinero = xDinero;
        }

        public Personaje(string xCod, string xNombre, int xptosAtaque, int xptosDef, int xptosVida,
            int xptosEnergia, int xptosExp, int xNivel, Usuario xUsuario, string xTipo,
            Mundo xMundo, int xCoordX, int xCoordY, Inventario xInv)
        {
            this.Codigo = xCod;
            this.Nombre = xNombre;
            this.PuntosAtaque = xptosAtaque;
            this.PuntosDefensa = xptosDef;
            this.PuntosVida = xptosVida;
            this.PuntosEnergia = xptosEnergia;
            this.PuntosExp = xptosExp;
            this.Nivel = xNivel;
            this.Usuario = xUsuario;
            this.Tipo = xTipo;
            this.Mundo = xMundo;
            this.CoordX = xCoordX;
            this.CoordY = xCoordY;
            this.inv = xInv;
        }

        public Personaje(string codigo, string nombre, int puntosAtaque, int puntosDefensa, 
            int puntosVida, int puntosEnergia, int puntosExp, int nivel, string casco, 
            string pechera, string pantalon, string guantes, string botas, string armaIzquierda, 
            string armaDerecha, string usuarioN, string tipo, string mundoN, int coordX, int coordY, int dinero,
            int xInvCantLibre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.puntosAtaque = puntosAtaque;
            this.puntosDefensa = puntosDefensa;
            this.puntosVida = puntosVida;
            this.puntosEnergia = puntosEnergia;
            this.puntosExp = puntosExp;
            this.nivel = nivel;
            this.casco = casco;
            this.pechera = pechera;
            this.pantalon = pantalon;
            this.guantes = guantes;
            this.botas = botas;
            this.armaIzquierda = armaIzquierda;
            this.armaDerecha = armaDerecha;
            this.UsuarioN = usuarioN;
            this.tipo = tipo;
            this.MundoN = mundoN;
            this.coordX = coordX;
            this.coordY = coordY;
            this.dinero = dinero;
            this.XInvCantLibre = xInvCantLibre;
        }

        public bool caminarIzq()
        {
            if (this.coordX != 0)
            {
                this.coordX--;
                ControladorPersonajes.modificarCooPersonaje(VarGlobal.percodigo, this.coordX, this.coordY, SplashScreen.conexion);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool caminarDer()
        {
            if (this.coordX != ControladorMundos.retXFin(this.MundoN,SplashScreen.conexion))
            {
                this.coordX++;
                ControladorPersonajes.modificarCooPersonaje(VarGlobal.percodigo, this.coordX, this.coordY, SplashScreen.conexion);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool caminarArriba()
        {
            if (this.coordY != 0)
            {
                this.coordY--;
                ControladorPersonajes.modificarCooPersonaje(VarGlobal.percodigo, this.coordX, this.coordY, SplashScreen.conexion);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool caminarAbajo()
        {
            if (this.coordY != ControladorMundos.retYFin(this.MundoN, SplashScreen.conexion))
            {
                this.coordY++;
                ControladorPersonajes.modificarCooPersonaje(VarGlobal.percodigo, this.coordX, this.coordY, SplashScreen.conexion);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool estaEnCiudad()
        {
            int[] coordCiudad = ControladorMundos.retCoordCiudad(this.MundoN, SplashScreen.conexion);

            if (this.coordX > coordCiudad[0] && this.coordX < coordCiudad[2]
                && this.coordY > coordCiudad[1] && this.coordY < coordCiudad[3])
                return true;
            else
                return false;
        }

        public Bicho toparseConBicho(ArrayList bichos)
        {
            Bicho res = null;

            foreach(Bicho b in bichos)
            {
                if(b.CoordX == this.CoordX && b.CoordY == this.CoordY)
                {
                    res = b;
                }
            }

            return res;

        }

        public int ataqueComun()
        {
            return this.PuntosAtaque;
        }

        public int ataqueConArma(Arma xArma)
        {
            if (xArma.EsEscudo == false)
                return (this.PuntosAtaque + xArma.Ataque);
            else
                return 0;
        }

        public int ataqueConSkill()
        {
            return (this.PuntosAtaque + this.skillAsigned.Ataque);
        }

        public int tomarPocionVida(PocionVida xPocion)
        {
            return xPocion.Efectividad;
        }

        public int tomarPocionMana(PocionMana xPocion)
        {
            return xPocion.Efectividad;
        }

        public void cambiarSkill(Skill xSkill)
        {
            this.skillAsigned = xSkill;
        }
        public NPC toparseConNPC()
        {
            NPC res = null;

            ArrayList npcs = this.mundo.Npcs;
            foreach (NPC npc in npcs)
            {
                if (npc.CoordX == this.CoordX && npc.CoordY == this.CoordY)
                {
                    res = npc;
                }
            }

            return res;

        }

    }
}
