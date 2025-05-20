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
            var existe = lstUsuarios.Find(elem => elem.usuario.Equals(usuario) && elem.contraseña.Equals(contraseña));
            
            if (existe != null)
            {
                return existe;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectas.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null; //Retorna null en caso de no encontrar al usuario.
        }

    }
}
