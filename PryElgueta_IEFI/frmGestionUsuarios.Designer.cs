namespace PryElgueta_IEFI
{
    partial class frmGestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMostrarDatosDelUsuario = new System.Windows.Forms.Label();
            this.lblDatosDelUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.mrcAgregarModificar = new System.Windows.Forms.GroupBox();
            this.chkEstadoUsuario = new System.Windows.Forms.CheckBox();
            this.chkNuevaContraseña = new System.Windows.Forms.CheckBox();
            this.chkNuevoNombre = new System.Windows.Forms.CheckBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.txtContraseñaModificar = new System.Windows.Forms.TextBox();
            this.txtNombreModificar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseñaAgregar = new System.Windows.Forms.TextBox();
            this.optInactivo = new System.Windows.Forms.RadioButton();
            this.optActivo = new System.Windows.Forms.RadioButton();
            this.txtNombreAgregar = new System.Windows.Forms.TextBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            this.mrcAgregarModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.lblMostrarDatosDelUsuario);
            this.panel1.Controls.Add(this.lblDatosDelUsuario);
            this.panel1.Controls.Add(this.lblNombreUsuario);
            this.panel1.Controls.Add(this.imgUsuario);
            this.panel1.Location = new System.Drawing.Point(111, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 258);
            this.panel1.TabIndex = 0;
            // 
            // lblMostrarDatosDelUsuario
            // 
            this.lblMostrarDatosDelUsuario.AutoSize = true;
            this.lblMostrarDatosDelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDatosDelUsuario.Location = new System.Drawing.Point(444, 61);
            this.lblMostrarDatosDelUsuario.Name = "lblMostrarDatosDelUsuario";
            this.lblMostrarDatosDelUsuario.Size = new System.Drawing.Size(152, 176);
            this.lblMostrarDatosDelUsuario.TabIndex = 3;
            this.lblMostrarDatosDelUsuario.Text = "Administrador/Operador\r\n\r\nxxxxxxxxxxxxxxx\r\n\r\ndd/MM/yyyy hh/mm/ss\r\n\r\nhh/mm/ss\r\n\r\nh" +
    "h/mm/ss\r\n\r\nActivo/Inactivo";
            // 
            // lblDatosDelUsuario
            // 
            this.lblDatosDelUsuario.AutoSize = true;
            this.lblDatosDelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosDelUsuario.Location = new System.Drawing.Point(250, 61);
            this.lblDatosDelUsuario.Name = "lblDatosDelUsuario";
            this.lblDatosDelUsuario.Size = new System.Drawing.Size(149, 176);
            this.lblDatosDelUsuario.TabIndex = 2;
            this.lblDatosDelUsuario.Text = "- Rol:\r\n\r\n- Contraseña:\r\n\r\n- Fecha de creación:\r\n\r\n- Última Conexión:\r\n\r\n- Total " +
    "trabajado:\r\n\r\n- Estado:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(249, 24);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(220, 20);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "NOMBRE DEL USUARIO";
            // 
            // imgUsuario
            // 
            this.imgUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imgUsuario.BackgroundImage = global::PryElgueta_IEFI.Properties.Resources.administrador;
            this.imgUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgUsuario.Location = new System.Drawing.Point(36, 48);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(179, 162);
            this.imgUsuario.TabIndex = 0;
            this.imgUsuario.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAtras.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAtras.BackgroundImage = global::PryElgueta_IEFI.Properties.Resources.left;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtras.Location = new System.Drawing.Point(44, 138);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(37, 35);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSiguiente.BackgroundImage = global::PryElgueta_IEFI.Properties.Resources.right;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSiguiente.Location = new System.Drawing.Point(803, 138);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(37, 35);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // mrcAgregarModificar
            // 
            this.mrcAgregarModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mrcAgregarModificar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mrcAgregarModificar.Controls.Add(this.chkEstadoUsuario);
            this.mrcAgregarModificar.Controls.Add(this.chkNuevaContraseña);
            this.mrcAgregarModificar.Controls.Add(this.chkNuevoNombre);
            this.mrcAgregarModificar.Controls.Add(this.lblNota);
            this.mrcAgregarModificar.Controls.Add(this.label7);
            this.mrcAgregarModificar.Controls.Add(this.label6);
            this.mrcAgregarModificar.Controls.Add(this.btnModificarUsuario);
            this.mrcAgregarModificar.Controls.Add(this.btnAgregarUsuario);
            this.mrcAgregarModificar.Controls.Add(this.txtContraseñaModificar);
            this.mrcAgregarModificar.Controls.Add(this.txtNombreModificar);
            this.mrcAgregarModificar.Controls.Add(this.label2);
            this.mrcAgregarModificar.Controls.Add(this.label1);
            this.mrcAgregarModificar.Controls.Add(this.txtContraseñaAgregar);
            this.mrcAgregarModificar.Controls.Add(this.optInactivo);
            this.mrcAgregarModificar.Controls.Add(this.optActivo);
            this.mrcAgregarModificar.Controls.Add(this.txtNombreAgregar);
            this.mrcAgregarModificar.Location = new System.Drawing.Point(44, 336);
            this.mrcAgregarModificar.Name = "mrcAgregarModificar";
            this.mrcAgregarModificar.Size = new System.Drawing.Size(796, 402);
            this.mrcAgregarModificar.TabIndex = 3;
            this.mrcAgregarModificar.TabStop = false;
            this.mrcAgregarModificar.Text = "Agregar o Modificar Usuario...";
            // 
            // chkEstadoUsuario
            // 
            this.chkEstadoUsuario.AutoSize = true;
            this.chkEstadoUsuario.Location = new System.Drawing.Point(478, 275);
            this.chkEstadoUsuario.Name = "chkEstadoUsuario";
            this.chkEstadoUsuario.Size = new System.Drawing.Size(144, 20);
            this.chkEstadoUsuario.TabIndex = 16;
            this.chkEstadoUsuario.Text = "Estado del Usuario";
            this.chkEstadoUsuario.UseVisualStyleBackColor = true;
            this.chkEstadoUsuario.CheckedChanged += new System.EventHandler(this.chkEstadoUsuario_CheckedChanged);
            // 
            // chkNuevaContraseña
            // 
            this.chkNuevaContraseña.AutoSize = true;
            this.chkNuevaContraseña.Location = new System.Drawing.Point(478, 216);
            this.chkNuevaContraseña.Name = "chkNuevaContraseña";
            this.chkNuevaContraseña.Size = new System.Drawing.Size(211, 20);
            this.chkNuevaContraseña.TabIndex = 15;
            this.chkNuevaContraseña.Text = "Nueva contraseña de Usuario:";
            this.chkNuevaContraseña.UseVisualStyleBackColor = true;
            this.chkNuevaContraseña.CheckedChanged += new System.EventHandler(this.chkNuevaContraseña_CheckedChanged);
            // 
            // chkNuevoNombre
            // 
            this.chkNuevoNombre.AutoSize = true;
            this.chkNuevoNombre.Location = new System.Drawing.Point(478, 162);
            this.chkNuevoNombre.Name = "chkNuevoNombre";
            this.chkNuevoNombre.Size = new System.Drawing.Size(190, 20);
            this.chkNuevoNombre.TabIndex = 14;
            this.chkNuevoNombre.Text = "Nuevo nombre de Usuario:";
            this.chkNuevoNombre.UseVisualStyleBackColor = true;
            this.chkNuevoNombre.CheckedChanged += new System.EventHandler(this.chkNuevoNombre_CheckedChanged);
            // 
            // lblNota
            // 
            this.lblNota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(21, 33);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(669, 72);
            this.lblNota.TabIndex = 13;
            this.lblNota.Text = resources.GetString("lblNota.Text");
            this.lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = ">> Modificar Usuario <<";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = ">> Agregar Usuario <<";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificarUsuario.Enabled = false;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Location = new System.Drawing.Point(514, 345);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(146, 29);
            this.btnModificarUsuario.TabIndex = 4;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(125, 345);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(146, 29);
            this.btnAgregarUsuario.TabIndex = 6;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // txtContraseñaModificar
            // 
            this.txtContraseñaModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseñaModificar.Enabled = false;
            this.txtContraseñaModificar.Location = new System.Drawing.Point(478, 242);
            this.txtContraseñaModificar.Name = "txtContraseñaModificar";
            this.txtContraseñaModificar.Size = new System.Drawing.Size(225, 22);
            this.txtContraseñaModificar.TabIndex = 7;
            this.txtContraseñaModificar.TextChanged += new System.EventHandler(this.txtContraseñaModificar_TextChanged);
            // 
            // txtNombreModificar
            // 
            this.txtNombreModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreModificar.Enabled = false;
            this.txtNombreModificar.Location = new System.Drawing.Point(478, 188);
            this.txtNombreModificar.Name = "txtNombreModificar";
            this.txtNombreModificar.Size = new System.Drawing.Size(225, 22);
            this.txtNombreModificar.TabIndex = 6;
            this.txtNombreModificar.TextChanged += new System.EventHandler(this.txtNombreModificar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña de Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // txtContraseñaAgregar
            // 
            this.txtContraseñaAgregar.Location = new System.Drawing.Point(90, 269);
            this.txtContraseñaAgregar.Name = "txtContraseñaAgregar";
            this.txtContraseñaAgregar.Size = new System.Drawing.Size(225, 22);
            this.txtContraseñaAgregar.TabIndex = 3;
            // 
            // optInactivo
            // 
            this.optInactivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optInactivo.AutoSize = true;
            this.optInactivo.Enabled = false;
            this.optInactivo.Location = new System.Drawing.Point(629, 301);
            this.optInactivo.Name = "optInactivo";
            this.optInactivo.Size = new System.Drawing.Size(74, 20);
            this.optInactivo.TabIndex = 2;
            this.optInactivo.Text = "Inactivo";
            this.optInactivo.UseVisualStyleBackColor = true;
            this.optInactivo.CheckedChanged += new System.EventHandler(this.optInactivo_CheckedChanged);
            // 
            // optActivo
            // 
            this.optActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optActivo.AutoSize = true;
            this.optActivo.Enabled = false;
            this.optActivo.Location = new System.Drawing.Point(478, 301);
            this.optActivo.Name = "optActivo";
            this.optActivo.Size = new System.Drawing.Size(65, 20);
            this.optActivo.TabIndex = 1;
            this.optActivo.Text = "Activo";
            this.optActivo.UseVisualStyleBackColor = true;
            this.optActivo.CheckedChanged += new System.EventHandler(this.optActivo_CheckedChanged);
            // 
            // txtNombreAgregar
            // 
            this.txtNombreAgregar.Location = new System.Drawing.Point(90, 212);
            this.txtNombreAgregar.Name = "txtNombreAgregar";
            this.txtNombreAgregar.Size = new System.Drawing.Size(225, 22);
            this.txtNombreAgregar.TabIndex = 0;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(364, 292);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(146, 29);
            this.btnEliminarUsuario.TabIndex = 5;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnVolver.BackgroundImage = global::PryElgueta_IEFI.Properties.Resources.go_back;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(39, 37);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "-";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 756);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.mrcAgregarModificar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmGestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración - Gestion de Usuarios";
            this.Load += new System.EventHandler(this.frmGestionUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            this.mrcAgregarModificar.ResumeLayout(false);
            this.mrcAgregarModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.Label lblDatosDelUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblMostrarDatosDelUsuario;
        private System.Windows.Forms.GroupBox mrcAgregarModificar;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.TextBox txtNombreAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContraseñaAgregar;
        private System.Windows.Forms.RadioButton optInactivo;
        private System.Windows.Forms.RadioButton optActivo;
        private System.Windows.Forms.TextBox txtContraseñaModificar;
        private System.Windows.Forms.TextBox txtNombreModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.CheckBox chkNuevoNombre;
        private System.Windows.Forms.CheckBox chkEstadoUsuario;
        private System.Windows.Forms.CheckBox chkNuevaContraseña;
    }
}