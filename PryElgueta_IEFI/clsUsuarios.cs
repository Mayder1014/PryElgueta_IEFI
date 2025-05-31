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
            bool existe = false;

            var user = lstUsuarios.Find(elem => elem.usuario.Equals(usuario) && elem.contraseña.Equals(contraseña));

            if (user != null) existe = true;

            if (existe != false)
            {
                if (user.activo != 0)
                {
                    return user;
                }
                else
                {
                    MessageBox.Show("El Usuario se encuentra actualmente en estado Inactivo y no puede loguearse en el programa.\n" +
                        "Comuníquese con un Administrador para cambiar su estado a Activo nuevamente.", "USUARIO INACTIVO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectas.", "ERROR DE LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null; //Retorna null en caso de no encontrar al usuario.
        }

    }
}
