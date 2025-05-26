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
            this.panel1.Location = new System.Drawing.Point(83, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 210);
            this.panel1.TabIndex = 0;
            // 
            // lblMostrarDatosDelUsuario
            // 
            this.lblMostrarDatosDelUsuario.AutoSize = true;
            this.lblMostrarDatosDelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDatosDelUsuario.Location = new System.Drawing.Point(333, 50);
            this.lblMostrarDatosDelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMostrarDatosDelUsuario.Name = "lblMostrarDatosDelUsuario";
            this.lblMostrarDatosDelUsuario.Size = new System.Drawing.Size(119, 143);
            this.lblMostrarDatosDelUsuario.TabIndex = 3;
            this.lblMostrarDatosDelUsuario.Text = "Administrador/Operador\r\n\r\nxxxxxxxxxxxxxxx\r\n\r\ndd/MM/yyyy hh/mm/ss\r\n\r\nhh/mm/ss\r\n\r\nh" +
    "h/mm/ss\r\n\r\nActivo/Inactivo";
            // 
            // lblDatosDelUsuario
            // 
            this.lblDatosDelUsuario.AutoSize = true;
            this.lblDatosDelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosDelUsuario.Location = new System.Drawing.Point(188, 50);
            this.lblDatosDelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosDelUsuario.Name = "lblDatosDelUsuario";
            this.lblDatosDelUsuario.Size = new System.Drawing.Size(125, 143);
            this.lblDatosDelUsuario.TabIndex = 2;
            this.lblDatosDelUsuario.Text = "- Rol:\r\n\r\n- Contraseña:\r\n\r\n- Fecha de creación:\r\n\r\n- Última Conexión:\r\n\r\n- Total " +
    "trabajado:\r\n\r\n- Estado:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(187, 20);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(183, 17);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "NOMBRE DEL USUARIO";
            // 
            // imgUsuario
            // 
            this.imgUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imgUsuario.BackgroundImage = global::PryElgueta_IEFI.Properties.Resources.administrador;
            this.imgUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgUsuario.Location = new System.Drawing.Point(27, 39);
            this.imgUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(134, 132);
            this.imgUsuario.TabIndex = 0;
            this.imgUsuario.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAtras.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAtras.BackgroundImage = global::PryElgueta_IEFI.Properties.Resources.left;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtras.Location = new System.Drawing.Point(33, 112);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(28, 28);
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
            this.btnSiguiente.Location = new System.Drawing.Point(602, 112);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(28, 28);
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
            this.mrcAgregarModificar.Location = new System.Drawing.Point(33, 273);
            this.mrcAgregarModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcAgregarModificar.Name = "mrcAgregarModificar";
            this.mrcAgregarModificar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcAgregarModificar.Size = new System.Drawing.Size(597, 327);
            this.mrcAgregarModificar.TabIndex = 3;
            this.mrcAgregarModificar.TabStop = false;
            this.mrcAgregarModificar.Text = "Agregar o Modificar Usuario...";
            // 
            // chkEstadoUsuario
            // 
            this.chkEstadoUsuario.AutoSize = true;
            this.chkEstadoUsuario.Location = new System.Drawing.Point(358, 223);
            this.chkEstadoUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkEstadoUsuario.Name = "chkEstadoUsuario";
            this.chkEstadoUsuario.Size = new System.Drawing.Size(115, 17);
            this.chkEstadoUsuario.TabIndex = 16;
            this.chkEstadoUsuario.Text = "Estado del Usuario";
            this.chkEstadoUsuario.UseVisualStyleBackColor = true;
            this.chkEstadoUsuario.CheckedChanged += new System.EventHandler(this.chkEstadoUsuario_CheckedChanged);
            // 
            // chkNuevaContraseña
            // 
            this.chkNuevaContraseña.AutoSize = true;
            this.chkNuevaContraseña.Location = new System.Drawing.Point(358, 176);
            this.chkNuevaContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkNuevaContraseña.Name = "chkNuevaContraseña";
            this.chkNuevaContraseña.Size = new System.Drawing.Size(171, 17);
            this.chkNuevaContraseña.TabIndex = 15;
            this.chkNuevaContraseña.Text = "Nueva contraseña de Usuario:";
            this.chkNuevaContraseña.UseVisualStyleBackColor = true;
            this.chkNuevaContraseña.CheckedChanged += new System.EventHandler(this.chkNuevaContraseña_CheckedChanged);
            // 
            // chkNuevoNombre
            // 
            this.chkNuevoNombre.AutoSize = true;
            this.chkNuevoNombre.Location = new System.Drawing.Point(358, 132);
            this.chkNuevoNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkNuevoNombre.Name = "chkNuevoNombre";
            this.chkNuevoNombre.Size = new System.Drawing.Size(153, 17);
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
            this.lblNota.Location = new System.Drawing.Point(16, 27);
            this.lblNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(570, 60);
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
            this.label7.Location = new System.Drawing.Point(373, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 15);
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
            this.label6.Location = new System.Drawing.Point(80, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
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
            this.btnModificarUsuario.Location = new System.Drawing.Point(386, 280);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(110, 24);
            this.btnModificarUsuario.TabIndex = 4;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(94, 280);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(110, 24);
            this.btnAgregarUsuario.TabIndex = 6;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // txtContraseñaModificar
            // 
            this.txtContraseñaModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseñaModificar.Enabled = false;
            this.txtContraseñaModificar.Location = new System.Drawing.Point(358, 197);
            this.txtContraseñaModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContraseñaModificar.Name = "txtContraseñaModificar";
            this.txtContraseñaModificar.Size = new System.Drawing.Size(170, 20);
            this.txtContraseñaModificar.TabIndex = 7;
            this.txtContraseñaModificar.TextChanged += new System.EventHandler(this.txtContraseñaModificar_TextChanged);
            // 
            // txtNombreModificar
            // 
            this.txtNombreModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreModificar.Enabled = false;
            this.txtNombreModificar.Location = new System.Drawing.Point(358, 153);
            this.txtNombreModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreModificar.Name = "txtNombreModificar";
            this.txtNombreModificar.Size = new System.Drawing.Size(170, 20);
            this.txtNombreModificar.TabIndex = 6;
            this.txtNombreModificar.TextChanged += new System.EventHandler(this.txtNombreModificar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña de Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // txtContraseñaAgregar
            // 
            this.txtContraseñaAgregar.Location = new System.Drawing.Point(68, 219);
            this.txtContraseñaAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContraseñaAgregar.Name = "txtContraseñaAgregar";
            this.txtContraseñaAgregar.Size = new System.Drawing.Size(170, 20);
            this.txtContraseñaAgregar.TabIndex = 3;
            // 
            // optInactivo
            // 
            this.optInactivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optInactivo.AutoSize = true;
            this.optInactivo.Enabled = false;
            this.optInactivo.Location = new System.Drawing.Point(464, 245);
            this.optInactivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optInactivo.Name = "optInactivo";
            this.optInactivo.Size = new System.Drawing.Size(63, 17);
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
            this.optActivo.Location = new System.Drawing.Point(358, 245);
            this.optActivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optActivo.Name = "optActivo";
            this.optActivo.Size = new System.Drawing.Size(55, 17);
            this.optActivo.TabIndex = 1;
            this.optActivo.Text = "Activo";
            this.optActivo.UseVisualStyleBackColor = true;
            this.optActivo.CheckedChanged += new System.EventHandler(this.optActivo_CheckedChanged);
            // 
            // txtNombreAgregar
            // 
            this.txtNombreAgregar.Location = new System.Drawing.Point(68, 172);
            this.txtNombreAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreAgregar.Name = "txtNombreAgregar";
            this.txtNombreAgregar.Size = new System.Drawing.Size(170, 20);
            this.txtNombreAgregar.TabIndex = 0;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(273, 237);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(110, 24);
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
            this.btnVolver.Location = new System.Drawing.Point(9, 10);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(29, 30);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "-";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 614);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.mrcAgregarModificar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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