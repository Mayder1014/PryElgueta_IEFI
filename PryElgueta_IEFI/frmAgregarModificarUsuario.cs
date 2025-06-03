using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PryElgueta_IEFI
{
    public partial class frmAgregarModificarUsuario : Form
    {
        public frmAgregarModificarUsuario()
        {
            InitializeComponent();
        }

        string operacion;
        string evento = "";
        clsConexionBBDD conexion = new clsConexionBBDD();

        private void frmAgregarModificarUsuario_Load(object sender, EventArgs e)
        {
            operacion = frmGestionUsuarios.operacion;

            updEdad.Minimum = 18;

            Control[] campos = new Control[] { txtNombreUsuario, txtContraseña, txtNombre, txtApellido, updEdad, txtDNI, txtTelefono, txtEmail };

            if (operacion == "Agregar")
            {
                btnAgregarModificar.Text = "Agregar nuevo Usuario"; btnAgregarModificar.BackColor = Color.MediumSeaGreen;
                evento = "Gestión de Usuarios - Agregar Usuario";
                clsUsuario.usuarioSeleccionado = null;
                frmGestionUsuarios.lblMostrarUsuarioSelect.Text = "- - - -";

                //Habilitar todos los campos (Por defecto deshabilitados debido a como inicia con la operación de Modificar).
                foreach (Control campo in campos)
                {
                    campo.Enabled = true;
                }
                habilitarDeshabilitarBoton();
            }
            else
            {
                btnAgregarModificar.Text = "Enviar modificaciones"; btnAgregarModificar.BackColor = Color.SteelBlue;
                evento = "Gestión de Usuarios - Modificar Usuario";
                mostrarOpcionesDeModificacion();
                cambiarColorCampos();
                habilitarDeshabilitarCampos();
            }

        }

        private void btnAgregarModificar_Click(object sender, EventArgs e)
        {
            string descripcion;

            string nombreUsuario = txtNombreUsuario.Text; string contraseña = txtContraseña.Text;
            string nombre = txtNombre.Text; string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(updEdad.Value); string dni = txtDNI.Text;
            string telefono = txtTelefono.Text; string email = txtEmail.Text;

            if (operacion == "Agregar") //Actuará como botón para agregar un nuevo usuario
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que quiere agregar a este nuevo usuario?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    //El id del usuario dado por parametro es irrelevante. Dentro de agregarUsuario no lo toma en cuenta al ser incremental.
                    clsUsuario usuarioNuevo = new clsUsuario(0, nombreUsuario, contraseña, 0, nombre, apellido, edad, dni, telefono, email,
                                                             DateTime.Now, DateTime.Now, TimeSpan.Zero, TimeSpan.Zero);

                    conexion.agregarUsuario(usuarioNuevo);

                    MessageBox.Show($"Usuario {nombreUsuario} añadido con exito.", "USUARIO EXITOSAMENTE AÑADIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Registrar evento en la tabla Auditoria.
                    descripcion = $"El Administrador {clsUsuario.usuarioLogueado.nombreUsuario} añadió al usuario {nombreUsuario}.";

                    clsRegistro registro = new clsRegistro(0, clsUsuario.usuarioLogueado.id, evento, DateTime.Now, descripcion);

                    conexion.registrarEnAuditoria(registro);
                }


            }
            else //Actuará como botón para enviar modificaciones
            {
                DialogResult resultado = MessageBox.Show($"Está a punto de modificar uno o más campos del usuario {clsUsuario.usuarioSeleccionado.nombreUsuario}.\n" +
                $"¿Quiere proceder con la operación?", "AVISO MODIFICACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    clsUsuario usuarioModificado = clsUsuario.usuarioSeleccionado; //Obtiene por defecto todos los valores de ese usuario.

                    //Se le asignan los "nuevos" valores (Que se permiten modificar).
                    usuarioModificado.nombreUsuario = nombreUsuario; usuarioModificado.contraseña = contraseña;
                    usuarioModificado.nombre = nombre; usuarioModificado.apellido = apellido; usuarioModificado.edad = edad;
                    usuarioModificado.DNI = dni; usuarioModificado.telefono = telefono; usuarioModificado.email = email;


                    conexion.actualizarUsuario(usuarioModificado);

                    MessageBox.Show($"Usuario {clsUsuario.usuarioSeleccionado.nombreUsuario} modificado con exito.", "MODIFICACIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Registrar evento en tabla Auditoria.
                    descripcion = $"El Administrador {clsUsuario.usuarioLogueado.nombreUsuario} modificó al usuario {clsUsuario.usuarioSeleccionado.nombreUsuario}";

                    clsRegistro registro = new clsRegistro(0, clsUsuario.usuarioLogueado.id, evento, DateTime.Now, descripcion);

                    conexion.registrarEnAuditoria(registro);

                }


            }

        }

        #region Otros eventos...

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBoton();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBoton();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBoton();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBoton();
        }

        private void updEdad_ValueChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBoton();
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBoton();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBoton();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBoton();
        }


        private void chkNombreUsuario_CheckedChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarCampos();
            cambiarColorCampos();
        }

        private void chkContraseña_CheckedChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarCampos();
            cambiarColorCampos();
        }

        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarCampos();
            cambiarColorCampos();
        }

        private void chkApellido_CheckedChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarCampos();
            cambiarColorCampos();
        }

        private void chkEdad_CheckedChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarCampos();
            cambiarColorCampos();
        }

        private void chkDNI_CheckedChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarCampos();
            cambiarColorCampos();
        }

        private void chkTelefono_CheckedChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarCampos();
            cambiarColorCampos();
        }

        private void chkEmail_CheckedChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarCampos();
            cambiarColorCampos();
        }

        //Controla para que el usuario solo pueda ingresar números.
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Metodos...

        public void mostrarOpcionesDeModificacion()
        {
            lblCamposAModificar.Visible = true;
            System.Windows.Forms.CheckBox[] checkBoxes = new System.Windows.Forms.CheckBox[] {
                                                    chkNombreUsuario, chkContraseña, chkNombre, chkApellido,
                                                    chkEdad, chkDNI, chkTelefono, chkEmail};
            foreach (System.Windows.Forms.CheckBox chk in checkBoxes) 
            {
                chk.Visible = true;
            }
        }

        public void cambiarColorCampos()
        {
            Control[] campos = new Control[] {txtNombreUsuario, txtContraseña, txtNombre, txtApellido, updEdad, txtDNI, txtTelefono ,txtEmail};
            
            foreach (Control campo in campos)
            {
                if (!campo.Enabled)
                campo.BackColor = SystemColors.ScrollBar;
            }
        }

        public void habilitarDeshabilitarCampos()
        {
            if (chkNombreUsuario.Checked)
            {
                txtNombreUsuario.Enabled = true;
            }
            else
            {
                txtNombreUsuario.Enabled = false; txtNombreUsuario.Text = clsUsuario.usuarioSeleccionado.nombreUsuario;
            }

            if (chkContraseña.Checked)
            {
                txtContraseña.Enabled = true;
            }
            else
            {
                txtContraseña.Enabled = false; txtContraseña.Text = clsUsuario.usuarioSeleccionado.contraseña;
            }

            if (chkNombre.Checked)
            {
                txtNombre.Enabled = true;
            }
            else
            {
                txtNombre.Enabled = false; txtNombre.Text = clsUsuario.usuarioSeleccionado.nombre;
            }

            if (chkApellido.Checked)
            {
                txtApellido.Enabled = true;
            }
            else
            {
                txtApellido.Enabled = false; txtApellido.Text = clsUsuario.usuarioSeleccionado.apellido;
            }

            if (chkEdad.Checked)
            {
                updEdad.Enabled = true;
            }
            else
            {
                updEdad.Enabled = false; updEdad.Value = clsUsuario.usuarioSeleccionado.edad;
            }

            if (chkDNI.Checked)
            {
                txtDNI.Enabled = true;
            }
            else
            {
                txtDNI.Enabled = false; txtDNI.Text = clsUsuario.usuarioSeleccionado.DNI;
            }

            if (chkTelefono.Checked)
            {
                txtTelefono.Enabled = true;
            }
            else
            {
                txtTelefono.Enabled = false; txtTelefono.Text = clsUsuario.usuarioSeleccionado.telefono;
            }

            if (chkEmail.Checked)
            {
                txtEmail.Enabled = true;
            }
            else
            {
                txtEmail.Enabled = false; txtEmail.Text = clsUsuario.usuarioSeleccionado.email;
            }
        }

        public void habilitarDeshabilitarBoton()
        {
            bool habilitar;

            if (operacion != "Agregar")
                habilitar = verificarModificaciones();
            else
                habilitar = verificarCamposAgregar();

            btnAgregarModificar.Enabled = habilitar;

            //Cambio de color del botón
            if (operacion != "Agregar")
            {
                if (btnAgregarModificar.Enabled != true)
                    btnAgregarModificar.BackColor = Color.Gray;
                else
                    btnAgregarModificar.BackColor = Color.SteelBlue;
            }
            else
            {
                if (btnAgregarModificar.Enabled != true)
                    btnAgregarModificar.BackColor = Color.Gray;
                else
                    btnAgregarModificar.BackColor = Color.MediumSeaGreen;
            }
        }

        public bool verificarCamposAgregar()
        {
            bool verificacion = true;

            Control[] campos = new Control[] { txtNombreUsuario, txtContraseña, txtNombre, txtApellido, updEdad, txtDNI, txtTelefono, txtEmail };

            //Si existe al menos un campo vacio retorna directamente el booleano falso.
            foreach (Control campo in campos)
            {
                if (campo.Text == "" || campo.Text == "0")
                {
                    verificacion = false;

                    return verificacion;
                }
            }
            
            return verificacion;
        }

        //Verifica si el usuario no ha clickeado en ningún checkbox o tiene algún campo vacio
        public bool verificarModificaciones()
        {
            bool verificacion = false;

            Control[] campos = new Control[] { txtNombreUsuario, txtContraseña, txtNombre, txtApellido, updEdad, txtDNI, txtTelefono, txtEmail };

            //Primera verificación -> campos/controles habilitados.
            foreach (Control campo in campos)
            {
                if (campo.Enabled)
                    verificacion = true;
            }
            //Si de la primera verificación el booleano nunca cambió (es decir, quedó en falso), ignora la segunda verificación.
            if (verificacion == true)
            {
                //Segunda verificación -> campos vacios (Si existe al menos uno, directamente retorna el booleano falso.
                foreach (Control campo in campos)
                {
                    if (campo.Text == "" || campo.Text == "18")
                    {
                        verificacion = false;

                        return verificacion;
                    }
                }
            }

            return verificacion;
        }

        #endregion
    }
}
