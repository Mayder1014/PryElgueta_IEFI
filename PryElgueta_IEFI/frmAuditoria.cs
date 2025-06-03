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
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }

        clsConexionBBDD conexion = new clsConexionBBDD();
        clsUsuarios lstUsuarios = new clsUsuarios();
        clsAuditoria lstRegistros = new clsAuditoria();

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            conexion.cargarListaUsuarios(lstUsuarios);
            conexion.cargarListaAuditoria(lstRegistros);

            añadirColumnas(dgvMostrar);
            añadirFilas(dgvMostrar);
        }

        private void optGeneral_CheckedChanged(object sender, EventArgs e)
        {
            añadirColumnas(dgvMostrar);
            añadirFilas(dgvMostrar);
        }

        private void optEventos_CheckedChanged(object sender, EventArgs e)
        {
            añadirColumnas(dgvMostrar);
            añadirFilas(dgvMostrar);
        }

        private void optInfoUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            añadirColumnas(dgvMostrar);
            añadirFilas(dgvMostrar);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Metodos...
        public void añadirColumnas(DataGridView dgv)
        {
            dgv.Columns.Clear();

            //Modificaciones para cambiar el color de las columnas
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(14, 32, 37);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.Control;

            string[] columnas;

            if (optGeneral.Checked)
            {
                columnas = new string[] { "Id Registro", "Id Usuario", "Usuario", "Permiso", "Última Conexión", "Último tiempo trabajado",
                "Tiempo total trabajado", "Fecha/Hora", "Evento", "Descripción" };
            }
            else if (optEventos.Checked)
            {
                columnas = new string[] { "Id Registro", "Fecha/Hora", "Usuario", "Evento", "Descripción" };
            }
            else
            {
                columnas = new string[] { "Id Usuario", "Usuario", "Permiso", "Fecha de creación", "Última Conexión", 
                "Último tiempo trabajado:", "Tiempo total trabajado" };
            }

            foreach (string columna in columnas)
            {
                dgv.Columns.Add(columna, columna);
            }
        }

        public void añadirFilas(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string permiso;

            if (optGeneral.Checked)
            {
                lstRegistros.lstAuditoria.ForEach(reg =>
                {
                    //Busca y retorna al usuario del registro utilizando su Id.
                    var usuario = lstUsuarios.lstUsuarios.Find(user => user.id.Equals(reg.usuarioId));

                    if (usuario.permiso != 0)
                        permiso = "Administrador";
                    else 
                        permiso = "Operador";

                    dgv.Rows.Add(reg.id, reg.usuarioId, usuario.nombreUsuario, permiso, usuario.ultimaConexion, usuario.ultimoTiempoTrabajo,
                        usuario.tiempoTrabajoTotal, reg.fechaHoraEvento, reg.tipoEvento, reg.descripcion);
                });
            }
            else if (optEventos.Checked)
            {
                lstRegistros.lstAuditoria.ForEach(reg =>
                {
                    //Busca y retorna al usuario del registro utilizando su Id.
                    var usuario = lstUsuarios.lstUsuarios.Find(user => user.id.Equals(reg.usuarioId));

                    dgv.Rows.Add(reg.id, reg.fechaHoraEvento, usuario.nombreUsuario, reg.tipoEvento, reg.descripcion);
                });
            }
            else
            {
                lstUsuarios.lstUsuarios.ForEach(user =>
                {
                    if (user.permiso != 0)
                        permiso = "Administrador";
                    else
                        permiso = "Operador";

                    dgv.Rows.Add(user.id, user.nombreUsuario, permiso, user.fechaCreacion, user.ultimaConexion,
                        user.ultimoTiempoTrabajo, user.tiempoTrabajoTotal);
                });
            }
        }
        #endregion

    }
}
