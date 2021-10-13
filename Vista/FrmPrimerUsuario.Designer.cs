namespace Vista
{
    partial class FrmPrimerUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrimerUsuario));
            this.lblHolaPrimerUsuario = new System.Windows.Forms.Label();
            this.lblReglesPrimerUsuario = new System.Windows.Forms.Label();
            this.lblNombreNuevoUsu = new System.Windows.Forms.Label();
            this.grpDatosNuevoUsuario = new System.Windows.Forms.GroupBox();
            this.txtIDempleado = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreoNuevoUsu = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.lblSelecEmpleados = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkSelect = new System.Windows.Forms.CheckBox();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblAgregarDatosNuevoEmp = new System.Windows.Forms.Label();
            this.grpDatosNuevoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.pnlAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHolaPrimerUsuario
            // 
            this.lblHolaPrimerUsuario.AutoSize = true;
            this.lblHolaPrimerUsuario.Location = new System.Drawing.Point(18, 23);
            this.lblHolaPrimerUsuario.Name = "lblHolaPrimerUsuario";
            this.lblHolaPrimerUsuario.Size = new System.Drawing.Size(827, 40);
            this.lblHolaPrimerUsuario.TabIndex = 0;
            this.lblHolaPrimerUsuario.Text = "Hola de nuevo, como acabas de ingresar al primer empleado ahora lo que prosigue e" +
    "s agregar al primer usuario con\r\neso bastaría, para que puedas comenzar a ver el" +
    " sistema y útilizarlo\r\n";
            // 
            // lblReglesPrimerUsuario
            // 
            this.lblReglesPrimerUsuario.AutoSize = true;
            this.lblReglesPrimerUsuario.Location = new System.Drawing.Point(18, 85);
            this.lblReglesPrimerUsuario.Name = "lblReglesPrimerUsuario";
            this.lblReglesPrimerUsuario.Size = new System.Drawing.Size(536, 80);
            this.lblReglesPrimerUsuario.TabIndex = 1;
            this.lblReglesPrimerUsuario.Text = resources.GetString("lblReglesPrimerUsuario.Text");
            // 
            // lblNombreNuevoUsu
            // 
            this.lblNombreNuevoUsu.AutoSize = true;
            this.lblNombreNuevoUsu.Location = new System.Drawing.Point(21, 39);
            this.lblNombreNuevoUsu.Name = "lblNombreNuevoUsu";
            this.lblNombreNuevoUsu.Size = new System.Drawing.Size(148, 20);
            this.lblNombreNuevoUsu.TabIndex = 2;
            this.lblNombreNuevoUsu.Text = "Nombre de usuario:";
            // 
            // grpDatosNuevoUsuario
            // 
            this.grpDatosNuevoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.grpDatosNuevoUsuario.Controls.Add(this.txtIDempleado);
            this.grpDatosNuevoUsuario.Controls.Add(this.txtCorreo);
            this.grpDatosNuevoUsuario.Controls.Add(this.lblCorreoNuevoUsu);
            this.grpDatosNuevoUsuario.Controls.Add(this.txtUsuario);
            this.grpDatosNuevoUsuario.Controls.Add(this.lblNombreNuevoUsu);
            this.grpDatosNuevoUsuario.Location = new System.Drawing.Point(22, 188);
            this.grpDatosNuevoUsuario.Name = "grpDatosNuevoUsuario";
            this.grpDatosNuevoUsuario.Size = new System.Drawing.Size(283, 255);
            this.grpDatosNuevoUsuario.TabIndex = 3;
            this.grpDatosNuevoUsuario.TabStop = false;
            this.grpDatosNuevoUsuario.Text = "Datos del nuevo usuario";
            // 
            // txtIDempleado
            // 
            this.txtIDempleado.Location = new System.Drawing.Point(25, 202);
            this.txtIDempleado.Name = "txtIDempleado";
            this.txtIDempleado.Size = new System.Drawing.Size(227, 25);
            this.txtIDempleado.TabIndex = 6;
            this.txtIDempleado.Visible = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(25, 137);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(227, 25);
            this.txtCorreo.TabIndex = 5;
            // 
            // lblCorreoNuevoUsu
            // 
            this.lblCorreoNuevoUsu.AutoSize = true;
            this.lblCorreoNuevoUsu.Location = new System.Drawing.Point(21, 113);
            this.lblCorreoNuevoUsu.Name = "lblCorreoNuevoUsu";
            this.lblCorreoNuevoUsu.Size = new System.Drawing.Size(61, 20);
            this.lblCorreoNuevoUsu.TabIndex = 4;
            this.lblCorreoNuevoUsu.Text = "Correo:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(25, 63);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(227, 25);
            this.txtUsuario.TabIndex = 3;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Location = new System.Drawing.Point(311, 217);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.RowTemplate.Height = 24;
            this.dgvEmpleado.Size = new System.Drawing.Size(539, 107);
            this.dgvEmpleado.TabIndex = 4;
            this.dgvEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellClick);
            // 
            // lblSelecEmpleados
            // 
            this.lblSelecEmpleados.AutoSize = true;
            this.lblSelecEmpleados.Location = new System.Drawing.Point(310, 188);
            this.lblSelecEmpleados.Name = "lblSelecEmpleados";
            this.lblSelecEmpleados.Size = new System.Drawing.Size(243, 20);
            this.lblSelecEmpleados.TabIndex = 5;
            this.lblSelecEmpleados.Text = "Selecciona el empleado que eres";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-19, -19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkSelect
            // 
            this.chkSelect.AutoSize = true;
            this.chkSelect.Enabled = false;
            this.chkSelect.Location = new System.Drawing.Point(504, 191);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(18, 17);
            this.chkSelect.TabIndex = 8;
            this.chkSelect.UseVisualStyleBackColor = true;
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.Controls.Add(this.btnAgregar);
            this.pnlAgregar.Controls.Add(this.lblAgregarDatosNuevoEmp);
            this.pnlAgregar.Location = new System.Drawing.Point(727, 385);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(118, 58);
            this.pnlAgregar.TabIndex = 19;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregar.Image = global::Vista.Properties.Resources.add_100px;
            this.btnAgregar.ImageActive = null;
            this.btnAgregar.Location = new System.Drawing.Point(83, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(35, 58);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Zoom = 10;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAgregarDatosNuevoEmp
            // 
            this.lblAgregarDatosNuevoEmp.AutoSize = true;
            this.lblAgregarDatosNuevoEmp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblAgregarDatosNuevoEmp.Location = new System.Drawing.Point(12, 10);
            this.lblAgregarDatosNuevoEmp.Name = "lblAgregarDatosNuevoEmp";
            this.lblAgregarDatosNuevoEmp.Size = new System.Drawing.Size(64, 40);
            this.lblAgregarDatosNuevoEmp.TabIndex = 4;
            this.lblAgregarDatosNuevoEmp.Text = "Agregar\r\ndatos";
            // 
            // FrmPrimerUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(862, 455);
            this.Controls.Add(this.pnlAgregar);
            this.Controls.Add(this.chkSelect);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblSelecEmpleados);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.grpDatosNuevoUsuario);
            this.Controls.Add(this.lblReglesPrimerUsuario);
            this.Controls.Add(this.lblHolaPrimerUsuario);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrimerUsuario";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrimerUsuario";
            this.Load += new System.EventHandler(this.FrmPrimerUsuario_Load);
            this.grpDatosNuevoUsuario.ResumeLayout(false);
            this.grpDatosNuevoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.pnlAgregar.ResumeLayout(false);
            this.pnlAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHolaPrimerUsuario;
        private System.Windows.Forms.Label lblReglesPrimerUsuario;
        private System.Windows.Forms.Label lblNombreNuevoUsu;
        private System.Windows.Forms.GroupBox grpDatosNuevoUsuario;
        private System.Windows.Forms.TextBox txtIDempleado;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreoNuevoUsu;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.Label lblSelecEmpleados;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkSelect;
        private System.Windows.Forms.Panel pnlAgregar;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregar;
        private System.Windows.Forms.Label lblAgregarDatosNuevoEmp;
    }
}