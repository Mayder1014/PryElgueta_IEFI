namespace PryElgueta_IEFI
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.btnMostrarOcultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(125, 117);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(175, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(125, 174);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(175, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(149, 228);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 27);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // imgUsuario
            // 
            this.imgUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.imgUsuario.BackgroundImage = global::PryElgueta_IEFI.Properties.Resources.usuarioLogin;
            this.imgUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgUsuario.Location = new System.Drawing.Point(161, 13);
            this.imgUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(87, 80);
            this.imgUsuario.TabIndex = 6;
            this.imgUsuario.TabStop = false;
            // 
            // btnMostrarOcultar
            // 
            this.btnMostrarOcultar.BackgroundImage = global::PryElgueta_IEFI.Properties.Resources.show;
            this.btnMostrarOcultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMostrarOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarOcultar.Location = new System.Drawing.Point(321, 172);
            this.btnMostrarOcultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarOcultar.Name = "btnMostrarOcultar";
            this.btnMostrarOcultar.Size = new System.Drawing.Size(33, 23);
            this.btnMostrarOcultar.TabIndex = 5;
            this.btnMostrarOcultar.UseVisualStyleBackColor = true;
            this.btnMostrarOcultar.Click += new System.EventHandler(this.btnMostrarOcultar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 278);
            this.Controls.Add(this.imgUsuario);
            this.Controls.Add(this.btnMostrarOcultar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnMostrarOcultar;
        private System.Windows.Forms.PictureBox imgUsuario;
    }
}

