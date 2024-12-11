namespace CapaPresentacion
{
    partial class FrmConsultas
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
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnTelefonosContacto = new System.Windows.Forms.Button();
            this.txtIdContacto = new System.Windows.Forms.TextBox();
            this.dgvTelefonosContacto = new System.Windows.Forms.DataGridView();
            this.btnTodosContactos = new System.Windows.Forms.Button();
            this.btnContactosTelefono = new System.Windows.Forms.Button();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.btnAltaContactos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonosContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContactos
            // 
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(102, 12);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.Size = new System.Drawing.Size(676, 301);
            this.dgvContactos.TabIndex = 3;
            this.dgvContactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_CellContentClick);
            this.dgvContactos.SelectionChanged += new System.EventHandler(this.dgvContactos_SelectionChanged);
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(99, 386);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(679, 38);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTelefonosContacto
            // 
            this.btnTelefonosContacto.Location = new System.Drawing.Point(114, 461);
            this.btnTelefonosContacto.Name = "btnTelefonosContacto";
            this.btnTelefonosContacto.Size = new System.Drawing.Size(138, 37);
            this.btnTelefonosContacto.TabIndex = 5;
            this.btnTelefonosContacto.Text = "Teléfonos de contacto";
            this.btnTelefonosContacto.UseVisualStyleBackColor = true;
            this.btnTelefonosContacto.Click += new System.EventHandler(this.btnTelefonosContacto_Click);
            // 
            // txtIdContacto
            // 
            this.txtIdContacto.Location = new System.Drawing.Point(278, 461);
            this.txtIdContacto.Name = "txtIdContacto";
            this.txtIdContacto.Size = new System.Drawing.Size(42, 20);
            this.txtIdContacto.TabIndex = 6;
            this.txtIdContacto.Text = "14";
            this.txtIdContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvTelefonosContacto
            // 
            this.dgvTelefonosContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonosContacto.Location = new System.Drawing.Point(404, 461);
            this.dgvTelefonosContacto.Name = "dgvTelefonosContacto";
            this.dgvTelefonosContacto.Size = new System.Drawing.Size(334, 125);
            this.dgvTelefonosContacto.TabIndex = 9;
            // 
            // btnTodosContactos
            // 
            this.btnTodosContactos.Location = new System.Drawing.Point(278, 333);
            this.btnTodosContactos.Name = "btnTodosContactos";
            this.btnTodosContactos.Size = new System.Drawing.Size(120, 33);
            this.btnTodosContactos.TabIndex = 10;
            this.btnTodosContactos.Text = "Todos los contactos";
            this.btnTodosContactos.UseVisualStyleBackColor = true;
            this.btnTodosContactos.Click += new System.EventHandler(this.btnTodosContactos_Click);
            // 
            // btnContactosTelefono
            // 
            this.btnContactosTelefono.Location = new System.Drawing.Point(435, 333);
            this.btnContactosTelefono.Name = "btnContactosTelefono";
            this.btnContactosTelefono.Size = new System.Drawing.Size(143, 33);
            this.btnContactosTelefono.TabIndex = 11;
            this.btnContactosTelefono.Text = "Contactos de un teléfono";
            this.btnContactosTelefono.UseVisualStyleBackColor = true;
            this.btnContactosTelefono.Click += new System.EventHandler(this.btnContactosTelefono_Click);
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(613, 339);
            this.txtNumeroTelefono.MaxLength = 9;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(65, 20);
            this.txtNumeroTelefono.TabIndex = 12;
            this.txtNumeroTelefono.Text = "611111111";
            // 
            // btnAltaContactos
            // 
            this.btnAltaContactos.Location = new System.Drawing.Point(132, 332);
            this.btnAltaContactos.Name = "btnAltaContactos";
            this.btnAltaContactos.Size = new System.Drawing.Size(120, 33);
            this.btnAltaContactos.TabIndex = 13;
            this.btnAltaContactos.Text = "Alta de contactos";
            this.btnAltaContactos.UseVisualStyleBackColor = true;
            this.btnAltaContactos.Click += new System.EventHandler(this.btnAltaContactos_Click);
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 599);
            this.Controls.Add(this.btnAltaContactos);
            this.Controls.Add(this.txtNumeroTelefono);
            this.Controls.Add(this.btnContactosTelefono);
            this.Controls.Add(this.btnTodosContactos);
            this.Controls.Add(this.dgvTelefonosContacto);
            this.Controls.Add(this.txtIdContacto);
            this.Controls.Add(this.btnTelefonosContacto);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.dgvContactos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonosContacto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnTelefonosContacto;
        private System.Windows.Forms.TextBox txtIdContacto;
        private System.Windows.Forms.DataGridView dgvTelefonosContacto;
        private System.Windows.Forms.Button btnTodosContactos;
        private System.Windows.Forms.Button btnContactosTelefono;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Button btnAltaContactos;
    }
}

