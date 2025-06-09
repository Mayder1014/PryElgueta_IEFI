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
            this.panelInfoInstrucciones = new System.Windows.Forms.Panel();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.panelOperaciones = new System.Windows.Forms.Panel();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblMostrarUsuarioSeleccionado = new System.Windows.Forms.Label();
            this.lblUsuarioSeleccionado = new System.Windows.Forms.Label();
            this.lblVolverMenuPrincipal = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panelInfoInstrucciones.SuspendLayout();
            this.panelOperaciones.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfoInstrucciones
            // 
            this.panelInfoInstrucciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panelInfoInstrucciones.Controls.Add(this.lblInstrucciones);
            this.panelInfoInstrucciones.Controls.Add(this.lblNota);
            this.panelInfoInstrucciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfoInstrucciones.Location = new System.Drawing.Point(0, 332);
            this.panelInfoInstrucciones.Margin = new System.Windows.Forms.Padding(2);
            this.panelInfoInstrucciones.Name = "panelInfoInstrucciones";
            this.panelInfoInstrucciones.Size = new System.Drawing.Size(963, 282);
            this.panelInfoInstrucciones.TabIndex = 7;
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInstrucciones.Location = new System.Drawing.Point(6, 91);
            this.lblInstrucciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(955, 165);
            this.lblInstrucciones.TabIndex = 15;
            this.lblInstrucciones.Text = resources.GetString("lblInstrucciones.Text");
            this.lblInstrucciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNota
            // 
            this.lblNota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNota.Location = new System.Drawing.Point(6, 24);
            this.lblNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(921, 45);
            this.lblNota.TabIndex = 14;
            this.lblNota.Text = resources.GetString("lblNota.Text");
            this.lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelOperaciones
            // 
            this.panelOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panelOperaciones.Controls.Add(this.btnEliminarUsuario);
            this.panelOperaciones.Controls.Add(this.btnModificarUsuario);
            this.panelOperaciones.Controls.Add(this.btnAgregarUsuario);
            this.panelOperaciones.Controls.Add(this.panelSuperior);
            this.panelOperaciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOperaciones.Location = new System.Drawing.Point(0, 0);
            this.panelOperaciones.Margin = new System.Windows.Forms.Padding(2);
            this.panelOperaciones.Name = "panelOperaciones";
            this.panelOperaciones.Size = new System.Drawing.Size(221, 332);
            this.panelOperaciones.TabIndex = 8;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Image = global::PryElgueta_IEFI.Properties.Resources.delete_user;
            this.btnEliminarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(0, 192);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(221, 43);
            this.btnEliminarUsuario.TabIndex = 16;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModificarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Image = global::PryElgueta_IEFI.Properties.Resources.user_edit;
            this.btnModificarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarUsuario.Location = new System.Drawing.Point(0, 149);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(221, 43);
            this.btnModificarUsuario.TabIndex = 15;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.Image = global::PryElgueta_IEFI.Properties.Resources.add_user;
            this.btnAgregarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(0, 106);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(221, 43);
            this.btnAgregarUsuario.TabIndex = 10;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panelSuperior.Controls.Add(this.lblMostrarUsuarioSeleccionado);
            this.panelSuperior.Controls.Add(this.lblUsuarioSeleccionado);
            this.panelSuperior.Controls.Add(this.lblVolverMenuPrincipal);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(221, 106);
            this.panelSuperior.TabIndex = 9;
            // 
            // lblMostrarUsuarioSeleccionado
            // 
            this.lblMostrarUsuarioSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMostrarUsuarioSeleccionado.AutoSize = true;
            this.lblMostrarUsuarioSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarUsuarioSeleccionado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMostrarUsuarioSeleccionado.Location = new System.Drawing.Point(7, 76);
            this.lblMostrarUsuarioSeleccionado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMostrarUsuarioSeleccionado.Name = "lblMostrarUsuarioSeleccionado";
            this.lblMostrarUsuarioSeleccionado.Size = new System.Drawing.Size(35, 13);
            this.lblMostrarUsuarioSeleccionado.TabIndex = 25;
            this.lblMostrarUsuarioSeleccionado.Text = "- - - -";
            // 
            // lblUsuarioSeleccionado
            // 
            this.lblUsuarioSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsuarioSeleccionado.AutoSize = true;
            this.lblUsuarioSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioSeleccionado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuarioSeleccionado.Location = new System.Drawing.Point(7, 58);
            this.lblUsuarioSeleccionado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuarioSeleccionado.Name = "lblUsuarioSeleccionado";
            this.lblUsuarioSeleccionado.Size = new System.Drawing.Size(166, 13);
            this.lblUsuarioSeleccionado.TabIndex = 24;
            this.lblUsuarioSeleccionado.Text = "USUARIO SELECCIONADO:";
            // 
            // lblVolverMenuPrincipal
            // 
            this.lblVolverMenuPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVolverMenuPrincipal.AutoSize = true;
            this.lblVolverMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolverMenuPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(180)))), ((int)(((byte)(98)))));
            this.lblVolverMenuPrincipal.Location = new System.Drawing.Point(43, 18);
            this.lblVolverMenuPrincipal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolverMenuPrincipal.Name = "lblVolverMenuPrincipal";
            this.lblVolverMenuPrincipal.Size = new System.Drawing.Size(145, 13);
            this.lblVolverMenuPrincipal.TabIndex = 23;
            this.lblVolverMenuPrincipal.Text = "Volver al Menu Principal";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(221, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(742, 332);
            this.panelContenedor.TabIndex = 11;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(180)))), ((int)(((byte)(98)))));
            this.btnVolver.BackgroundImage = global::PryElgueta_IEFI.Properties.Resources.go_back;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.Location = new System.Drawing.Point(9, 10);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(963, 614);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelOperaciones);
            this.Controls.Add(this.panelInfoInstrucciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmGestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración - Gestion de Usuarios";
            this.Load += new System.EventHandler(this.frmGestionUsuarios_Load);
            this.panelInfoInstrucciones.ResumeLayout(false);
            this.panelInfoInstrucciones.PerformLayout();
            this.panelOperaciones.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panelInfoInstrucciones;
        private System.Windows.Forms.Panel panelOperaciones;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblVolverMenuPrincipal;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Label lblMostrarUsuarioSeleccionado;
        private System.Windows.Forms.Label lblUsuarioSeleccionado;
        private System.Windows.Forms.Label lblInstrucciones;
    }
}