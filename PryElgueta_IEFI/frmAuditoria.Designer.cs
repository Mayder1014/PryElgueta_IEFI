namespace PryElgueta_IEFI
{
    partial class frmAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoria));
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.mrcElegirOpción = new System.Windows.Forms.GroupBox();
            this.optInfoUsuarios = new System.Windows.Forms.RadioButton();
            this.optEventos = new System.Windows.Forms.RadioButton();
            this.optGeneral = new System.Windows.Forms.RadioButton();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.mrcElegirOpción.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvMostrar.Location = new System.Drawing.Point(12, 111);
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
            this.dgvMostrar.Size = new System.Drawing.Size(1166, 648);
            this.dgvMostrar.TabIndex = 0;
            // 
            // mrcElegirOpción
            // 
            this.mrcElegirOpción.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mrcElegirOpción.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.mrcElegirOpción.Controls.Add(this.optInfoUsuarios);
            this.mrcElegirOpción.Controls.Add(this.optEventos);
            this.mrcElegirOpción.Controls.Add(this.optGeneral);
            this.mrcElegirOpción.ForeColor = System.Drawing.SystemColors.Control;
            this.mrcElegirOpción.Location = new System.Drawing.Point(253, 12);
            this.mrcElegirOpción.Name = "mrcElegirOpción";
            this.mrcElegirOpción.Size = new System.Drawing.Size(685, 83);
            this.mrcElegirOpción.TabIndex = 1;
            this.mrcElegirOpción.TabStop = false;
            this.mrcElegirOpción.Text = "Elegir tipo de auditoria...";
            // 
            // optInfoUsuarios
            // 
            this.optInfoUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.optInfoUsuarios.AutoSize = true;
            this.optInfoUsuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.optInfoUsuarios.Location = new System.Drawing.Point(531, 38);
            this.optInfoUsuarios.Name = "optInfoUsuarios";
            this.optInfoUsuarios.Size = new System.Drawing.Size(125, 20);
            this.optInfoUsuarios.TabIndex = 2;
            this.optInfoUsuarios.TabStop = true;
            this.optInfoUsuarios.Text = "Info de Usuarios";
            this.optInfoUsuarios.UseVisualStyleBackColor = true;
            this.optInfoUsuarios.CheckedChanged += new System.EventHandler(this.optInfoUsuarios_CheckedChanged);
            // 
            // optEventos
            // 
            this.optEventos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.optEventos.AutoSize = true;
            this.optEventos.ForeColor = System.Drawing.SystemColors.Control;
            this.optEventos.Location = new System.Drawing.Point(286, 38);
            this.optEventos.Name = "optEventos";
            this.optEventos.Size = new System.Drawing.Size(77, 20);
            this.optEventos.TabIndex = 1;
            this.optEventos.TabStop = true;
            this.optEventos.Text = "Eventos";
            this.optEventos.UseVisualStyleBackColor = true;
            this.optEventos.CheckedChanged += new System.EventHandler(this.optEventos_CheckedChanged);
            // 
            // optGeneral
            // 
            this.optGeneral.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.optGeneral.AutoSize = true;
            this.optGeneral.Checked = true;
            this.optGeneral.ForeColor = System.Drawing.SystemColors.Control;
            this.optGeneral.Location = new System.Drawing.Point(21, 38);
            this.optGeneral.Name = "optGeneral";
            this.optGeneral.Size = new System.Drawing.Size(76, 20);
            this.optGeneral.TabIndex = 0;
            this.optGeneral.TabStop = true;
            this.optGeneral.Text = "General";
            this.optGeneral.UseVisualStyleBackColor = true;
            this.optGeneral.CheckedChanged += new System.EventHandler(this.optGeneral_CheckedChanged);
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
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "-";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1190, 771);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.mrcElegirOpción);
            this.Controls.Add(this.dgvMostrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración - Auditoria";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.mrcElegirOpción.ResumeLayout(false);
            this.mrcElegirOpción.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.GroupBox mrcElegirOpción;
        private System.Windows.Forms.RadioButton optGeneral;
        private System.Windows.Forms.RadioButton optInfoUsuarios;
        private System.Windows.Forms.RadioButton optEventos;
        private System.Windows.Forms.Button btnVolver;
    }
}