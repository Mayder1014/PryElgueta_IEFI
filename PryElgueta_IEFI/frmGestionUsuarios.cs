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

        #region Eventos - btnVolver, Agregar, Modificar, Eliminar Usuario.

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

        #endregion

        #region Metodos...

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

        #endregion

    }
}
