using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryElgueta_IEFI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        clsConexionBBDD conexion = new clsConexionBBDD();
        clsUsuarios lstUsuarios = new clsUsuarios();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;

            conexion.cargarLista(lstUsuarios);
        }

        private void btnMostrarOcultar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar != true)
            {
                txtContraseña.UseSystemPasswordChar = true;
                btnMostrarOcultar.Image = Properties.Resources.show;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = false;
                btnMostrarOcultar.Image = Properties.Resources.hide;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nom = txtUsuario.Text;
            string contra = txtContraseña.Text;

            clsUsuario.usuarioLogueado = lstUsuarios.loginDeUsuario(nom, contra);

            if (clsUsuario.usuarioLogueado != null)
            {
                MessageBox.Show($"¡Bienvenido {clsUsuario.usuarioLogueado.usuario}!", "LOGIN EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clsUsuario.usuarioLogueado.fechaActualConexion = DateTime.Now;
                
                frmPrincipal.formPrincipal.Show();
                frmPrincipal.timerS.Enabled = true;
                frmPrincipal.mostrarUsuario.Text = clsUsuario.usuarioLogueado.usuario.ToString();
                frmPrincipal.mostrarFecha.Text = clsUsuario.usuarioLogueado.fechaActualConexion.ToString();

                this.Close();

                //frmPrincipal.timerS.Enabled = true;
                /*abrir frmPrincipal
                frmPrincipal v = new frmPrincipal();
                v.Show();*/
            }
        }

        #region Cerrar frmLogin -> Termina ejecución del programa
        //Como se supone que frmLogin es "el primer formulario que se abre", el programa debería dejar de ejecutarse cuando el usuario
        //decide cerrar este mismo. En este caso, realmente el primer formulario es frmPrincipal, por lo que se procede a cerrar ese
        //para detener la ejecución por completo del programa.

        //Al momento de querer cerrar frmLogin sin loguearse, automaticamente se abre/muestra frmPrincipal, para evitarlo,
        //se invoca este evento y se asegura de que antes de cerrar frmLogin, se cierre primero frmPrincipal.
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmPrincipal.formPrincipal.Visible != true)
            {
                frmPrincipal.formPrincipal.Close();
            }
        }
        #endregion
    }
}
