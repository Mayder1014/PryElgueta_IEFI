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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //1. Se instancian variables estaticas que permitiran su uso en otros formularios.
        static public Form formPrincipal;
        static public Timer timerS;
        static public ToolStripStatusLabel mostrarUsuario;
        static public Label mostrarFecha;

        clsConexionBBDD conexion = new clsConexionBBDD();
        clsUsuarios lstUsuarios = new clsUsuarios();

        public static DateTime inicioSesion; // Guarda el momento exacto del login
        private TimeSpan tiempoAcumulado; // Acumula el tiempo total de sesión

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            conexion.cargarListaUsuarios(lstUsuarios);
            
            #region Mostrar al usuario frmLogin antes que frmPrincipal
            //2. Se termina de instanciar la variable para que se pueda manipular el frmPrincipal dentro de frmLogin.
            formPrincipal = this;
            formPrincipal.Hide(); //3. Se oculta el frmPrincipal.

            //4. Se termina de instanciar la variable para manipular el timerSesion (Se habilitará dentro de frmLogin una vez logueado.)
            timerS = timerSesion;
            timerSesion.Enabled = false;

            //5. Se termina de instanciar las variables para manipular el estado del usuario desde frmLogin.
            mostrarUsuario = lblMostrarUsuario;
            mostrarFecha = lblMostrarFecha;

            //6. Abre el frmLogin. Dando la ilusión de que el primer form que se abre es este antes que frmPrincipal.
            frmLogin v = new frmLogin();
            v.ShowDialog();
            #endregion

            formPrincipal.WindowState = FormWindowState.Maximized;
        }

        private void timerSesion_Tick(object sender, EventArgs e)
        {
            // Calcula el tiempo transcurrido exacto
            tiempoAcumulado = DateTime.Now - inicioSesion;

            // Muestra el tiempo formateado
            mostrarTiempoSesion.Text = $"Tiempo en Sesión: {tiempoAcumulado.ToString(@"hh\:mm\:ss")}";
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Si el permiso del usuario logueado es 1, es administrador, de lo contrario es operador y se le niega el acceso.
            if (clsUsuario.usuarioLogueado.permiso == 1)
            {
                //Registrar evento en Auditoria
                string tipoEvento = "Administración - Usuarios";

                clsRegistro registro = new clsRegistro(0, clsUsuario.usuarioLogueado.id, tipoEvento, DateTime.Now, "");

                conexion.registrarEnAuditoria(registro);

                //Abrir frmGestionUsuarios
                frmGestionUsuarios v = new frmGestionUsuarios();
                v.ShowDialog();
            } else
            {
                MessageBox.Show("No tiene permiso para acceder a esta sección.", "ACCESO DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Registrar evento en Auditoria
            string tipoEvento = "Administración - Auditoria";

            clsRegistro registro = new clsRegistro(0, clsUsuario.usuarioLogueado.id, tipoEvento, DateTime.Now, "");

            conexion.registrarEnAuditoria(registro);

            //Abrir frmAuditoria
            frmAuditoria v = new frmAuditoria();
            v.ShowDialog();
        }

        #region Logout de usuario...

        //Hay 3 ocasiones donde la información del usuario será actualizada y se registrará en auditoria:
        //1. Al cerrar la ventana frmPrincipal. | 2. Al presionar Cerrar sesión. | 3. Al presionar Salir del programa.
        public void logoutDeUsuario()
        {
            if (clsUsuario.usuarioLogueado != null)
            {
                string evento = "Logout";
                timerSesion.Enabled = false;

                //Obtener el tiempo final exacto
                TimeSpan tiempoTotalTrabajado = DateTime.Now - inicioSesion;

                clsUsuario.usuarioLogueado.ultimaConexion = DateTime.Now;
                clsUsuario.usuarioLogueado.tiempoTrabajoTotal = clsUsuario.usuarioLogueado.tiempoTrabajoTotal + tiempoTotalTrabajado;
                clsUsuario.usuarioLogueado.ultimoTiempoTrabajo = tiempoAcumulado;

                clsRegistro registro = new clsRegistro(0, clsUsuario.usuarioLogueado.id, evento, DateTime.Now, "Descripcion");

                //Actualizar en BBDD
                conexion.actualizarUsuario(clsUsuario.usuarioLogueado);
                conexion.registrarEnAuditoria(registro);
                clsUsuario.usuarioLogueado = null;
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clsUsuario.usuarioLogueado != null)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que quiere salir del programa?\n (Se cerrará la sesión automaticamente)",
                    "CONFIRMAR SALIDA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    logoutDeUsuario();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que quiere cerrar sesión?\n (Será redireccionado a la ventana de Login)",
               "CERRAR SESIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                logoutDeUsuario();
                this.Hide();
                frmLogin v = new frmLogin();
                v.ShowDialog();
            }
        }

        private void salirDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que quiere salir del programa?\n (Se cerrará la sesión automaticamente)",
                "CONFIRMAR SALIDA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                logoutDeUsuario();
                this.Close();
            }
        }
        #endregion

    }
}
