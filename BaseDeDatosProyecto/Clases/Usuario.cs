using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosProyecto.Clases
{
    class Usuario
    {
        string nombreUsuario;
        string pass;
        string nombre;
        string mail;

        public string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }

            set
            {
                nombreUsuario = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
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

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        public Usuario(string xNombreUsuario, string xPass, string xNombre, string xMail)
        {
            this.NombreUsuario = xNombreUsuario;
            this.Pass = xPass;
            this.Nombre = xNombre;
            this.Mail = xMail;
        }
    }
}
