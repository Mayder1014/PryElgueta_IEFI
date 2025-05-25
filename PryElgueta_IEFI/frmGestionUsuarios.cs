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

        clsConexionBBDD conexion = new clsConexionBBDD();
        clsUsuarios lstUsuarios = new clsUsuarios();
        int i = 0;

        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {
            conexion.cargarListaUsuarios(lstUsuarios);

            habilitarAtrasYSiguiente();
            mostrarUsuario();
            habilitarDeshabilitarBotones();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            i++; //El indice se mueve al siguiente usuario en la lista.
            habilitarAtrasYSiguiente();
            mostrarUsuario();
            habilitarDeshabilitarBotones();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            i--; //El indice se mueve al anterior usuario en la lista.
            habilitarAtrasYSiguiente();
            mostrarUsuario();
            habilitarDeshabilitarBotones();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string evento = "Auditoria - Agregar Usuario";
            string descripcion;

            //*Hacer control de txt vacios*
            string nombreUsuario = txtNombreAgregar.Text;
            string contraseñaUsuario = txtContraseñaAgregar.Text;

            TimeSpan tiempoNuevo = TimeSpan.Zero;

            DialogResult resultado = MessageBox.Show("¿Está seguro que quiere agregar a este nuevo usuario?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                //El id del usuario dado por parametro es irrelevante. Dentro de agregarUsuario no lo toma en cuenta al ser incremental.
                clsUsuario usuarioNuevo = new clsUsuario(0, nombreUsuario, contraseñaUsuario, 0, DateTime.Now, DateTime.Now,
                    tiempoNuevo, tiempoNuevo, 1);

                conexion.agregarUsuario(usuarioNuevo);

                MessageBox.Show($"Usuario {nombreUsuario} añadido con exito.", "USUARIO EXITOSAMENTE AÑADIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexion.cargarListaUsuarios(lstUsuarios);

                habilitarAtrasYSiguiente(); //Si el usuario mostrado era el ultimo en la lista, se habilitará el botón de siguiente al existir otro.

                //Registrar evento en la tabla Auditoria.
                descripcion = $"El Administrador {clsUsuario.usuarioLogueado.usuario} añadió al usuario {nombreUsuario}.";

                clsRegistro registro = new clsRegistro(0, clsUsuario.usuarioLogueado.id, evento, DateTime.Now, descripcion);

                conexion.registrarEnAuditoria(registro);
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            string evento = "Auditoria - Modificar Usuario";
            string descripcion;

            var user = lstUsuarios.lstUsuarios[i];

            DialogResult resultado = MessageBox.Show($"Está a punto de modificar uno o más campos del usuario {user.usuario}.\n" +
                $"¿Quiere proceder con la operación?", "AVISO MODIFICACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                clsUsuario usuarioModificado = user;

                string nuevoNombre = "";
                string nuevaContraseña = "";
                int estado = -1;

                if (chkNuevoNombre.Checked)
                {
                    if (txtNombreModificar.Text != user.usuario)
                    {
                        nuevoNombre = txtNombreModificar.Text;
                        usuarioModificado.usuario = nuevoNombre;
                    }
                    else
                        MessageBox.Show("El nuevo nombre que intenta asignar es el mismo que ya tiene el usuario.", "ERROR NUEVO NOMBRE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (chkNuevaContraseña.Checked)
                {
                    if (txtContraseñaModificar.Text != user.contraseña)
                    {
                        nuevaContraseña = txtContraseñaModificar.Text;
                        usuarioModificado.contraseña = nuevaContraseña;
                    }
                    else
                        MessageBox.Show("La nueva contraseña que intenta asignar es la misma que ya tiene el usuario.", "ERROR NUEVA CONTRASEÑA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (chkEstadoUsuario.Checked)
                {
                    if (optActivo.Checked)
                        estado = 1;
                    else
                        estado = 0;

                    if (estado == user.activo)
                    {
                        MessageBox.Show("El nuevo estado del usuario que intenta asignar es el actual del mismo.", "ERROR NUEVO ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        estado = -1;
                    }
                    else
                    {
                        usuarioModificado.activo = estado;
                    }
                }

                //Si resulta que ninguno de los campos pudo modificarse, se notifica el error al usuario.
                if (nuevoNombre == "" && nuevaContraseña == "" && estado == -1)
                {
                    MessageBox.Show("No se ha podido modificar ningún campo del usuario. Revise nuevamente los datos ingresados e intentelo de nuevo."
                        , "ERROR MODIFICAR USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conexion.actualizarUsuario(usuarioModificado);

                    MessageBox.Show("Usuario modificado con exito. Si intentó modificar más de un campo y tuvo un error, verifique e intente modificar " +
                        "ese campo nuevamente.", "MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Vuelve a cargar y mostrar usuarios con las nuevas modificaciones.
                    conexion.cargarListaUsuarios(lstUsuarios);
                    mostrarUsuario();
                    habilitarDeshabilitarBotones();

                    //Registrar evento en tabla Auditoria.
                    descripcion = $"El Administrador {clsUsuario.usuarioLogueado.usuario} modificó al usuario {user.usuario}";

                    clsRegistro registro = new clsRegistro(0, clsUsuario.usuarioLogueado.id, evento, DateTime.Now, descripcion);

                    conexion.registrarEnAuditoria(registro);
                }
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string evento = "Auditoria - Eliminar Usuario";
            string descripcion;

            var user = lstUsuarios.lstUsuarios[i]; //Se obtienen los datos usuario en pantalla.

            if (user.permiso != 1) //Se pregunta por las dudas, en caso de estar habilitado el botón apesar de tratarse de un admin.
            {
                DialogResult resultado = MessageBox.Show($"Esta a punto de eliminar al usuario: {user.usuario}.\n" +
                    $"Si desea cancelar la operación, presione el botón {"Cancelar"}.\n" +
                    $"Si desea proceder con la operación, presione el botón {"Aceptar"}.",
                    "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultado == DialogResult.OK) //Se procede a hacer una doble confirmación...
                {
                    DialogResult confirmacion = MessageBox.Show($"Precaución: Esta acción es IRREVERSIBLE.\n" +
                    $"¿Está seguro que quiere eliminar al usuario {user.usuario}?", "CONFIRMACIÓN PARA ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.Yes)
                    {
                        //Eliminar al usuario.
                        conexion.eliminarUsuario(user.id);

                        MessageBox.Show($"El usuario {user.usuario} fue eliminado con exito.", "ELMINACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Registra el evento en la tabla Auditoria.
                        descripcion = $"El Administrador {clsUsuario.usuarioLogueado.usuario} eliminó al usuario {user.usuario}";

                        clsRegistro registro = new clsRegistro(0, clsUsuario.usuarioLogueado.id, evento, DateTime.Now, descripcion);

                        conexion.registrarEnAuditoria(registro);

                        //Vuelve a cargar la lista, sin el usuario que se acaba de borrar de la BBDD.
                        conexion.cargarListaUsuarios(lstUsuarios);

                        i--;
                        habilitarAtrasYSiguiente();
                        mostrarUsuario();
                        habilitarDeshabilitarBotones();
                    }
                }
            }
        }

        private void txtNombreModificar_TextChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBotones();
        }

        private void txtContraseñaModificar_TextChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBotones();
        }

        private void optActivo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBotones();
        }

        private void optInactivo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBotones();
        }

        private void chkNuevoNombre_CheckedChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBotones();
        }

        private void chkNuevaContraseña_CheckedChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBotones();
        }

        private void chkEstadoUsuario_CheckedChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBotones();
        }

        #region Metodos...

        public void habilitarAtrasYSiguiente()
        {
            if (i == 0)
            {
                btnAtras.Visible = false;
            }
            else if (i == lstUsuarios.lstUsuarios.Count - 1)
            {
                btnSiguiente.Visible = false;
            }
            else
            {
                btnAtras.Visible = true;
                btnSiguiente.Visible = true;
            }
        }

        public void mostrarUsuario()
        {
            var user = lstUsuarios.lstUsuarios[i];

            lblNombreUsuario.Text = user.usuario.ToUpper();

            imgUsuario.BackgroundImage = null;

            string estado;
            if (user.activo == 1)
                estado = "Activo";
            else
                estado = "Inactivo";

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

                if (clsUsuario.usuarioLogueado.id != user.id) //Si el administrador logueado es el que se muestra, puede ver su propia contraseña.
                    contraseña = new string(vecDigitos);

                imgUsuario.BackgroundImage = Properties.Resources.administrador;
                lblMostrarDatosDelUsuario.Text = $"{permiso}\r\n\r\n" +
                    $"{contraseña}\r\n\r\n" +
                    $"{user.fechaCreacion}\r\n\r\n" +
                    $"{user.ultimaConexion}\r\n\r\n" +
                    $"{user.tiempoTrabajoTotal}\r\n\r\n" +
                    $"{estado}";
            }
            else
            {
                permiso = "Operador";

                imgUsuario.BackgroundImage = Properties.Resources.operador;
                lblMostrarDatosDelUsuario.Text = $"{permiso}\r\n\r\n" +
                    $"{contraseña}\r\n\r\n" +
                    $"{user.fechaCreacion}\r\n\r\n" +
                    $"{user.ultimaConexion}\r\n\r\n" +
                    $"{user.tiempoTrabajoTotal}\r\n\r\n" +
                    $"{estado}";
            }
        }

        public void habilitarDeshabilitarBotones()
        {
            var user = lstUsuarios.lstUsuarios[i];

            //Habilitar o deshabilitar textBoxes/radioButtons
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
                optActivo.Enabled = true; optInactivo.Enabled = true;
            }
            else
            {
                optActivo.Enabled = false; optInactivo.Enabled = false;
                optActivo.Checked = false; optInactivo.Checked = false;
            }

            //Habilitar o deshabilitar botones
            if (user.permiso == 1)
            {
                btnEliminarUsuario.Enabled = false;
            }
            else
            {
                btnEliminarUsuario.Enabled = true;
            }

            if (txtNombreModificar.Text != "" || txtContraseñaModificar.Text != "" || optActivo.Checked != false || optInactivo.Checked != false)
            {
                btnModificarUsuario.Enabled = true;

                //Pregunta si el usuario mostrado es administrador, si lo es, pregunta si es el administrador logueado
                if (user.permiso == 1)
                {
                    if (user.id == clsUsuario.usuarioLogueado.id)
                        btnModificarUsuario.Enabled = true;
                    else
                        btnModificarUsuario.Enabled = false;
                }
            }
            else
            {
                btnModificarUsuario.Enabled = false;
            }
        }

        #endregion
    }
}
