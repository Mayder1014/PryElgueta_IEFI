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
            

            conexion.cargarListaUsuarios(lstUsuarios);
        }

        private void btnMostrarOcultar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar != true)
            {
                txtContraseña.UseSystemPasswordChar = true;
                btnMostrarOcultar.Image = Properties.Resources.showWhite;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = false;
                btnMostrarOcultar.Image = Properties.Resources.hideWhite;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nom = txtUsuario.Text;
            string contra = txtContraseña.Text;

            clsUsuario.usuarioLogueado = lstUsuarios.loginDeUsuario(nom, contra);

            if (clsUsuario.usuarioLogueado != null)
            {
                MessageBox.Show($"¡Bienvenido {clsUsuario.usuarioLogueado.nombreUsuario}!", "LOGIN EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string evento = "Login"; //Tipo de evento a registrar

                frmPrincipal.formPrincipal.Show();

                //Si el usuario logueado es operador, se le ocultará el menu de Administración, Auditoria y Usuarios.
                if (clsUsuario.usuarioLogueado.permiso == 0)
                    frmPrincipal.administracionMenu.Visible = false;
                else
                    frmPrincipal.administracionMenu.Visible = true;

                frmPrincipal.timerS.Enabled = true;
                frmPrincipal.inicioSesion = DateTime.Now;
                frmPrincipal.mostrarUsuario.Text = clsUsuario.usuarioLogueado.nombreUsuario.ToString();
                frmPrincipal.mostrarFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");

                clsRegistro registro = new clsRegistro(0, clsUsuario.usuarioLogueado.id, evento, DateTime.Now, "Descripcion");

                conexion.registrarEnAuditoria(registro); //Se registra el evento en Auditoria.

                this.Close();
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
            if (clsUsuario.usuarioLogueado == null)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que quiere salir del programa?",
                        "CONFIRMAR SALIDA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    if (frmPrincipal.formPrincipal.Visible != true)
                    {
                        frmPrincipal.formPrincipal.Close();
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

    }
}
