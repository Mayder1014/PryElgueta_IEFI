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
    public partial class frmHistorialTareas : Form
    {
        public frmHistorialTareas()
        {
            InitializeComponent();
        }

        clsConexionBBDD conexion = new clsConexionBBDD();
        clsUsuarios lstUsuarios = new clsUsuarios();
        List<clsTarea> lstTareas = new List<clsTarea>();

        Control controlEnPantalla;

        private void frmHistorialTareas_Load(object sender, EventArgs e)
        {
            conexion.cargarListaUsuarios(lstUsuarios);
            conexion.cargarListaTareas(lstTareas);

            dtpFecha.Value = DateTime.Now;
            controlEnPantalla = cmbSeleccionarDato;

            añadirColumnas(dgvMostrar);

            habilitarControlesBusquedaEspecifica();
            habilitarDeshabilitarBotonFiltrar();
        }

        #region Eventos Importantes - btnVolver y btnFiltrar...

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            if (optVerTodo.Checked)
            {
                dgvMostrar.Rows.Clear();

                lstTareas.ForEach(tarea =>
                {
                    //Busca y retorna al usuario que agregó la tarea utilizando su Id.
                    var usuario = lstUsuarios.lstUsuarios.Find(user => user.id.Equals(tarea.usuarioId));

                    dgvMostrar.Rows.Add(tarea.id, usuario.nombreUsuario, tarea.fecha, tarea.tarea, tarea.lugar,
                        tarea.uniforme, tarea.licencia, tarea.reclamo, tarea.comentario);
                });
            }
            else
            {
                string busqueda = cmbTipoFiltrado.Text;
                string dato = "";

                if (busqueda == "Por Usuario (Id)")
                {
                    dato = txtIngresarDato.Text;
                }
                else if (busqueda == "Por Fecha (Ingresar desde cuando)")
                {
                    dato = dtpFecha.Text;
                }
                else if (busqueda == "Por Tarea" || busqueda == "Por Lugar")
                {
                    dato = cmbSeleccionarDato.Text;
                }

                añadirFilasBusquedaEspecifica(dgvMostrar, busqueda, dato);
            }
        }

        #endregion

        #region Eventos - CheckedChanged, SelectedIndexChanged, KeyPress...

        private void optVerTodo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarControlesBusquedaEspecifica();
            habilitarDeshabilitarBotonFiltrar();
        }

        private void optBusquedaEspecifica_CheckedChanged(object sender, EventArgs e)
        {
            habilitarControlesBusquedaEspecifica();
            habilitarDeshabilitarBotonFiltrar();
        }

        private void cmbTipoFiltrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoFiltro = cmbTipoFiltrado.Text;

            switch (tipoFiltro)
            {
                case "Por Tarea":
                case "Por Lugar":
                    controlEnPantalla.Visible = false;
                    controlEnPantalla = cmbSeleccionarDato;
                    controlEnPantalla.Visible = true;
                    cargarComboBoxSeleccionDato(tipoFiltro);
                    break;

                case "Por Usuario (Id)":
                    controlEnPantalla.Visible = false;
                    controlEnPantalla = txtIngresarDato;
                    controlEnPantalla.Visible = true;
                    break;

                case "Por Fecha (Ingresar desde cuando)":
                    controlEnPantalla.Visible = false;
                    controlEnPantalla = dtpFecha;
                    controlEnPantalla.Visible = true;
                    break;
            }

            habilitarDeshabilitarBotonFiltrar();
        }

        private void cmbSeleccionarDato_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBotonFiltrar();
        }

        private void txtIngresarDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIngresarDato_TextChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBotonFiltrar();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBotonFiltrar();
        }

        #endregion

        #region Metodos - añadirColumnas, añadirFilas, etc...

        public void añadirColumnas(DataGridView dgv)
        {
            dgv.Columns.Clear();

            //Modificaciones para cambiar el color de las columnas
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(14, 32, 37);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.Control;

            string[] columnas;

            columnas = new string[] { "Id Tarea", "Usuario", "Fecha", "Tarea", "Lugar",
                                    "Uniforme", "Licencia", "Reclamo", "Comentario" };

            foreach (string columna in columnas)
            {
                dgv.Columns.Add(columna, columna);
            }
        }

        public void añadirFilasBusquedaEspecifica(DataGridView dgv, string busqueda, string dato)
        {
            dgv.Rows.Clear();

            clsUsuario usuario;

            switch (busqueda)
            {
                case "Por Usuario (Id)":

                    int Id = Convert.ToInt32(dato); //Se convierte el id recibido (como string) en int.

                    //Busca y retorna al usuario que agregó las tareas utilizando el dato recién convertido a int.
                    usuario = lstUsuarios.lstUsuarios.Find(user => user.id.Equals(Id));

                    bool registroTareas = false;

                    if (usuario != null) //En caso de encontrar al usuario...
                    {
                        lstTareas.ForEach(tarea =>
                        {
                            if (tarea.usuarioId == Id)
                            {
                                dgv.Rows.Add(tarea.id, usuario.nombreUsuario, tarea.fecha, tarea.tarea, tarea.lugar,
                                    tarea.uniforme, tarea.licencia, tarea.reclamo, tarea.comentario);
                                registroTareas = true;
                            }
                        });
                        if (registroTareas != true)
                            MessageBox.Show("El usuario existe, pero no ha registrado ninguna tarea.", "ERROR DE FILTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else //En caso de no encontrar al usuario (null)...
                    {
                        MessageBox.Show("No se encontró el id de usuario que ingresó. El usuario con esa id no existe.", "ERROR DE FILTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Por Fecha (Ingresar desde cuando)":
                    DateTime Fecha = Convert.ToDateTime(dato);

                    // Filtrar y ordenar las tareas
                    var tareasFiltradas = lstTareas
                        .Where(t => t.fecha >= Fecha)
                        .OrderBy(t => t.fecha)  // Orden ascendente por fecha
                        .ToList();

                    if (tareasFiltradas.Any())
                    {
                        tareasFiltradas.ForEach(tarea =>
                        {
                            usuario = lstUsuarios.lstUsuarios.Find(user => user.id.Equals(tarea.usuarioId));

                            dgv.Rows.Add(tarea.id, usuario.nombreUsuario, tarea.fecha, tarea.tarea, tarea.lugar,
                                tarea.uniforme, tarea.licencia, tarea.reclamo, tarea.comentario);
                        });
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron tareas desde la fecha que ingresó.", "ERROR DE FILTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Por Tarea":
                    bool existeLaTarea = false;

                    lstTareas.ForEach(tarea =>
                    {
                        if (tarea.tarea == dato)
                        {
                            usuario = lstUsuarios.lstUsuarios.Find(user => user.id.Equals(tarea.usuarioId));

                            dgv.Rows.Add(tarea.id, usuario.nombreUsuario, tarea.fecha, tarea.tarea, tarea.lugar,
                                tarea.uniforme, tarea.licencia, tarea.reclamo, tarea.comentario);
                            existeLaTarea = true;
                        }
                    });
                    if (existeLaTarea != true)
                        MessageBox.Show($"No se encontraron tareas {$"{dato}"} registradas.", "ERROR DE FILTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "Por Lugar":
                    bool existeEnLugar = false;

                    lstTareas.ForEach(tarea =>
                    {
                        if (tarea.lugar == dato)
                        {
                            usuario = lstUsuarios.lstUsuarios.Find(user => user.id.Equals(tarea.usuarioId));

                            dgv.Rows.Add(tarea.id, usuario.nombreUsuario, tarea.fecha, tarea.tarea, tarea.lugar,
                                tarea.uniforme, tarea.licencia, tarea.reclamo, tarea.comentario);
                            existeEnLugar = true;
                        }
                    });
                    if (existeEnLugar != true)
                        MessageBox.Show($"No se encontraron tareas {$"{dato}"} registradas.", "ERROR DE FILTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }

        public void cargarComboBoxSeleccionDato(string tipoFiltro)
        {
            cmbSeleccionarDato.Text = "";
            cmbSeleccionarDato.Items.Clear();

            string[] datos;

            if (tipoFiltro == "Por Tarea")
            {
                datos = new string[] { "Auditoria", "Consultas", "Inspección", "Reclamos", "Visita", "Relevamiento" };
            }
            else //tipoFiltro == "Por Lugar"
            {
                datos = new string[] { "Empresa", "Servicio", "Oficina" };
            }

            foreach (string dato in datos)
            {
                cmbSeleccionarDato.Items.Add(dato);
            }


        }

        public void habilitarControlesBusquedaEspecifica()
        {
            if (optBusquedaEspecifica.Checked)
            {
                cmbTipoFiltrado.Enabled = true; cmbTipoFiltrado.BackColor = SystemColors.Control;
                controlEnPantalla.Enabled = true; controlEnPantalla.BackColor = SystemColors.Control;
            }
            else
            {
                cmbTipoFiltrado.Enabled = false; cmbTipoFiltrado.BackColor = Color.Gray;
                controlEnPantalla.Enabled = false; controlEnPantalla.BackColor = Color.Gray;
            }
        }

        public void habilitarDeshabilitarBotonFiltrar()
        {
            if (optBusquedaEspecifica.Checked)
            {
                if (cmbTipoFiltrado.SelectedIndex != -1)
                {
                    switch (controlEnPantalla.Name)
                    {
                        case "cmbSeleccionarDato":
                            if (cmbSeleccionarDato.SelectedIndex != -1)
                                btnFiltrar.Enabled = true;
                            else
                                btnFiltrar.Enabled = false;
                            break;

                        case "txtIngresarDato":
                            if (txtIngresarDato.Text != "")
                                btnFiltrar.Enabled = true;
                            else
                                btnFiltrar.Enabled = false;
                            break;

                        case "dtpFecha":
                            if (dtpFecha.Value != null)
                                btnFiltrar.Enabled = true;
                            else
                                btnFiltrar.Enabled = false;
                            break;
                    }
                }
                else
                    btnFiltrar.Enabled = false;
            }
            else
                btnFiltrar.Enabled = true;

            //Cambiar color del boton
            if (btnFiltrar.Enabled != true)
                btnFiltrar.BackColor = Color.Gray;
            else
                btnFiltrar.BackColor = Color.FromArgb(29, 180, 98);
        }

        #endregion
    }
}
