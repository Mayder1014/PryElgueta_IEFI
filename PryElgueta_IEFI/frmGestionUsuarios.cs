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
    public partial class frmGestionUsuarios : Form
    {
        public frmGestionUsuarios()
        {
            InitializeComponent();
        }

        static public int i = 0;
        static public string operacion;
        static public Panel PanelContenedor;
        static public Label lblMostrarUsuarioSelect;

        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {
            clsUsuario.usuarioSeleccionado = null;

            PanelContenedor = panelContenedor;
            lblMostrarUsuarioSelect = lblMostrarUsuarioSeleccionado;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {

            frmAgregarModificarUsuario v = new frmAgregarModificarUsuario();
            operacion = "Agregar";
            abrirFormulario(v);
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            frmSeleccionarUsuario v = new frmSeleccionarUsuario();
            operacion = "Modificar";
            abrirFormulario(v);
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            frmSeleccionarUsuario v = new frmSeleccionarUsuario();
            operacion = "Eliminar";
            abrirFormulario(v);
        }

        #region Metodos...

        /*
        public void habilitarDeshabilitarBotones()
        {
            var user = lstUsuarios.lstUsuarios[i];

            //Habilitar o deshabilitar textBox y botón Agregar Usuario
            if (txtNombreAgregar.Text == "" || string.IsNullOrWhiteSpace(txtNombreAgregar.Text))
            {
                txtContraseñaAgregar.Enabled = false; txtContraseñaAgregar.BackColor = Color.Gray;
                btnAgregarUsuario.Enabled = false;
            }
            else
            {
                txtContraseñaAgregar.Enabled = true; txtContraseñaAgregar.BackColor = SystemColors.Control;
                if (txtContraseñaAgregar.Text == "" || string.IsNullOrWhiteSpace(txtContraseñaAgregar.Text))
                    btnAgregarUsuario.Enabled = false;
                else
                    btnAgregarUsuario.Enabled = true;
            }

            //Habilitar o deshabilitar textBoxes/radioButtons y botón Modificar Usuario
            if (chkNuevoNombre.Checked)
                txtNombreModificar.Enabled = true;
            else
            {
                txtNombreModificar.Enabled = false; txtNombreModificar.Text = "";
            }

            if (chkNuevaContraseña.Checked)
                txtContraseñaModificar.Enabled = true;
            else
            {
                txtContraseñaModificar.Enabled = false; txtContraseñaModificar.Text = "";
            }

            if (chkEstadoUsuario.Checked)
            {
                if (clsUsuario.usuarioLogueado.id != user.id)
                {
                    optActivo.Enabled = true; optInactivo.Enabled = true;
                }
            }
            else
            {
                optActivo.Enabled = false; optInactivo.Enabled = false;
                optActivo.Checked = false; optInactivo.Checked = false;
            }

            //Habilitar o deshabilitar botones
            if (user.permiso == 1)
            {
                btnSeleccionarUsuario.Enabled = false;
            }
            else
            {
                btnSeleccionarUsuario.Enabled = true;
            }

            if (txtNombreModificar.Text != "" || txtContraseñaModificar.Text != "" || optActivo.Checked != false || optInactivo.Checked != false)
            {
                btnSeleccionarUsuario.Enabled = true;

                //Pregunta si el usuario mostrado es administrador, si lo es, pregunta si es el administrador logueado
                if (user.permiso == 1)
                {
                    if (user.id == clsUsuario.usuarioLogueado.id)
                        btnSeleccionarUsuario.Enabled = true;
                    else
                        btnSeleccionarUsuario.Enabled = false;
                }
            }
            else
            {
                btnSeleccionarUsuario.Enabled = false;
            }
        }

        public void cambiarColorDeBoton()
        {
            //Agregar -----------------------------------------------
            if (btnAgregarUsuario.Enabled != true)
                btnAgregarUsuario.BackColor = Color.Gray;
            else
                btnAgregarUsuario.BackColor = Color.MediumSeaGreen;

            //Modificar ---------------------------------------------
            if (btnSeleccionarUsuario.Enabled != true)
                btnSeleccionarUsuario.BackColor = Color.Gray;
            else
                btnSeleccionarUsuario.BackColor = Color.SteelBlue;

            //Eliminar ----------------------------------------------
            if (btnSeleccionarUsuario.Enabled != true)
                btnSeleccionarUsuario.BackColor = Color.Gray;
            else
                btnSeleccionarUsuario.BackColor = Color.IndianRed;
        }
        */

        #endregion


        //Este metodo abrira el formulario para agregar y/o modificar usuario.
        private Form formActivo = null;
        private void abrirFormulario(Form formulario)
        {
            if (formActivo != null) //Si exite un formulario activo, se cierra
            {
                formActivo.Close();
            }
            formActivo = formulario; //Se almacena el formulario activo
            formulario.TopLevel = false; //Indica que el formulario no es de nivel superior
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formulario);
            panelContenedor.Tag = formulario; //Asocia el form con el panel "contenedor"
            formulario.BringToFront();
            formulario.Show();
        }

    }
}
