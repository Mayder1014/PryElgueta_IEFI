using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryElgueta_IEFI
{
    internal class clsUsuarios
    {
        public List<clsUsuario> lstUsuarios {  get; set; }

        public clsUsuarios()
        {
            lstUsuarios = new List<clsUsuario>();
        }

        public clsUsuario loginDeUsuario(string usuario, string contraseña)
        {
            var user = lstUsuarios.Find(elem => elem.nombreUsuario.Equals(usuario) && elem.contraseña.Equals(contraseña));

            if (user != null)
            {
                return user;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectas.", "ERROR DE LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null; //Retorna null en caso de no encontrar al usuario.
        }

    }
}
