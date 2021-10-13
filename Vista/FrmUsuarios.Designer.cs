namespace Vista
{
    partial class FrmUsuarios
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
            this.components = new System.ComponentModel.Container();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBackForm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsFrm = new System.Windows.Forms.ToolStripLabel();
            this.txtIdUsuario = new System.Windows.Forms.ToolStripTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblListaEmpleados = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLimpiarCampos = new System.Windows.Forms.Panel();
            this.btnLimpiarCampos = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblLimpiar = new System.Windows.Forms.Label();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.pnlActualizar = new System.Windows.Forms.Panel();
            this.btnActualizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblActualizar = new System.Windows.Forms.Label();
            this.pnlMostrar = new System.Windows.Forms.Panel();
            this.lblmostrar = new System.Windows.Forms.Label();
            this.btnMostrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.lblNumeroEmpleado = new System.Windows.Forms.Label();
            this.txtNombreUser = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlRecargar = new System.Windows.Forms.Panel();
            this.btnRecargar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblRecargar1 = new System.Windows.Forms.Label();
            this.lblDescripBuscar = new System.Windows.Forms.Label();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblBuscar1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.pnlBuscar2 = new System.Windows.Forms.Panel();
            this.btnBuscarempleado = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblBuscar2 = new System.Windows.Forms.Label();
            this.lblDescripBuscar2 = new System.Windows.Forms.Label();
            this.pnlRecargar2 = new System.Windows.Forms.Panel();
            this.btnRecargar2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblRecargar2 = new System.Windows.Forms.Label();
            this.lblListaUsuarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlLimpiarCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiarCampos)).BeginInit();
            this.pnlEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            this.pnlActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).BeginInit();
            this.pnlMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrar)).BeginInit();
            this.pnlAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlRecargar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).BeginInit();
            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.pnlBuscar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarempleado)).BeginInit();
            this.pnlRecargar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(430, 116);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(633, 266);
            this.dgvEmpleados.TabIndex = 16;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(167, 409);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(896, 257);
            this.dgvUsuarios.TabIndex = 17;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBackForm,
            this.toolStripSeparator1,
            this.tlsFrm,
            this.txtIdUsuario});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1083, 27);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBackForm
            // 
            this.btnBackForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBackForm.Image = global::Vista.Properties.Resources.back_to_100px;
            this.btnBackForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBackForm.Name = "btnBackForm";
            this.btnBackForm.Size = new System.Drawing.Size(24, 24);
            this.btnBackForm.Text = "Cerrar formulario";
            this.btnBackForm.Click += new System.EventHandler(this.btnBackForm_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tlsFrm
            // 
            this.tlsFrm.Name = "tlsFrm";
            this.tlsFrm.Size = new System.Drawing.Size(186, 24);
            this.tlsFrm.Text = "Formulario para usuarios:";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(100, 27);
            this.txtIdUsuario.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblListaEmpleados
            // 
            this.lblListaEmpleados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblListaEmpleados.AutoSize = true;
            this.lblListaEmpleados.Location = new System.Drawing.Point(426, 93);
            this.lblListaEmpleados.Name = "lblListaEmpleados";
            this.lblListaEmpleados.Size = new System.Drawing.Size(144, 20);
            this.lblListaEmpleados.TabIndex = 22;
            this.lblListaEmpleados.Text = "Lista de empleados";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(15, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 309);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlLimpiarCampos);
            this.panel1.Controls.Add(this.pnlEliminar);
            this.panel1.Controls.Add(this.pnlActualizar);
            this.panel1.Controls.Add(this.pnlMostrar);
            this.panel1.Controls.Add(this.pnlAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 285);
            this.panel1.TabIndex = 1;
            // 
            // pnlLimpiarCampos
            // 
            this.pnlLimpiarCampos.Controls.Add(this.btnLimpiarCampos);
            this.pnlLimpiarCampos.Controls.Add(this.lblLimpiar);
            this.pnlLimpiarCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLimpiarCampos.Location = new System.Drawing.Point(0, 225);
            this.pnlLimpiarCampos.Name = "pnlLimpiarCampos";
            this.pnlLimpiarCampos.Size = new System.Drawing.Size(134, 55);
            this.pnlLimpiarCampos.TabIndex = 23;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCampos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLimpiarCampos.Image = global::Vista.Properties.Resources.broom_100px;
            this.btnLimpiarCampos.ImageActive = null;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(0, 0);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(35, 55);
            this.btnLimpiarCampos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLimpiarCampos.TabIndex = 5;
            this.btnLimpiarCampos.TabStop = false;
            this.btnLimpiarCampos.Zoom = 10;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lblLimpiar
            // 
            this.lblLimpiar.AutoSize = true;
            this.lblLimpiar.Location = new System.Drawing.Point(43, 6);
            this.lblLimpiar.Name = "lblLimpiar";
            this.lblLimpiar.Size = new System.Drawing.Size(61, 40);
            this.lblLimpiar.TabIndex = 5;
            this.lblLimpiar.Text = "Limpiar\r\ncampos";
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.Controls.Add(this.btnEliminar);
            this.pnlEliminar.Controls.Add(this.lblEliminar);
            this.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEliminar.Location = new System.Drawing.Point(0, 172);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(134, 53);
            this.pnlEliminar.TabIndex = 22;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEliminar.Image = global::Vista.Properties.Resources.e;
            this.btnEliminar.ImageActive = null;
            this.btnEliminar.Location = new System.Drawing.Point(0, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(35, 53);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Zoom = 10;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Location = new System.Drawing.Point(43, 7);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(66, 40);
            this.lblEliminar.TabIndex = 5;
            this.lblEliminar.Text = "Eliminar\r\ndatos\r\n";
            // 
            // pnlActualizar
            // 
            this.pnlActualizar.Controls.Add(this.btnActualizar);
            this.pnlActualizar.Controls.Add(this.lblActualizar);
            this.pnlActualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActualizar.Location = new System.Drawing.Point(0, 116);
            this.pnlActualizar.Name = "pnlActualizar";
            this.pnlActualizar.Size = new System.Drawing.Size(134, 56);
            this.pnlActualizar.TabIndex = 21;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnActualizar.Image = global::Vista.Properties.Resources.update_left_rotation_100px;
            this.btnActualizar.ImageActive = null;
            this.btnActualizar.Location = new System.Drawing.Point(0, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(35, 56);
            this.btnActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.TabStop = false;
            this.btnActualizar.Zoom = 10;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblActualizar
            // 
            this.lblActualizar.AutoSize = true;
            this.lblActualizar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblActualizar.Location = new System.Drawing.Point(43, 8);
            this.lblActualizar.Name = "lblActualizar";
            this.lblActualizar.Size = new System.Drawing.Size(80, 40);
            this.lblActualizar.TabIndex = 4;
            this.lblActualizar.Text = "Actualizar\r\ndatos";
            // 
            // pnlMostrar
            // 
            this.pnlMostrar.Controls.Add(this.lblmostrar);
            this.pnlMostrar.Controls.Add(this.btnMostrar);
            this.pnlMostrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMostrar.Location = new System.Drawing.Point(0, 58);
            this.pnlMostrar.Name = "pnlMostrar";
            this.pnlMostrar.Size = new System.Drawing.Size(134, 58);
            this.pnlMostrar.TabIndex = 17;
            // 
            // lblmostrar
            // 
            this.lblmostrar.AutoSize = true;
            this.lblmostrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblmostrar.Location = new System.Drawing.Point(43, 10);
            this.lblmostrar.Name = "lblmostrar";
            this.lblmostrar.Size = new System.Drawing.Size(61, 40);
            this.lblmostrar.TabIndex = 4;
            this.lblmostrar.Text = "Mostrar\rdatos";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMostrar.Image = global::Vista.Properties.Resources.show_property_100px;
            this.btnMostrar.ImageActive = null;
            this.btnMostrar.Location = new System.Drawing.Point(0, 0);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(35, 58);
            this.btnMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.TabStop = false;
            this.btnMostrar.Zoom = 10;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click_1);
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.Controls.Add(this.btnAgregar);
            this.pnlAgregar.Controls.Add(this.lblAgregar);
            this.pnlAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAgregar.Location = new System.Drawing.Point(0, 0);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(134, 58);
            this.pnlAgregar.TabIndex = 17;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregar.Image = global::Vista.Properties.Resources.add_100px;
            this.btnAgregar.ImageActive = null;
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(35, 58);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Zoom = 10;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblAgregar.Location = new System.Drawing.Point(43, 12);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(64, 40);
            this.lblAgregar.TabIndex = 4;
            this.lblAgregar.Text = "Agregar\r\ndatos";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblCorreo);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.cmbCargo);
            this.groupBox1.Controls.Add(this.lblTipoUsuario);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtNumeroEmpleado);
            this.groupBox1.Controls.Add(this.lblNumeroEmpleado);
            this.groupBox1.Controls.Add(this.txtNombreUser);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(166, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 355);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del usuario:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 153);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(61, 20);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(16, 221);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(139, 20);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo electrónico";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(20, 176);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(208, 28);
            this.cmbEstado.TabIndex = 2;
            this.cmbEstado.Click += new System.EventHandler(this.cmbEstado_Click);
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(20, 112);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(208, 28);
            this.cmbCargo.TabIndex = 2;
            this.cmbCargo.Click += new System.EventHandler(this.cmbCargo_Click_1);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(16, 94);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(122, 20);
            this.lblTipoUsuario.TabIndex = 0;
            this.lblTipoUsuario.Text = "Tipo de usuario:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(20, 244);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(208, 25);
            this.txtCorreo.TabIndex = 1;
            // 
            // txtNumeroEmpleado
            // 
            this.txtNumeroEmpleado.Location = new System.Drawing.Point(20, 312);
            this.txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            this.txtNumeroEmpleado.Size = new System.Drawing.Size(208, 25);
            this.txtNumeroEmpleado.TabIndex = 1;
            // 
            // lblNumeroEmpleado
            // 
            this.lblNumeroEmpleado.AutoSize = true;
            this.lblNumeroEmpleado.Location = new System.Drawing.Point(16, 289);
            this.lblNumeroEmpleado.Name = "lblNumeroEmpleado";
            this.lblNumeroEmpleado.Size = new System.Drawing.Size(227, 20);
            this.lblNumeroEmpleado.TabIndex = 0;
            this.lblNumeroEmpleado.Text = "Número de lista del empleado:";
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.Location = new System.Drawing.Point(20, 56);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.Size = new System.Drawing.Size(208, 25);
            this.txtNombreUser.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(148, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de usuario:";
            // 
            // pnlRecargar
            // 
            this.pnlRecargar.Controls.Add(this.btnRecargar);
            this.pnlRecargar.Controls.Add(this.lblRecargar1);
            this.pnlRecargar.Enabled = false;
            this.pnlRecargar.Location = new System.Drawing.Point(20, 600);
            this.pnlRecargar.Name = "pnlRecargar";
            this.pnlRecargar.Size = new System.Drawing.Size(112, 50);
            this.pnlRecargar.TabIndex = 28;
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRecargar.Image = global::Vista.Properties.Resources.refresh_blue_100px;
            this.btnRecargar.ImageActive = null;
            this.btnRecargar.Location = new System.Drawing.Point(0, 0);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(35, 50);
            this.btnRecargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRecargar.TabIndex = 6;
            this.btnRecargar.TabStop = false;
            this.btnRecargar.Zoom = 10;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // lblRecargar1
            // 
            this.lblRecargar1.AutoSize = true;
            this.lblRecargar1.Location = new System.Drawing.Point(39, 7);
            this.lblRecargar1.Name = "lblRecargar1";
            this.lblRecargar1.Size = new System.Drawing.Size(71, 40);
            this.lblRecargar1.TabIndex = 5;
            this.lblRecargar1.Text = "Recargar\r\nlista";
            // 
            // lblDescripBuscar
            // 
            this.lblDescripBuscar.AutoSize = true;
            this.lblDescripBuscar.Location = new System.Drawing.Point(9, 399);
            this.lblDescripBuscar.Name = "lblDescripBuscar";
            this.lblDescripBuscar.Size = new System.Drawing.Size(147, 80);
            this.lblDescripBuscar.TabIndex = 27;
            this.lblDescripBuscar.Text = "Buscar por nombre\r\nde usuario, número\r\nde documento o \r\ncorreo";
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.btnBuscar);
            this.pnlBuscar.Controls.Add(this.lblBuscar1);
            this.pnlBuscar.Location = new System.Drawing.Point(20, 530);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(98, 37);
            this.pnlBuscar.TabIndex = 26;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscar.Image = global::Vista.Properties.Resources.search_100px;
            this.btnBuscar.ImageActive = null;
            this.btnBuscar.Location = new System.Drawing.Point(0, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 37);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Zoom = 10;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscar1
            // 
            this.lblBuscar1.AutoSize = true;
            this.lblBuscar1.Location = new System.Drawing.Point(37, 9);
            this.lblBuscar1.Name = "lblBuscar1";
            this.lblBuscar1.Size = new System.Drawing.Size(55, 20);
            this.lblBuscar1.TabIndex = 5;
            this.lblBuscar1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(10, 499);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(143, 25);
            this.txtBuscar.TabIndex = 25;
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(604, 37);
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(160, 25);
            this.txtBuscarEmpleado.TabIndex = 25;
            // 
            // pnlBuscar2
            // 
            this.pnlBuscar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlBuscar2.Controls.Add(this.btnBuscarempleado);
            this.pnlBuscar2.Controls.Add(this.lblBuscar2);
            this.pnlBuscar2.Location = new System.Drawing.Point(770, 30);
            this.pnlBuscar2.Name = "pnlBuscar2";
            this.pnlBuscar2.Size = new System.Drawing.Size(98, 37);
            this.pnlBuscar2.TabIndex = 26;
            // 
            // btnBuscarempleado
            // 
            this.btnBuscarempleado.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarempleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarempleado.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscarempleado.Image = global::Vista.Properties.Resources.search_100px;
            this.btnBuscarempleado.ImageActive = null;
            this.btnBuscarempleado.Location = new System.Drawing.Point(0, 0);
            this.btnBuscarempleado.Name = "btnBuscarempleado";
            this.btnBuscarempleado.Size = new System.Drawing.Size(35, 37);
            this.btnBuscarempleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarempleado.TabIndex = 5;
            this.btnBuscarempleado.TabStop = false;
            this.btnBuscarempleado.Zoom = 10;
            this.btnBuscarempleado.Click += new System.EventHandler(this.btnBuscarempleado_Click);
            // 
            // lblBuscar2
            // 
            this.lblBuscar2.AutoSize = true;
            this.lblBuscar2.Location = new System.Drawing.Point(37, 9);
            this.lblBuscar2.Name = "lblBuscar2";
            this.lblBuscar2.Size = new System.Drawing.Size(55, 20);
            this.lblBuscar2.TabIndex = 5;
            this.lblBuscar2.Text = "Buscar";
            // 
            // lblDescripBuscar2
            // 
            this.lblDescripBuscar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescripBuscar2.AutoSize = true;
            this.lblDescripBuscar2.Location = new System.Drawing.Point(428, 20);
            this.lblDescripBuscar2.Name = "lblDescripBuscar2";
            this.lblDescripBuscar2.Size = new System.Drawing.Size(170, 60);
            this.lblDescripBuscar2.TabIndex = 27;
            this.lblDescripBuscar2.Text = "Buscar por nombre,\r\nnúmero de documento\r\no cargo";
            // 
            // pnlRecargar2
            // 
            this.pnlRecargar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlRecargar2.Controls.Add(this.btnRecargar2);
            this.pnlRecargar2.Controls.Add(this.lblRecargar2);
            this.pnlRecargar2.Enabled = false;
            this.pnlRecargar2.Location = new System.Drawing.Point(953, 22);
            this.pnlRecargar2.Name = "pnlRecargar2";
            this.pnlRecargar2.Size = new System.Drawing.Size(112, 50);
            this.pnlRecargar2.TabIndex = 28;
            // 
            // btnRecargar2
            // 
            this.btnRecargar2.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRecargar2.Image = global::Vista.Properties.Resources.refresh_blue_100px;
            this.btnRecargar2.ImageActive = null;
            this.btnRecargar2.Location = new System.Drawing.Point(0, 0);
            this.btnRecargar2.Name = "btnRecargar2";
            this.btnRecargar2.Size = new System.Drawing.Size(35, 50);
            this.btnRecargar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRecargar2.TabIndex = 6;
            this.btnRecargar2.TabStop = false;
            this.btnRecargar2.Zoom = 10;
            this.btnRecargar2.Click += new System.EventHandler(this.btnRecargar2_Click);
            // 
            // lblRecargar2
            // 
            this.lblRecargar2.AutoSize = true;
            this.lblRecargar2.Location = new System.Drawing.Point(39, 7);
            this.lblRecargar2.Name = "lblRecargar2";
            this.lblRecargar2.Size = new System.Drawing.Size(71, 40);
            this.lblRecargar2.TabIndex = 5;
            this.lblRecargar2.Text = "Recargar\r\nlista";
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblListaUsuarios.AutoSize = true;
            this.lblListaUsuarios.Location = new System.Drawing.Point(163, 385);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(125, 20);
            this.lblListaUsuarios.TabIndex = 29;
            this.lblListaUsuarios.Text = "Lista de usuarios";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1083, 679);
            this.Controls.Add(this.lblListaUsuarios);
            this.Controls.Add(this.pnlRecargar2);
            this.Controls.Add(this.pnlRecargar);
            this.Controls.Add(this.lblDescripBuscar2);
            this.Controls.Add(this.pnlBuscar2);
            this.Controls.Add(this.lblDescripBuscar);
            this.Controls.Add(this.txtBuscarEmpleado);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblListaEmpleados);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.dgvEmpleados);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmUsuarios";
            this.Opacity = 0.9D;
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlLimpiarCampos.ResumeLayout(false);
            this.pnlLimpiarCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiarCampos)).EndInit();
            this.pnlEliminar.ResumeLayout(false);
            this.pnlEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            this.pnlActualizar.ResumeLayout(false);
            this.pnlActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).EndInit();
            this.pnlMostrar.ResumeLayout(false);
            this.pnlMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrar)).EndInit();
            this.pnlAgregar.ResumeLayout(false);
            this.pnlAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlRecargar.ResumeLayout(false);
            this.pnlRecargar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).EndInit();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.pnlBuscar2.ResumeLayout(false);
            this.pnlBuscar2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarempleado)).EndInit();
            this.pnlRecargar2.ResumeLayout(false);
            this.pnlRecargar2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolStripButton btnBackForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tlsFrm;
        private System.Windows.Forms.ToolStripTextBox txtIdUsuario;
        private System.Windows.Forms.Label lblListaEmpleados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMostrar;
        private System.Windows.Forms.Label lblmostrar;
        private Bunifu.Framework.UI.BunifuImageButton btnMostrar;
        private System.Windows.Forms.Panel pnlAgregar;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNumeroEmpleado;
        private System.Windows.Forms.Label lblNumeroEmpleado;
        private System.Windows.Forms.TextBox txtNombreUser;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlRecargar;
        private Bunifu.Framework.UI.BunifuImageButton btnRecargar;
        private System.Windows.Forms.Label lblRecargar1;
        private System.Windows.Forms.Label lblDescripBuscar;
        private System.Windows.Forms.Panel pnlBuscar;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscar;
        private System.Windows.Forms.Label lblBuscar1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel pnlRecargar2;
        private Bunifu.Framework.UI.BunifuImageButton btnRecargar2;
        private System.Windows.Forms.Label lblRecargar2;
        private System.Windows.Forms.Label lblDescripBuscar2;
        private System.Windows.Forms.Panel pnlBuscar2;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarempleado;
        private System.Windows.Forms.Label lblBuscar2;
        private System.Windows.Forms.TextBox txtBuscarEmpleado;
        private System.Windows.Forms.Label lblListaUsuarios;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel pnlLimpiarCampos;
        private Bunifu.Framework.UI.BunifuImageButton btnLimpiarCampos;
        private System.Windows.Forms.Label lblLimpiar;
        private System.Windows.Forms.Panel pnlEliminar;
        private Bunifu.Framework.UI.BunifuImageButton btnEliminar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Panel pnlActualizar;
        private Bunifu.Framework.UI.BunifuImageButton btnActualizar;
        private System.Windows.Forms.Label lblActualizar;
    }
}