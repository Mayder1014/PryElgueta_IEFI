namespace PryElgueta_IEFI
{
    partial class frmHistorialTareas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialTareas));
            this.btnVolver = new System.Windows.Forms.Button();
            this.mrcModoVisualización = new System.Windows.Forms.GroupBox();
            this.optBusquedaEspecifica = new System.Windows.Forms.RadioButton();
            this.optVerTodo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoFiltrado = new System.Windows.Forms.ComboBox();
            this.mrcBusquedaEspecifica = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSeleccionarDato = new System.Windows.Forms.ComboBox();
            this.txtIngresarDato = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.mrcModoVisualización.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.mrcBusquedaEspecifica.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(180)))), ((int)(((byte)(98)))));
            this.btnVolver.BackgroundImage = global::PryElgueta_IEFI.Properties.Resources.go_back;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(39, 37);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "-";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // mrcModoVisualización
            // 
            this.mrcModoVisualización.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mrcModoVisualización.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.mrcModoVisualización.Controls.Add(this.optBusquedaEspecifica);
            this.mrcModoVisualización.Controls.Add(this.optVerTodo);
            this.mrcModoVisualización.Controls.Add(this.label1);
            this.mrcModoVisualización.ForeColor = System.Drawing.SystemColors.Control;
            this.mrcModoVisualización.Location = new System.Drawing.Point(229, 42);
            this.mrcModoVisualización.Name = "mrcModoVisualización";
            this.mrcModoVisualización.Size = new System.Drawing.Size(357, 134);
            this.mrcModoVisualización.TabIndex = 4;
            this.mrcModoVisualización.TabStop = false;
            this.mrcModoVisualización.Text = "Modo de visualización...";
            // 
            // optBusquedaEspecifica
            // 
            this.optBusquedaEspecifica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optBusquedaEspecifica.AutoSize = true;
            this.optBusquedaEspecifica.ForeColor = System.Drawing.SystemColors.Control;
            this.optBusquedaEspecifica.Location = new System.Drawing.Point(165, 69);
            this.optBusquedaEspecifica.Name = "optBusquedaEspecifica";
            this.optBusquedaEspecifica.Size = new System.Drawing.Size(156, 20);
            this.optBusquedaEspecifica.TabIndex = 9;
            this.optBusquedaEspecifica.TabStop = true;
            this.optBusquedaEspecifica.Text = "Busqueda Especifica";
            this.optBusquedaEspecifica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optBusquedaEspecifica.UseVisualStyleBackColor = true;
            this.optBusquedaEspecifica.CheckedChanged += new System.EventHandler(this.optBusquedaEspecifica_CheckedChanged);
            // 
            // optVerTodo
            // 
            this.optVerTodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optVerTodo.AutoSize = true;
            this.optVerTodo.Checked = true;
            this.optVerTodo.ForeColor = System.Drawing.SystemColors.Control;
            this.optVerTodo.Location = new System.Drawing.Point(41, 69);
            this.optVerTodo.Name = "optVerTodo";
            this.optVerTodo.Size = new System.Drawing.Size(85, 20);
            this.optVerTodo.TabIndex = 8;
            this.optVerTodo.TabStop = true;
            this.optVerTodo.Text = "Ver Todo";
            this.optVerTodo.UseVisualStyleBackColor = true;
            this.optVerTodo.CheckedChanged += new System.EventHandler(this.optVerTodo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione como quiere visualizar el historial de tareas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToDeleteRows = false;
            this.dgvMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrar.Location = new System.Drawing.Point(12, 254);
            this.dgvMostrar.MultiSelect = false;
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMostrar.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvMostrar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMostrar.RowTemplate.Height = 24;
            this.dgvMostrar.Size = new System.Drawing.Size(1166, 505);
            this.dgvMostrar.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(180)))), ((int)(((byte)(98)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFiltrar.Location = new System.Drawing.Point(537, 207);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(129, 31);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccione el tipo de filtrado que desea aplicar:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbTipoFiltrado
            // 
            this.cmbTipoFiltrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoFiltrado.FormattingEnabled = true;
            this.cmbTipoFiltrado.Items.AddRange(new object[] {
            "Por Usuario (Id)",
            "Por Fecha (Ingresar desde cuando)",
            "Por Tarea",
            "Por Lugar"});
            this.cmbTipoFiltrado.Location = new System.Drawing.Point(57, 56);
            this.cmbTipoFiltrado.Name = "cmbTipoFiltrado";
            this.cmbTipoFiltrado.Size = new System.Drawing.Size(249, 24);
            this.cmbTipoFiltrado.TabIndex = 8;
            this.cmbTipoFiltrado.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFiltrado_SelectedIndexChanged);
            // 
            // mrcBusquedaEspecifica
            // 
            this.mrcBusquedaEspecifica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mrcBusquedaEspecifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.mrcBusquedaEspecifica.Controls.Add(this.label2);
            this.mrcBusquedaEspecifica.Controls.Add(this.label3);
            this.mrcBusquedaEspecifica.Controls.Add(this.cmbTipoFiltrado);
            this.mrcBusquedaEspecifica.Controls.Add(this.txtIngresarDato);
            this.mrcBusquedaEspecifica.Controls.Add(this.dtpFecha);
            this.mrcBusquedaEspecifica.Controls.Add(this.cmbSeleccionarDato);
            this.mrcBusquedaEspecifica.ForeColor = System.Drawing.SystemColors.Control;
            this.mrcBusquedaEspecifica.Location = new System.Drawing.Point(630, 12);
            this.mrcBusquedaEspecifica.Name = "mrcBusquedaEspecifica";
            this.mrcBusquedaEspecifica.Size = new System.Drawing.Size(357, 182);
            this.mrcBusquedaEspecifica.TabIndex = 11;
            this.mrcBusquedaEspecifica.TabStop = false;
            this.mrcBusquedaEspecifica.Text = "Busqueda especifica...";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Seleccione o Ingrese el dato necesario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbSeleccionarDato
            // 
            this.cmbSeleccionarDato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeleccionarDato.FormattingEnabled = true;
            this.cmbSeleccionarDato.Location = new System.Drawing.Point(57, 127);
            this.cmbSeleccionarDato.Name = "cmbSeleccionarDato";
            this.cmbSeleccionarDato.Size = new System.Drawing.Size(249, 24);
            this.cmbSeleccionarDato.TabIndex = 11;
            this.cmbSeleccionarDato.SelectedIndexChanged += new System.EventHandler(this.cmbSeleccionarDato_SelectedIndexChanged);
            // 
            // txtIngresarDato
            // 
            this.txtIngresarDato.Location = new System.Drawing.Point(57, 129);
            this.txtIngresarDato.Name = "txtIngresarDato";
            this.txtIngresarDato.Size = new System.Drawing.Size(249, 22);
            this.txtIngresarDato.TabIndex = 12;
            this.txtIngresarDato.Visible = false;
            this.txtIngresarDato.TextChanged += new System.EventHandler(this.txtIngresarDato_TextChanged);
            this.txtIngresarDato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresarDato_KeyPress);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(52, 127);
            this.dtpFecha.MaxDate = new System.DateTime(2025, 7, 2, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(259, 22);
            this.dtpFecha.TabIndex = 13;
            this.dtpFecha.Value = new System.DateTime(2025, 6, 7, 0, 0, 0, 0);
            this.dtpFecha.Visible = false;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // frmHistorialTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1190, 771);
            this.Controls.Add(this.mrcBusquedaEspecifica);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.mrcModoVisualización);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.btnFiltrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorialTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas - Historial de Tareas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHistorialTareas_Load);
            this.mrcModoVisualización.ResumeLayout(false);
            this.mrcModoVisualización.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.mrcBusquedaEspecifica.ResumeLayout(false);
            this.mrcBusquedaEspecifica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox mrcModoVisualización;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.RadioButton optBusquedaEspecifica;
        private System.Windows.Forms.RadioButton optVerTodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoFiltrado;
        private System.Windows.Forms.GroupBox mrcBusquedaEspecifica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSeleccionarDato;
        private System.Windows.Forms.TextBox txtIngresarDato;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}