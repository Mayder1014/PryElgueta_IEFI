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
    public partial class frmRegistrarTareas : Form
    {
        public frmRegistrarTareas()
        {
            InitializeComponent();
        }

        List<clsTarea> lstTareas = new List<clsTarea>();
        clsTarea tareaSeleccionada = null;
        int tareasAgregadas = 0;

        clsConexionBBDD conexion = new clsConexionBBDD();

        private void frmRegistrarTareas_Load(object sender, EventArgs e)
        {
            añadirColumnas(dgvMostrar);
            cargarComboBox(cmbTarea); cargarComboBox(cmbLugar);
            habilitarDeshabilitarBotonAgregar();
            habilitarDeshabilitarBotonSeleccionarQuitar();

            dtpFecha.MaxDate = DateTime.Now;

            Button[] botones = new Button[] { btnAgregarTarea, btnSeleccionarTarea, btnGuardarDetalles, btnRegistrar }; 

            foreach (Button boton in botones)
            {
                cambiarColorBotones(boton);
            }
        }


        #region Eventos Importantes - Agregar, Quitar, Seleccionar, GuardarDetalles, Registrar Tareas...

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (tareasAgregadas < 5)
            {
                DateTime fecha = dtpFecha.Value;
                string tarea = cmbTarea.SelectedItem.ToString();
                string lugar = cmbLugar.SelectedItem.ToString();

                //El id de las tareas irá de acuerdo al orden de agregamiento de las mismas (Solo internamente, no en BBDD).
                clsTarea tareaNueva = new clsTarea(tareasAgregadas,clsUsuario.usuarioLogueado.id,fecha,tarea,lugar,"","","","");

                lstTareas.Add(tareaNueva);
                cargarComboBox(cmbSeleccionarTarea);

                actualizarFilas(dgvMostrar);
                limpiarControlesSeleccion();
                habilitarDeshabilitarBotonAgregar();
                tareasAgregadas++;
            }
            else
            {
                MessageBox.Show("No puede agregar más de 5 tareas a la vez. Por favor, considere quitar alguna o agregar más tareas luego de registrar" +
                    " las que ya tiene agregadas.", "ERROR: Sobrecarga de tareas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSeleccionarTarea_Click(object sender, EventArgs e)
        {
            int indice = cmbSeleccionarTarea.SelectedIndex; //Se obtiene el "id" de la tarea seleccionada.

            tareaSeleccionada = lstTareas.Find(elem => elem.id.Equals(indice)); //Se obtiene los valores de la tarea seleccionada.

            panelDetalles.Enabled = true; //Habilita el panel para completar detalles.
            txtComentario.Enabled = true; //Habilita el txt de comentario.

            btnGuardarDetalles.Enabled = true; //Habilita el botón para guardar detalles.
            cambiarColorBotones(btnGuardarDetalles);
            recuperarDetallesTareaSeleccionada(); //Se habilitan checkboxes y muestra el comentario de esa tarea seleccionada.
        }

        private void btnQuitarTarea_Click(object sender, EventArgs e)
        {
            int indice = cmbSeleccionarTarea.SelectedIndex; //Se obtiene el "id" de la tarea seleccionada.

            indice = lstTareas.FindIndex(tarea => tarea.id.Equals(indice));

            lstTareas.RemoveAt(indice);

            tareasAgregadas = 0;

            lstTareas.ForEach(tarea =>
            {
                tarea.id = tareasAgregadas;
                tareasAgregadas++;
            });

            limpiarControlesDetalles();

            cargarComboBox(cmbSeleccionarTarea);
            actualizarFilas(dgvMostrar);
            
            habilitarDeshabilitarBotonSeleccionarQuitar();
            cambiarColorBotones(btnSeleccionarTarea);

        }

        private void btnGuardarDetalles_Click(object sender, EventArgs e)
        {
            lstTareas[tareaSeleccionada.id] = tareaSeleccionada; //Actualiza la tarea seleccionada en la lista.

            tareaSeleccionada = null; //Se deshace de la tarea seleccionada.

            limpiarControlesDetalles();

            btnGuardarDetalles.Enabled = false; //Deshabilita el botón de guardar detalles hasta que se seleccione otra tarea.
            cambiarColorBotones(btnGuardarDetalles);
            actualizarFilas(dgvMostrar); //Actualiza el estado de la tarea (En caso de no tener ningún detalle, o al fin tener uno).
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string listadoTareas = "";
            string comentario = "";
            string uniforme = ""; string licencia = ""; string reclamo = "";

            lstTareas.ForEach(tarea =>
            {
                if (tarea.uniforme != "")
                    uniforme = tarea.uniforme;
                else
                    uniforme = "No hay detalles";

                if (tarea.licencia != "")
                    licencia = tarea.licencia;
                else
                    licencia = "No hay detalles";

                if (tarea.reclamo != "")
                    reclamo = tarea.reclamo;
                else
                    reclamo = "No hay detalles";

                if (tarea.comentario != "")
                    comentario = $"| Comentario: {tarea.comentario}";
                else
                    comentario = "| Sin comentarios.";

                listadoTareas += $">> N°{tarea.id + 1}: {tarea.tarea} | Lugar: {tarea.lugar} | Fecha: {tarea.fecha} |" +
                $" Uniforme: {uniforme} - Licencia: {licencia} - Reclamo: {reclamo} {comentario}\r\n";
            });

            DialogResult respuesta = MessageBox.Show("¿Está seguro que quiere registrar este listado de tareas?:\r\n" +
                $"{listadoTareas}", "CONFIRMACIÓN DE REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                lstTareas.ForEach(tarea =>
                {
                    conexion.agregarTarea(tarea);
                });

                string evento = "Registro de Tareas";
                string descripcion = $"El usuario {clsUsuario.usuarioLogueado.nombreUsuario} ha registrado tareas.";

                clsRegistro registro = new clsRegistro(0, clsUsuario.usuarioLogueado.id, evento, DateTime.Now, descripcion);

                conexion.registrarEnAuditoria(registro);

                MessageBox.Show("Las tareas fueron registradas con éxito.", "REGISTRO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Se restablece todo:
                tareasAgregadas = 0;
                lstTareas.Clear();

                limpiarControlesDetalles();
                limpiarControlesSeleccion();
                habilitarDeshabilitarBotonAgregar();
                habilitarDeshabilitarBotonSeleccionarQuitar();

                actualizarFilas(dgvMostrar);
                cargarComboBox(cmbSeleccionarTarea);
                btnRegistrar.Enabled = false;
                cambiarColorBotones(btnRegistrar);
            }
        }

        #endregion

        #region Eventos - selectedIndexChanged, checkedChanged, textChanged...

        private void cmbTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBotonAgregar();
        }

        private void cmbLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBotonAgregar();
        }

        private void cmbSeleccionarTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarDeshabilitarBotonSeleccionarQuitar();
            cambiarColorBotones(btnSeleccionarTarea);

            panelDetalles.Enabled = false;
            txtComentario.Enabled = false;
        }

        private void chkInsumo_CheckedChanged(object sender, EventArgs e)
        {
            if (tareaSeleccionada != null)
            {
                if (chkInsumo.Checked)
                    tareaSeleccionada.uniforme = "Insumo";
                else
                    tareaSeleccionada.uniforme = "";
            }
        }

        private void chkEstudio_CheckedChanged(object sender, EventArgs e)
        {
            if (tareaSeleccionada != null)
            {
                if (chkEstudio.Checked) //Cuando se chequea el detalle...
                {
                    if (tareaSeleccionada.licencia == "") //Si licencia no tiene nada, se agrega el detalle seleccionado.
                    {
                        tareaSeleccionada.licencia = "Estudio";
                    }
                    else if (tareaSeleccionada.licencia == "Vacación") //Si licencia ya tenía otro detalle, se agrega el actual al string.
                    {
                        tareaSeleccionada.licencia = "Estudio, Vacación";
                    }
                }
                else //Cuando se deschequea (ponele que existe la palabra)...
                {
                    if (tareaSeleccionada.licencia == "Estudio, Vacación") //Si la licencia tiene ambos detalles, se quita del string el detalle actual.
                        tareaSeleccionada.licencia = "Vacación";
                    else //Si la licencia tenía el detalle actual, se vacia el string
                        tareaSeleccionada.licencia = "";
                }
            }
        }

        private void chkVacacion_CheckedChanged(object sender, EventArgs e)
        {
            if (tareaSeleccionada != null)
            {
                if (chkVacacion.Checked)
                {
                    if (tareaSeleccionada.licencia == "")
                    {
                        tareaSeleccionada.licencia = "Vacación";
                    }
                    else if (tareaSeleccionada.licencia == "Estudio")
                    {
                        tareaSeleccionada.licencia = "Estudio, Vacación";
                    }
                }
                else
                {
                    if (tareaSeleccionada.licencia == "Estudio, Vacación")
                        tareaSeleccionada.licencia = "Estudio";
                    else
                        tareaSeleccionada.licencia = "";
                }
            }
        }

        private void chkSalario_CheckedChanged(object sender, EventArgs e)
        {
            if (tareaSeleccionada != null)
            {
                if (chkSalario.Checked)
                {
                    if (tareaSeleccionada.reclamo == "")
                    {
                        tareaSeleccionada.reclamo = "Salario";
                    }
                    else if (tareaSeleccionada.reclamo == "Recibo")
                    {
                        tareaSeleccionada.reclamo = "Salario, Recibo";
                    }
                }
                else
                {
                    if (tareaSeleccionada.reclamo == "Salario, Recibo")
                        tareaSeleccionada.reclamo = "Recibo";
                    else
                        tareaSeleccionada.reclamo = "";
                }
            }
        }

        private void chkRecibo_CheckedChanged(object sender, EventArgs e)
        {
            if (tareaSeleccionada != null)
            {
                if (chkRecibo.Checked)
                {
                    if (tareaSeleccionada.reclamo == "")
                    {
                        tareaSeleccionada.reclamo = "Recibo";
                    }
                    else if (tareaSeleccionada.reclamo == "Salario")
                    {
                        tareaSeleccionada.reclamo = "Salario, Recibo";
                    }
                }
                else
                {
                    if (tareaSeleccionada.reclamo == "Salario, Recibo")
                        tareaSeleccionada.reclamo = "Salario";
                    else
                        tareaSeleccionada.reclamo = "";
                }
            }
        }

        private void txtComentario_TextChanged(object sender, EventArgs e)
        {
            if (tareaSeleccionada != null)
                tareaSeleccionada.comentario = txtComentario.Text;
        }

        #endregion

        #region Metodos (cargarComboBox, cambiarColores, controles para habilitar, deshabilitar, etc)...

        public void cargarComboBox(ComboBox cmb)
        {
            cmb.Items.Clear();

            string[] datos;

            switch (cmb.Name)
            {
                case "cmbTarea":
                    datos = new string[] { "Auditoria", "Consultas", "Inspección", "Reclamos", "Visita", "Relevamiento" };
                    break;
                case "cmbLugar":
                    datos = new string[] { "Empresa", "Servicio", "Oficina" };
                    break;
                case "cmbSeleccionarTarea":
                    datos = new string[lstTareas.Count];
                    int i = 0;
                    lstTareas.ForEach(elem =>
                    {
                        datos[i] = $"Tarea N°{elem.id+1} | {elem.tarea}";
                        i++;
                    });
                    break;
                default:
                    datos = null; //Nunca va a ocurrir realmente pero si no pongo un default, el foreach no funciona.
                    break;
            }

            foreach (string dato in datos)
            {
                cmb.Items.Add(dato);
            }
        }

        public void añadirColumnas(DataGridView dgv)
        {
            dgv.Columns.Clear();

            //Modificaciones para cambiar el color de las columnas
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(14, 32, 47);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.Control;

            string[] columnas = new string[] { "N°", "Fecha", "Tarea", "Lugar", "Estado" };

            foreach (string columna in columnas)
            {
                dgv.Columns.Add(columna, columna);
            }
        }

        public void actualizarFilas(DataGridView dgv)
        {
            dgv.Rows.Clear();

            int tareasCompletadas = 0; //Esta variable se usará para verificar que todas las tareas de la lista esten con estado [✓].

            string estado;

            lstTareas.ForEach(elem =>
            {
                //Si la tarea no tiene ningún texto en estos 3 campos, es pq no se completó ningún detalle y no es apto para registrar.
                if (elem.uniforme != "" || elem.licencia != "" || elem.reclamo != "")
                {
                    estado = "[✓]"; tareasCompletadas++;
                }
                else
                {
                    estado = "[X]";
                }
                dgv.Rows.Add(elem.id+1, elem.fecha, elem.tarea, elem.lugar, estado);
            });

            habilitarDeshabilitarBotonRegistrar(tareasCompletadas);
        }

        public void habilitarDeshabilitarBotonRegistrar(int tareasCompletadas)
        {
            if (tareasCompletadas != lstTareas.Count)
            {
                btnRegistrar.Enabled = false;
                lblAviso.Visible = true;

                int tareasIncompletas = lstTareas.Count - tareasCompletadas;

                if (tareasIncompletas == 1)
                {
                    lblAviso.Text = ">> AVISO: Hay una tarea sin completar al menos UN detalle." +
                        "\r\nEn la grilla podrá visualizar el estado de las tareas.";
                }
                else if (tareasIncompletas == lstTareas.Count)
                {
                    lblAviso.Text = ">> AVISO: Hay varias tareas sin completar al menos UN detalle." +
                        "\r\nEn la grilla podrá visualizar el estado de las tareas.";
                }
                else
                    lblAviso.Visible = false;
            }
            else
            {
                btnRegistrar.Enabled = true;
                lblAviso.Visible = false;
            }


            cambiarColorBotones(btnRegistrar);
        }

        public void habilitarDeshabilitarBotonAgregar()
        {
            if (dtpFecha.Value != null && cmbTarea.SelectedIndex != -1 && cmbLugar.SelectedIndex != -1)
                btnAgregarTarea.Enabled = true;
            else
                btnAgregarTarea.Enabled = false;

            cambiarColorBotones(btnAgregarTarea);
        }

        public void habilitarDeshabilitarBotonSeleccionarQuitar()
        {
            if (cmbSeleccionarTarea.SelectedIndex != -1)
            {
                btnSeleccionarTarea.Enabled = true;
                btnQuitarTarea.Enabled = true;
            }
            else
            {
                btnSeleccionarTarea.Enabled = false;
                btnQuitarTarea.Enabled = false;
            }

            cambiarColorBotones(btnSeleccionarTarea);
        }

        public void limpiarControlesSeleccion()
        {
            cmbTarea.SelectedIndex = -1;
            cmbLugar.SelectedIndex = -1;
            dtpFecha.Focus();
        }

        public void limpiarControlesDetalles()
        {
            panelDetalles.Enabled = false;
            txtComentario.Enabled = false;
            cmbSeleccionarTarea.SelectedIndex = -1;

            chkInsumo.Checked = false; chkEstudio.Checked = false;
            chkVacacion.Checked = false; chkSalario.Checked = false;
            chkRecibo.Checked = false; txtComentario.Text = "";
        }

        public void recuperarDetallesTareaSeleccionada()
        {
            switch (tareaSeleccionada.uniforme)
            {
                case "":
                    chkInsumo.Checked = false;
                    break;
                case "Insumo":
                    chkInsumo.Checked = true;
                    break;
            }

            switch (tareaSeleccionada.licencia)
            {
                case "":
                    chkEstudio.Checked = false;
                    chkVacacion.Checked = false;
                    break;
                case "Estudio":
                    chkEstudio.Checked = true;
                    chkVacacion.Checked = false;
                    break;
                case "Estudio, Vacación":
                    chkEstudio.Checked = true;
                    chkVacacion.Checked = true;
                    break;
            }

            switch (tareaSeleccionada.reclamo)
            {
                case "":
                    chkSalario.Checked = false;
                    chkRecibo.Checked = false;
                    break;
                case "Salario":
                    chkSalario.Checked = true;
                    chkRecibo.Checked = false;
                    break;
                case "Salario, Recibo":
                    chkSalario.Checked = true;
                    chkRecibo.Checked = true;
                    break;
            }

            txtComentario.Text = tareaSeleccionada.comentario;
        }
        
        public void cambiarColorBotones(Button btn)
        {
            switch (btn.Name)
            {
                case "btnAgregarTarea":
                    if (btnAgregarTarea.Enabled != true)
                        btnAgregarTarea.BackColor = Color.Gray;
                    else
                        btnAgregarTarea.BackColor = Color.FromArgb(29, 180, 98);
                    break;
                case "btnSeleccionarTarea":
                    if (btnSeleccionarTarea.Enabled != true)
                        btnSeleccionarTarea.BackColor = Color.Gray;
                    else
                        btnSeleccionarTarea.BackColor = Color.FromArgb(29, 180, 98);
                    break;
                case "btnGuardarDetalles":
                    if (btnGuardarDetalles.Enabled != true)
                        btnGuardarDetalles.BackColor = Color.Gray;
                    else
                        btnGuardarDetalles.BackColor = Color.FromArgb(29, 180, 98);
                    break;
                case "btnRegistrar":
                    if (btnRegistrar.Enabled != true)
                        btnRegistrar.BackColor = Color.Gray;
                    else
                        btnRegistrar.BackColor = Color.FromArgb(29, 180, 98);
                    break;
            }
        }

        #endregion

    }
}
