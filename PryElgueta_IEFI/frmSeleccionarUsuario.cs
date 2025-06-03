using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryElgueta_IEFI
{
    public partial class frmSeleccionarUsuario : Form
    {
        public frmSeleccionarUsuario()
        {
            InitializeComponent();
        }

        clsConexionBBDD conexion = new clsConexionBBDD();
        clsUsuarios lstUsuarios = new clsUsuarios();
        string operacion = "";
        string evento = "";
        int i = 0;

        private void frmSeleccionarUsuario_Load(object sender, EventArgs e)
        {
            operacion = frmGestionUsuarios.operacion;
            frmGestionUsuarios.lblMostrarUsuarioSelect.Text = "- - - -";

            conexion.cargarListaUsuarios(lstUsuarios);

            if (operacion == "Eliminar")
            {
                btnSeleccionarUsuario.Text = "Eliminar Usuario";
                btnSeleccionarUsuario.BackColor = Color.IndianRed;
                evento = "Gestión de Usuarios - Eliminar Usuario";
            }

            habilitarAtrasYSiguiente();
            mostrarUsuario();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            i--;
            habilitarAtrasYSiguiente();
            mostrarUsuario();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            i++;
            habilitarAtrasYSiguiente();
            mostrarUsuario();
        }

        private void btnSeleccionarUsuario_Click(object sender, EventArgs e)
        {
            string descripcion;

            var user = lstUsuarios.lstUsuarios[i]; //Se obtienen los datos usuario en pantalla.

            if (operacion == "Eliminar")
            {
                DialogResult resultado = MessageBox.Show($"Esta a punto de eliminar al usuario: {user.nombreUsuario}.\n" +
                    $"Si desea cancelar la operación, presione el botón {"Cancelar"}.\n" +
                    $"Si desea proceder con la operación, presione el botón {"Aceptar"}.",
                    "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultado == DialogResult.OK) //Se procede a hacer una doble confirmación...
                {
                    DialogResult confirmacion = MessageBox.Show($"Precaución: Esta acción es IRREVERSIBLE.\n" +
                    $"¿Está seguro que quiere eliminar al usuario {user.nombreUsuario}?", "CONFIRMACIÓN PARA ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.Yes)
                    {
                        //Eliminar al usuario.
                        conexion.eliminarUsuario(user.id);

                        MessageBox.Show($"El usuario {user.nombreUsuario} fue eliminado con exito.", "ELMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Registra el evento en la tabla Auditoria.
                        descripcion = $"El Administrador {clsUsuario.usuarioLogueado.nombreUsuario} eliminó al usuario {user.nombreUsuario}";

                        clsRegistro registro = new clsRegistro(0, clsUsuario.usuarioLogueado.id, evento, DateTime.Now, descripcion);

                        conexion.registrarEnAuditoria(registro);

                        //Vuelve a cargar la lista, sin el usuario que se acaba de borrar de la BBDD.
                        conexion.cargarListaUsuarios(lstUsuarios);

                        i--;
                        habilitarAtrasYSiguiente();
                        mostrarUsuario();
                        //habilitarDeshabilitarBotones();
                    }
                }

            }
            else //En caso de tratarse de una modificación
            {
                var usuario = lstUsuarios.lstUsuarios[i];
                clsUsuario.usuarioSeleccionado = usuario;
                frmGestionUsuarios.lblMostrarUsuarioSelect.Text = usuario.nombreUsuario;

                frmAgregarModificarUsuario v = new frmAgregarModificarUsuario();
                operacion = "Modificar";
                abrirFormulario(v);
            }
        }

        public void habilitarAtrasYSiguiente()
        {
            if (i == 0)
            {
                btnAtras.Visible = false; lblAnteriorUsuario.Visible = false;
            }
            else if (i == lstUsuarios.lstUsuarios.Count - 1)
            {
                btnSiguiente.Visible = false; lblSiguienteUsuario.Visible = false;
            }
            else
            {
                btnAtras.Visible = true; lblAnteriorUsuario.Visible = true;
                btnSiguiente.Visible = true; lblSiguienteUsuario.Visible = true;
            }
        }

        public void mostrarUsuario()
        {
            var user = lstUsuarios.lstUsuarios[i];

            lblNombreUsuario.Text = user.nombreUsuario.ToUpper();

            imgUsuario.BackgroundImage = null;

            string permiso;
            string contraseña = user.contraseña;

            //Se utiliza un vector de caracteres en caso de ser necesario mostrar la contraseña en digitos.
            int digitos = contraseña.Count();

            char[] vecDigitos = new char[digitos];
            for (int i = 0; i < vecDigitos.Length; i++)
            {
                vecDigitos[i] = 'x';
            }

            if (user.permiso == 1)
            {
                permiso = "Administrador";
                btnSeleccionarUsuario.Enabled = false;btnSeleccionarUsuario.BackColor = Color.Gray;

                if (clsUsuario.usuarioLogueado.id != user.id)
                {
                    contraseña = new string(vecDigitos); //Contraseña "oculta".
                }
                else
                {
                    //Si el administrador logueado es el que se muestra, puede ver su propia contraseña, asi como tambien podra modificarse.
                    if (operacion == "Modificar")
                    {
                        btnSeleccionarUsuario.Enabled = true; btnSeleccionarUsuario.BackColor = Color.FromArgb(29, 180, 98);
                    }
                }

                imgUsuario.BackgroundImage = Properties.Resources.administrador;
                lblMostrarDatosDelUsuario.Text = $"{user.nombre} {user.apellido}\r\n\r\n" +
                    $"{user.DNI}\r\n\r\n" +
                    $"{user.edad}\r\n\r\n" +
                    $"{permiso}\r\n\r\n" +
                    $"{user.email}\r\n\r\n" +
                    $"{user.telefono}\r\n\r\n" +
                    $"{contraseña}\r\n\r\n";
                lblMostrarActividadUsuario.Text = $"{user.fechaCreacion}\r\n\r\n" +
                    $"{user.ultimaConexion}\r\n\r\n" +
                    $"{user.tiempoTrabajoTotal}\r\n\r\n";
            }
            else
            {
                permiso = "Operador";

                //Cambiar color del botón
                btnSeleccionarUsuario.Enabled = true;
                if (operacion == "Modificar")
                    btnSeleccionarUsuario.BackColor = Color.FromArgb(29, 180, 98);
                else
                    btnSeleccionarUsuario.BackColor = Color.IndianRed;

                imgUsuario.BackgroundImage = Properties.Resources.operador;
                lblMostrarDatosDelUsuario.Text = $"{user.nombre} {user.apellido}\r\n\r\n" +
                    $"{user.DNI}\r\n\r\n" +
                    $"{user.edad}\r\n\r\n" +
                    $"{permiso}\r\n\r\n" +
                    $"{user.email}\r\n\r\n" +
                    $"{user.telefono}\r\n\r\n" +
                    $"{contraseña}\r\n\r\n";
                lblMostrarActividadUsuario.Text = $"{user.fechaCreacion}\r\n\r\n" +
                    $"{user.ultimaConexion}\r\n\r\n" +
                    $"{user.tiempoTrabajoTotal}\r\n\r\n";
            }
        }

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
            frmGestionUsuarios.PanelContenedor.Controls.Add(formulario);
            frmGestionUsuarios.PanelContenedor.Tag = formulario; //Asocia el form con el panel "contenedor"
            formulario.BringToFront();
            formulario.Show();
        }


    }
}
