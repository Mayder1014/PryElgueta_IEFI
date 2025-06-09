namespace PryElgueta_IEFI
{
    partial class frmRegistrarTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarTareas));
            this.mrcSeleccionar = new System.Windows.Forms.GroupBox();
            this.lblAvisoSobrecarga = new System.Windows.Forms.Label();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblSeleccionarLugar = new System.Windows.Forms.Label();
            this.lblSeleccionarTarea = new System.Windows.Forms.Label();
            this.lblSeleccionarFecha = new System.Windows.Forms.Label();
            this.mrcDetalles = new System.Windows.Forms.GroupBox();
            this.btnGuardarDetalles = new System.Windows.Forms.Button();
            this.lblCompletarDetalles = new System.Windows.Forms.Label();
            this.btnSeleccionarTarea = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.lblReclamo = new System.Windows.Forms.Label();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.lblUniforme = new System.Windows.Forms.Label();
            this.chkRecibo = new System.Windows.Forms.CheckBox();
            this.chkSalario = new System.Windows.Forms.CheckBox();
            this.chkVacacion = new System.Windows.Forms.CheckBox();
            this.chkEstudio = new System.Windows.Forms.CheckBox();
            this.chkInsumo = new System.Windows.Forms.CheckBox();
            this.lblSeleccionarTareaCompletar = new System.Windows.Forms.Label();
            this.btnQuitarTarea = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbSeleccionarTarea = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.mrcSeleccionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.mrcDetalles.SuspendLayout();
            this.panelDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcSeleccionar
            // 
            this.mrcSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mrcSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.mrcSeleccionar.Controls.Add(this.lblAvisoSobrecarga);
            this.mrcSeleccionar.Controls.Add(this.dgvMostrar);
            this.mrcSeleccionar.Controls.Add(this.btnAgregarTarea);
            this.mrcSeleccionar.Controls.Add(this.cmbLugar);
            this.mrcSeleccionar.Controls.Add(this.cmbTarea);
            this.mrcSeleccionar.Controls.Add(this.dtpFecha);
            this.mrcSeleccionar.Controls.Add(this.lblSeleccionarLugar);
            this.mrcSeleccionar.Controls.Add(this.lblSeleccionarTarea);
            this.mrcSeleccionar.Controls.Add(this.lblSeleccionarFecha);
            this.mrcSeleccionar.ForeColor = System.Drawing.SystemColors.Control;
            this.mrcSeleccionar.Location = new System.Drawing.Point(50, 22);
            this.mrcSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.mrcSeleccionar.Name = "mrcSeleccionar";
            this.mrcSeleccionar.Padding = new System.Windows.Forms.Padding(2);
            this.mrcSeleccionar.Size = new System.Drawing.Size(434, 488);
            this.mrcSeleccionar.TabIndex = 0;
            this.mrcSeleccionar.TabStop = false;
            this.mrcSeleccionar.Text = "Seleccionar...";
            // 
            // lblAvisoSobrecarga
            // 
            this.lblAvisoSobrecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoSobrecarga.Location = new System.Drawing.Point(4, 215);
            this.lblAvisoSobrecarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvisoSobrecarga.Name = "lblAvisoSobrecarga";
            this.lblAvisoSobrecarga.Size = new System.Drawing.Size(424, 24);
            this.lblAvisoSobrecarga.TabIndex = 8;
            this.lblAvisoSobrecarga.Text = "(Por favor, considere que no puede agregar más de 5 tareas a la vez por registro." +
    ")";
            this.lblAvisoSobrecarga.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToDeleteRows = false;
            this.dgvMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrar.Location = new System.Drawing.Point(19, 241);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMostrar.MultiSelect = false;
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMostrar.RowHeadersVisible = false;
            this.dgvMostrar.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            this.dgvMostrar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMostrar.RowTemplate.Height = 24;
            this.dgvMostrar.Size = new System.Drawing.Size(394, 232);
            this.dgvMostrar.TabIndex = 7;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "N°";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tarea";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Lugar";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(180)))), ((int)(((byte)(98)))));
            this.btnAgregarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTarea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarTarea.Location = new System.Drawing.Point(172, 167);
            this.btnAgregarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(95, 25);
            this.btnAgregarTarea.TabIndex = 6;
            this.btnAgregarTarea.Text = "Agregar Tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // cmbLugar
            // 
            this.cmbLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(172, 122);
            this.cmbLugar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(154, 21);
            this.cmbLugar.TabIndex = 5;
            this.cmbLugar.SelectedIndexChanged += new System.EventHandler(this.cmbLugar_SelectedIndexChanged);
            // 
            // cmbTarea
            // 
            this.cmbTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Location = new System.Drawing.Point(172, 80);
            this.cmbTarea.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(154, 21);
            this.cmbTarea.TabIndex = 4;
            this.cmbTarea.SelectedIndexChanged += new System.EventHandler(this.cmbTarea_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(172, 40);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.MaxDate = new System.DateTime(2025, 7, 2, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(209, 20);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.Value = new System.DateTime(2025, 6, 6, 0, 0, 0, 0);
            // 
            // lblSeleccionarLugar
            // 
            this.lblSeleccionarLugar.AutoSize = true;
            this.lblSeleccionarLugar.Location = new System.Drawing.Point(44, 124);
            this.lblSeleccionarLugar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionarLugar.Name = "lblSeleccionarLugar";
            this.lblSeleccionarLugar.Size = new System.Drawing.Size(103, 13);
            this.lblSeleccionarLugar.TabIndex = 2;
            this.lblSeleccionarLugar.Text = "* Seleccionar Lugar:";
            // 
            // lblSeleccionarTarea
            // 
            this.lblSeleccionarTarea.AutoSize = true;
            this.lblSeleccionarTarea.Location = new System.Drawing.Point(44, 83);
            this.lblSeleccionarTarea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionarTarea.Name = "lblSeleccionarTarea";
            this.lblSeleccionarTarea.Size = new System.Drawing.Size(104, 13);
            this.lblSeleccionarTarea.TabIndex = 1;
            this.lblSeleccionarTarea.Text = "* Seleccionar Tarea:";
            // 
            // lblSeleccionarFecha
            // 
            this.lblSeleccionarFecha.AutoSize = true;
            this.lblSeleccionarFecha.Location = new System.Drawing.Point(44, 44);
            this.lblSeleccionarFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionarFecha.Name = "lblSeleccionarFecha";
            this.lblSeleccionarFecha.Size = new System.Drawing.Size(106, 13);
            this.lblSeleccionarFecha.TabIndex = 0;
            this.lblSeleccionarFecha.Text = "* Seleccionar Fecha:";
            // 
            // mrcDetalles
            // 
            this.mrcDetalles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mrcDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.mrcDetalles.Controls.Add(this.btnGuardarDetalles);
            this.mrcDetalles.Controls.Add(this.lblCompletarDetalles);
            this.mrcDetalles.Controls.Add(this.btnSeleccionarTarea);
            this.mrcDetalles.Controls.Add(this.lblAviso);
            this.mrcDetalles.Controls.Add(this.panelDetalles);
            this.mrcDetalles.Controls.Add(this.lblSeleccionarTareaCompletar);
            this.mrcDetalles.Controls.Add(this.btnQuitarTarea);
            this.mrcDetalles.Controls.Add(this.btnRegistrar);
            this.mrcDetalles.Controls.Add(this.cmbSeleccionarTarea);
            this.mrcDetalles.Controls.Add(this.label4);
            this.mrcDetalles.Controls.Add(this.txtComentario);
            this.mrcDetalles.ForeColor = System.Drawing.SystemColors.Control;
            this.mrcDetalles.Location = new System.Drawing.Point(514, 22);
            this.mrcDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.mrcDetalles.Name = "mrcDetalles";
            this.mrcDetalles.Padding = new System.Windows.Forms.Padding(2);
            this.mrcDetalles.Size = new System.Drawing.Size(383, 488);
            this.mrcDetalles.TabIndex = 1;
            this.mrcDetalles.TabStop = false;
            this.mrcDetalles.Text = "Detalles...";
            // 
            // btnGuardarDetalles
            // 
            this.btnGuardarDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(180)))), ((int)(((byte)(98)))));
            this.btnGuardarDetalles.Enabled = false;
            this.btnGuardarDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDetalles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardarDetalles.Location = new System.Drawing.Point(149, 384);
            this.btnGuardarDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarDetalles.Name = "btnGuardarDetalles";
            this.btnGuardarDetalles.Size = new System.Drawing.Size(96, 23);
            this.btnGuardarDetalles.TabIndex = 15;
            this.btnGuardarDetalles.Text = "Guardar Detalles";
            this.btnGuardarDetalles.UseVisualStyleBackColor = false;
            this.btnGuardarDetalles.Click += new System.EventHandler(this.btnGuardarDetalles_Click);
            // 
            // lblCompletarDetalles
            // 
            this.lblCompletarDetalles.AutoSize = true;
            this.lblCompletarDetalles.Location = new System.Drawing.Point(26, 130);
            this.lblCompletarDetalles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompletarDetalles.Name = "lblCompletarDetalles";
            this.lblCompletarDetalles.Size = new System.Drawing.Size(105, 13);
            this.lblCompletarDetalles.TabIndex = 14;
            this.lblCompletarDetalles.Text = "* Completar Detalles;";
            // 
            // btnSeleccionarTarea
            // 
            this.btnSeleccionarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(180)))), ((int)(((byte)(98)))));
            this.btnSeleccionarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarTarea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSeleccionarTarea.Location = new System.Drawing.Point(210, 93);
            this.btnSeleccionarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarTarea.Name = "btnSeleccionarTarea";
            this.btnSeleccionarTarea.Size = new System.Drawing.Size(74, 23);
            this.btnSeleccionarTarea.TabIndex = 13;
            this.btnSeleccionarTarea.Text = "Seleccionar";
            this.btnSeleccionarTarea.UseVisualStyleBackColor = false;
            this.btnSeleccionarTarea.Click += new System.EventHandler(this.btnSeleccionarTarea_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAviso.Location = new System.Drawing.Point(7, 405);
            this.lblAviso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(372, 46);
            this.lblAviso.TabIndex = 12;
            this.lblAviso.Text = ">> AVISO: Hay X tareas sin completar al menos un detalle.\r\nEn la grilla podrá vis" +
    "ualizar el estado de las tareas.";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAviso.Visible = false;
            // 
            // panelDetalles
            // 
            this.panelDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.panelDetalles.Controls.Add(this.lblReclamo);
            this.panelDetalles.Controls.Add(this.lblLicencia);
            this.panelDetalles.Controls.Add(this.lblUniforme);
            this.panelDetalles.Controls.Add(this.chkRecibo);
            this.panelDetalles.Controls.Add(this.chkSalario);
            this.panelDetalles.Controls.Add(this.chkVacacion);
            this.panelDetalles.Controls.Add(this.chkEstudio);
            this.panelDetalles.Controls.Add(this.chkInsumo);
            this.panelDetalles.Enabled = false;
            this.panelDetalles.Location = new System.Drawing.Point(28, 145);
            this.panelDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(331, 88);
            this.panelDetalles.TabIndex = 9;
            // 
            // lblReclamo
            // 
            this.lblReclamo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReclamo.AutoSize = true;
            this.lblReclamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblReclamo.Location = new System.Drawing.Point(220, 15);
            this.lblReclamo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReclamo.Name = "lblReclamo";
            this.lblReclamo.Size = new System.Drawing.Size(104, 15);
            this.lblReclamo.TabIndex = 7;
            this.lblReclamo.Text = ">> Reclamo <<";
            // 
            // lblLicencia
            // 
            this.lblLicencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblLicencia.Location = new System.Drawing.Point(115, 15);
            this.lblLicencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(101, 15);
            this.lblLicencia.TabIndex = 6;
            this.lblLicencia.Text = ">> Licencia <<";
            // 
            // lblUniforme
            // 
            this.lblUniforme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUniforme.AutoSize = true;
            this.lblUniforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniforme.Location = new System.Drawing.Point(9, 15);
            this.lblUniforme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUniforme.Name = "lblUniforme";
            this.lblUniforme.Size = new System.Drawing.Size(106, 15);
            this.lblUniforme.TabIndex = 5;
            this.lblUniforme.Text = ">> Uniforme <<";
            // 
            // chkRecibo
            // 
            this.chkRecibo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkRecibo.AutoSize = true;
            this.chkRecibo.Location = new System.Drawing.Point(226, 57);
            this.chkRecibo.Margin = new System.Windows.Forms.Padding(2);
            this.chkRecibo.Name = "chkRecibo";
            this.chkRecibo.Size = new System.Drawing.Size(60, 17);
            this.chkRecibo.TabIndex = 4;
            this.chkRecibo.Text = "Recibo";
            this.chkRecibo.UseVisualStyleBackColor = true;
            this.chkRecibo.CheckedChanged += new System.EventHandler(this.chkRecibo_CheckedChanged);
            // 
            // chkSalario
            // 
            this.chkSalario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkSalario.AutoSize = true;
            this.chkSalario.Location = new System.Drawing.Point(226, 36);
            this.chkSalario.Margin = new System.Windows.Forms.Padding(2);
            this.chkSalario.Name = "chkSalario";
            this.chkSalario.Size = new System.Drawing.Size(58, 17);
            this.chkSalario.TabIndex = 3;
            this.chkSalario.Text = "Salario";
            this.chkSalario.UseVisualStyleBackColor = true;
            this.chkSalario.CheckedChanged += new System.EventHandler(this.chkSalario_CheckedChanged);
            // 
            // chkVacacion
            // 
            this.chkVacacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkVacacion.AutoSize = true;
            this.chkVacacion.Location = new System.Drawing.Point(122, 57);
            this.chkVacacion.Margin = new System.Windows.Forms.Padding(2);
            this.chkVacacion.Name = "chkVacacion";
            this.chkVacacion.Size = new System.Drawing.Size(71, 17);
            this.chkVacacion.TabIndex = 2;
            this.chkVacacion.Text = "Vacación";
            this.chkVacacion.UseVisualStyleBackColor = true;
            this.chkVacacion.CheckedChanged += new System.EventHandler(this.chkVacacion_CheckedChanged);
            // 
            // chkEstudio
            // 
            this.chkEstudio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkEstudio.AutoSize = true;
            this.chkEstudio.Location = new System.Drawing.Point(122, 36);
            this.chkEstudio.Margin = new System.Windows.Forms.Padding(2);
            this.chkEstudio.Name = "chkEstudio";
            this.chkEstudio.Size = new System.Drawing.Size(61, 17);
            this.chkEstudio.TabIndex = 1;
            this.chkEstudio.Text = "Estudio";
            this.chkEstudio.UseVisualStyleBackColor = true;
            this.chkEstudio.CheckedChanged += new System.EventHandler(this.chkEstudio_CheckedChanged);
            // 
            // chkInsumo
            // 
            this.chkInsumo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkInsumo.AutoSize = true;
            this.chkInsumo.Location = new System.Drawing.Point(15, 35);
            this.chkInsumo.Margin = new System.Windows.Forms.Padding(2);
            this.chkInsumo.Name = "chkInsumo";
            this.chkInsumo.Size = new System.Drawing.Size(60, 17);
            this.chkInsumo.TabIndex = 0;
            this.chkInsumo.Text = "Insumo";
            this.chkInsumo.UseVisualStyleBackColor = true;
            this.chkInsumo.CheckedChanged += new System.EventHandler(this.chkInsumo_CheckedChanged);
            // 
            // lblSeleccionarTareaCompletar
            // 
            this.lblSeleccionarTareaCompletar.Location = new System.Drawing.Point(4, 25);
            this.lblSeleccionarTareaCompletar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionarTareaCompletar.Name = "lblSeleccionarTareaCompletar";
            this.lblSeleccionarTareaCompletar.Size = new System.Drawing.Size(374, 37);
            this.lblSeleccionarTareaCompletar.TabIndex = 11;
            this.lblSeleccionarTareaCompletar.Text = "Seleccione una de las tareas agregadas para completar los detalles, o bien, quita" +
    "rla de la lista de tareas agregadas:";
            this.lblSeleccionarTareaCompletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuitarTarea
            // 
            this.btnQuitarTarea.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuitarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarTarea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuitarTarea.Location = new System.Drawing.Point(109, 93);
            this.btnQuitarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarTarea.Name = "btnQuitarTarea";
            this.btnQuitarTarea.Size = new System.Drawing.Size(64, 23);
            this.btnQuitarTarea.TabIndex = 8;
            this.btnQuitarTarea.Text = "Quitar";
            this.btnQuitarTarea.UseVisualStyleBackColor = false;
            this.btnQuitarTarea.Click += new System.EventHandler(this.btnQuitarTarea_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(180)))), ((int)(((byte)(98)))));
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrar.Location = new System.Drawing.Point(290, 450);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(69, 25);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmbSeleccionarTarea
            // 
            this.cmbSeleccionarTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeleccionarTarea.FormattingEnabled = true;
            this.cmbSeleccionarTarea.Location = new System.Drawing.Point(109, 65);
            this.cmbSeleccionarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSeleccionarTarea.Name = "cmbSeleccionarTarea";
            this.cmbSeleccionarTarea.Size = new System.Drawing.Size(176, 21);
            this.cmbSeleccionarTarea.TabIndex = 10;
            this.cmbSeleccionarTarea.SelectedIndexChanged += new System.EventHandler(this.cmbSeleccionarTarea_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comentario (Opcional) :";
            // 
            // txtComentario
            // 
            this.txtComentario.Enabled = false;
            this.txtComentario.Location = new System.Drawing.Point(28, 262);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(2);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(332, 112);
            this.txtComentario.TabIndex = 1;
            this.txtComentario.TextChanged += new System.EventHandler(this.txtComentario_TextChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(180)))), ((int)(((byte)(98)))));
            this.btnVolver.BackgroundImage = global::PryElgueta_IEFI.Properties.Resources.go_back;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.Location = new System.Drawing.Point(9, 9);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(29, 30);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "-";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmRegistrarTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(947, 533);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.mrcDetalles);
            this.Controls.Add(this.mrcSeleccionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmRegistrarTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas - Registrar Tareas";
            this.Load += new System.EventHandler(this.frmRegistrarTareas_Load);
            this.mrcSeleccionar.ResumeLayout(false);
            this.mrcSeleccionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.mrcDetalles.ResumeLayout(false);
            this.mrcDetalles.PerformLayout();
            this.panelDetalles.ResumeLayout(false);
            this.panelDetalles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcSeleccionar;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblSeleccionarLugar;
        private System.Windows.Forms.Label lblSeleccionarTarea;
        private System.Windows.Forms.Label lblSeleccionarFecha;
        private System.Windows.Forms.GroupBox mrcDetalles;
        private System.Windows.Forms.Button btnQuitarTarea;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Label lblReclamo;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.Label lblUniforme;
        private System.Windows.Forms.CheckBox chkRecibo;
        private System.Windows.Forms.CheckBox chkSalario;
        private System.Windows.Forms.CheckBox chkVacacion;
        private System.Windows.Forms.CheckBox chkEstudio;
        private System.Windows.Forms.CheckBox chkInsumo;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblSeleccionarTareaCompletar;
        private System.Windows.Forms.ComboBox cmbSeleccionarTarea;
        private System.Windows.Forms.Label lblCompletarDetalles;
        private System.Windows.Forms.Button btnSeleccionarTarea;
        private System.Windows.Forms.Label lblAvisoSobrecarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnGuardarDetalles;
    }
}