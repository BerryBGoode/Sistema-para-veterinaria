namespace Vista
{
    partial class FrmPrimerEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrimerEmpleado));
            this.lblInfoRegistrarEmp = new System.Windows.Forms.Label();
            this.lblRegistrarEmp = new System.Windows.Forms.Label();
            this.grbDatosNuevoEmp = new System.Windows.Forms.GroupBox();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblAgregarDatosNuevoEmp = new System.Windows.Forms.Label();
            this.pnlContacto = new System.Windows.Forms.Panel();
            this.txtNumContacto = new System.Windows.Forms.TextBox();
            this.lblNumTelsNuevoEmp = new System.Windows.Forms.Label();
            this.chkContacto = new System.Windows.Forms.CheckBox();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.lblMunicipioNuevoEmp = new System.Windows.Forms.Label();
            this.txtNumdoc = new System.Windows.Forms.TextBox();
            this.lblNumDocNuevoEmp = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbTipodocumento = new System.Windows.Forms.ComboBox();
            this.lblDepartamentoNuevo = new System.Windows.Forms.Label();
            this.lblTipoDocNuevoEmp = new System.Windows.Forms.Label();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNacimientoNuevoEmp = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidosNuevoEmp = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreNuevoEmp = new System.Windows.Forms.Label();
            this.grbDatosNuevoEmp.SuspendLayout();
            this.pnlAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            this.pnlContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfoRegistrarEmp
            // 
            this.lblInfoRegistrarEmp.AutoSize = true;
            this.lblInfoRegistrarEmp.Location = new System.Drawing.Point(21, 33);
            this.lblInfoRegistrarEmp.Name = "lblInfoRegistrarEmp";
            this.lblInfoRegistrarEmp.Size = new System.Drawing.Size(860, 60);
            this.lblInfoRegistrarEmp.TabIndex = 0;
            this.lblInfoRegistrarEmp.Text = resources.GetString("lblInfoRegistrarEmp.Text");
            // 
            // lblRegistrarEmp
            // 
            this.lblRegistrarEmp.AutoSize = true;
            this.lblRegistrarEmp.Location = new System.Drawing.Point(21, 108);
            this.lblRegistrarEmp.Name = "lblRegistrarEmp";
            this.lblRegistrarEmp.Size = new System.Drawing.Size(439, 20);
            this.lblRegistrarEmp.TabIndex = 1;
            this.lblRegistrarEmp.Text = "El primer empleado que registres tendrá que ser un gerente";
            // 
            // grbDatosNuevoEmp
            // 
            this.grbDatosNuevoEmp.Controls.Add(this.pnlAgregar);
            this.grbDatosNuevoEmp.Controls.Add(this.pnlContacto);
            this.grbDatosNuevoEmp.Controls.Add(this.chkContacto);
            this.grbDatosNuevoEmp.Controls.Add(this.cmbMunicipio);
            this.grbDatosNuevoEmp.Controls.Add(this.lblMunicipioNuevoEmp);
            this.grbDatosNuevoEmp.Controls.Add(this.txtNumdoc);
            this.grbDatosNuevoEmp.Controls.Add(this.lblNumDocNuevoEmp);
            this.grbDatosNuevoEmp.Controls.Add(this.cmbDepartamento);
            this.grbDatosNuevoEmp.Controls.Add(this.cmbTipodocumento);
            this.grbDatosNuevoEmp.Controls.Add(this.lblDepartamentoNuevo);
            this.grbDatosNuevoEmp.Controls.Add(this.lblTipoDocNuevoEmp);
            this.grbDatosNuevoEmp.Controls.Add(this.dtNacimiento);
            this.grbDatosNuevoEmp.Controls.Add(this.lblNacimientoNuevoEmp);
            this.grbDatosNuevoEmp.Controls.Add(this.txtApellidos);
            this.grbDatosNuevoEmp.Controls.Add(this.lblApellidosNuevoEmp);
            this.grbDatosNuevoEmp.Controls.Add(this.txtNombre);
            this.grbDatosNuevoEmp.Controls.Add(this.lblNombreNuevoEmp);
            this.grbDatosNuevoEmp.Location = new System.Drawing.Point(25, 158);
            this.grbDatosNuevoEmp.Name = "grbDatosNuevoEmp";
            this.grbDatosNuevoEmp.Size = new System.Drawing.Size(864, 290);
            this.grbDatosNuevoEmp.TabIndex = 2;
            this.grbDatosNuevoEmp.TabStop = false;
            this.grbDatosNuevoEmp.Text = "Datos del nuevo empleado";
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.Controls.Add(this.btnAgregar);
            this.pnlAgregar.Controls.Add(this.lblAgregarDatosNuevoEmp);
            this.pnlAgregar.Location = new System.Drawing.Point(738, 214);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(118, 58);
            this.pnlAgregar.TabIndex = 18;
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
            this.lblAgregarDatosNuevoEmp.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAgregarDatosNuevoEmp.Location = new System.Drawing.Point(12, 10);
            this.lblAgregarDatosNuevoEmp.Name = "lblAgregarDatosNuevoEmp";
            this.lblAgregarDatosNuevoEmp.Size = new System.Drawing.Size(64, 40);
            this.lblAgregarDatosNuevoEmp.TabIndex = 4;
            this.lblAgregarDatosNuevoEmp.Text = "Agregar\r\ndatos";
            // 
            // pnlContacto
            // 
            this.pnlContacto.Controls.Add(this.txtNumContacto);
            this.pnlContacto.Controls.Add(this.lblNumTelsNuevoEmp);
            this.pnlContacto.Enabled = false;
            this.pnlContacto.Location = new System.Drawing.Point(526, 14);
            this.pnlContacto.Name = "pnlContacto";
            this.pnlContacto.Size = new System.Drawing.Size(330, 97);
            this.pnlContacto.TabIndex = 15;
            // 
            // txtNumContacto
            // 
            this.txtNumContacto.Location = new System.Drawing.Point(16, 39);
            this.txtNumContacto.Name = "txtNumContacto";
            this.txtNumContacto.Size = new System.Drawing.Size(223, 25);
            this.txtNumContacto.TabIndex = 8;
            this.txtNumContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumContacto_KeyPress);
            // 
            // lblNumTelsNuevoEmp
            // 
            this.lblNumTelsNuevoEmp.AutoSize = true;
            this.lblNumTelsNuevoEmp.Location = new System.Drawing.Point(12, 16);
            this.lblNumTelsNuevoEmp.Name = "lblNumTelsNuevoEmp";
            this.lblNumTelsNuevoEmp.Size = new System.Drawing.Size(151, 20);
            this.lblNumTelsNuevoEmp.TabIndex = 0;
            this.lblNumTelsNuevoEmp.Text = "Número de teléfono";
            // 
            // chkContacto
            // 
            this.chkContacto.AutoSize = true;
            this.chkContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkContacto.Location = new System.Drawing.Point(295, 248);
            this.chkContacto.Name = "chkContacto";
            this.chkContacto.Size = new System.Drawing.Size(159, 24);
            this.chkContacto.TabIndex = 7;
            this.chkContacto.Text = "Registrar contacto";
            this.chkContacto.UseVisualStyleBackColor = true;
            this.chkContacto.CheckedChanged += new System.EventHandler(this.chkContacto_CheckedChanged);
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(37, 244);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(223, 28);
            this.cmbMunicipio.TabIndex = 6;
            // 
            // lblMunicipioNuevoEmp
            // 
            this.lblMunicipioNuevoEmp.AutoSize = true;
            this.lblMunicipioNuevoEmp.Location = new System.Drawing.Point(37, 221);
            this.lblMunicipioNuevoEmp.Name = "lblMunicipioNuevoEmp";
            this.lblMunicipioNuevoEmp.Size = new System.Drawing.Size(82, 20);
            this.lblMunicipioNuevoEmp.TabIndex = 12;
            this.lblMunicipioNuevoEmp.Text = "Municipio:";
            // 
            // txtNumdoc
            // 
            this.txtNumdoc.Location = new System.Drawing.Point(295, 174);
            this.txtNumdoc.Name = "txtNumdoc";
            this.txtNumdoc.Size = new System.Drawing.Size(223, 25);
            this.txtNumdoc.TabIndex = 4;
            this.txtNumdoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoc_KeyPress);
            // 
            // lblNumDocNuevoEmp
            // 
            this.lblNumDocNuevoEmp.AutoSize = true;
            this.lblNumDocNuevoEmp.Location = new System.Drawing.Point(291, 155);
            this.lblNumDocNuevoEmp.Name = "lblNumDocNuevoEmp";
            this.lblNumDocNuevoEmp.Size = new System.Drawing.Size(177, 20);
            this.lblNumDocNuevoEmp.TabIndex = 9;
            this.lblNumDocNuevoEmp.Text = "Número de documento:";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(37, 174);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(223, 28);
            this.cmbDepartamento.TabIndex = 5;
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // cmbTipodocumento
            // 
            this.cmbTipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipodocumento.FormattingEnabled = true;
            this.cmbTipodocumento.Location = new System.Drawing.Point(295, 114);
            this.cmbTipodocumento.Name = "cmbTipodocumento";
            this.cmbTipodocumento.Size = new System.Drawing.Size(223, 28);
            this.cmbTipodocumento.TabIndex = 3;
            // 
            // lblDepartamentoNuevo
            // 
            this.lblDepartamentoNuevo.AutoSize = true;
            this.lblDepartamentoNuevo.Location = new System.Drawing.Point(33, 155);
            this.lblDepartamentoNuevo.Name = "lblDepartamentoNuevo";
            this.lblDepartamentoNuevo.Size = new System.Drawing.Size(116, 20);
            this.lblDepartamentoNuevo.TabIndex = 10;
            this.lblDepartamentoNuevo.Text = "Departamento:";
            // 
            // lblTipoDocNuevoEmp
            // 
            this.lblTipoDocNuevoEmp.AutoSize = true;
            this.lblTipoDocNuevoEmp.Location = new System.Drawing.Point(291, 92);
            this.lblTipoDocNuevoEmp.Name = "lblTipoDocNuevoEmp";
            this.lblTipoDocNuevoEmp.Size = new System.Drawing.Size(151, 20);
            this.lblTipoDocNuevoEmp.TabIndex = 6;
            this.lblTipoDocNuevoEmp.Text = "Tipo de documento:";
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.CustomFormat = "yyyy-MM-dd";
            this.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNacimiento.Location = new System.Drawing.Point(37, 113);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(223, 25);
            this.dtNacimiento.TabIndex = 2;
            // 
            // lblNacimientoNuevoEmp
            // 
            this.lblNacimientoNuevoEmp.AutoSize = true;
            this.lblNacimientoNuevoEmp.Location = new System.Drawing.Point(33, 91);
            this.lblNacimientoNuevoEmp.Name = "lblNacimientoNuevoEmp";
            this.lblNacimientoNuevoEmp.Size = new System.Drawing.Size(163, 20);
            this.lblNacimientoNuevoEmp.TabIndex = 4;
            this.lblNacimientoNuevoEmp.Text = "Fecha de nacimiento:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(295, 53);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(223, 25);
            this.txtApellidos.TabIndex = 1;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // lblApellidosNuevoEmp
            // 
            this.lblApellidosNuevoEmp.AutoSize = true;
            this.lblApellidosNuevoEmp.Location = new System.Drawing.Point(291, 30);
            this.lblApellidosNuevoEmp.Name = "lblApellidosNuevoEmp";
            this.lblApellidosNuevoEmp.Size = new System.Drawing.Size(78, 20);
            this.lblApellidosNuevoEmp.TabIndex = 2;
            this.lblApellidosNuevoEmp.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(37, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 25);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_Apellidos_KeyPress);
            // 
            // lblNombreNuevoEmp
            // 
            this.lblNombreNuevoEmp.AutoSize = true;
            this.lblNombreNuevoEmp.Location = new System.Drawing.Point(33, 30);
            this.lblNombreNuevoEmp.Name = "lblNombreNuevoEmp";
            this.lblNombreNuevoEmp.Size = new System.Drawing.Size(76, 20);
            this.lblNombreNuevoEmp.TabIndex = 0;
            this.lblNombreNuevoEmp.Text = "Nombres:";
            // 
            // FrmPrimerEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 469);
            this.Controls.Add(this.grbDatosNuevoEmp);
            this.Controls.Add(this.lblRegistrarEmp);
            this.Controls.Add(this.lblInfoRegistrarEmp);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrimerEmpleado";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrimerEmpleado";
            this.Load += new System.EventHandler(this.FrmPrimerEmpleado_Load);
            this.grbDatosNuevoEmp.ResumeLayout(false);
            this.grbDatosNuevoEmp.PerformLayout();
            this.pnlAgregar.ResumeLayout(false);
            this.pnlAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            this.pnlContacto.ResumeLayout(false);
            this.pnlContacto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoRegistrarEmp;
        private System.Windows.Forms.Label lblRegistrarEmp;
        private System.Windows.Forms.GroupBox grbDatosNuevoEmp;
        private System.Windows.Forms.Label lblNombreNuevoEmp;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.Label lblNacimientoNuevoEmp;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidosNuevoEmp;
        private System.Windows.Forms.TextBox txtNumdoc;
        private System.Windows.Forms.Label lblNumDocNuevoEmp;
        private System.Windows.Forms.ComboBox cmbTipodocumento;
        private System.Windows.Forms.Label lblTipoDocNuevoEmp;
        private System.Windows.Forms.Panel pnlContacto;
        private System.Windows.Forms.TextBox txtNumContacto;
        private System.Windows.Forms.Label lblNumTelsNuevoEmp;
        private System.Windows.Forms.CheckBox chkContacto;
        private System.Windows.Forms.ComboBox cmbMunicipio;
        private System.Windows.Forms.Label lblMunicipioNuevoEmp;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblDepartamentoNuevo;
        private System.Windows.Forms.Panel pnlAgregar;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregar;
        private System.Windows.Forms.Label lblAgregarDatosNuevoEmp;
    }
}