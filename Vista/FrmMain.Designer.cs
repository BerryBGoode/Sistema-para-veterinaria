namespace Vista
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.borde = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatosEmpleado = new System.Windows.Forms.Label();
            this.lblUsuarioDatos = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnIngles = new System.Windows.Forms.RadioButton();
            this.rbtnEspañol = new System.Windows.Forms.RadioButton();
            this.pnlMicuenta = new System.Windows.Forms.Panel();
            this.btnCuenta = new Bunifu.Framework.UI.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.btnCambiarClave = new Bunifu.Framework.UI.BunifuImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnlBarraTareas = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.btnFactura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExpediente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConsultas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPerros = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPropietarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlEmpleados = new System.Windows.Forms.Panel();
            this.btnUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmpleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlBarraSuperior = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRestaurar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlMicuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCuenta)).BeginInit();
            this.pnlAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCambiarClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBarraTareas.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            this.pnlEmpleados.SuspendLayout();
            this.pnlBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // borde
            // 
            this.borde.ElipseRadius = 0;
            this.borde.TargetControl = this;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(802, 627);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(165, 61);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(802, 554);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(165, 61);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido a:";
            // 
            // lblDatosEmpleado
            // 
            this.lblDatosEmpleado.AutoSize = true;
            this.lblDatosEmpleado.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosEmpleado.Location = new System.Drawing.Point(139, 60);
            this.lblDatosEmpleado.Name = "lblDatosEmpleado";
            this.lblDatosEmpleado.Size = new System.Drawing.Size(20, 27);
            this.lblDatosEmpleado.TabIndex = 3;
            this.lblDatosEmpleado.Text = ".";
            // 
            // lblUsuarioDatos
            // 
            this.lblUsuarioDatos.AutoSize = true;
            this.lblUsuarioDatos.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioDatos.Location = new System.Drawing.Point(200, 94);
            this.lblUsuarioDatos.Name = "lblUsuarioDatos";
            this.lblUsuarioDatos.Size = new System.Drawing.Size(20, 27);
            this.lblUsuarioDatos.TabIndex = 3;
            this.lblUsuarioDatos.Text = ".";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.pictureBox2);
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.lblUsuarioDatos);
            this.pnlMain.Controls.Add(this.lblDatosEmpleado);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lblFecha);
            this.pnlMain.Controls.Add(this.lblHora);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(227, 34);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1083, 700);
            this.pnlMain.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbtnIngles);
            this.groupBox1.Controls.Add(this.rbtnEspañol);
            this.groupBox1.Controls.Add(this.pnlMicuenta);
            this.groupBox1.Controls.Add(this.pnlAgregar);
            this.groupBox1.Location = new System.Drawing.Point(813, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 545);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajustes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Idiomas";
            // 
            // rbtnIngles
            // 
            this.rbtnIngles.AutoSize = true;
            this.rbtnIngles.Location = new System.Drawing.Point(35, 349);
            this.rbtnIngles.Name = "rbtnIngles";
            this.rbtnIngles.Size = new System.Drawing.Size(77, 27);
            this.rbtnIngles.TabIndex = 27;
            this.rbtnIngles.Text = "Ingles";
            this.rbtnIngles.UseVisualStyleBackColor = true;
            this.rbtnIngles.CheckedChanged += new System.EventHandler(this.rbtnIngles_CheckedChanged);
            // 
            // rbtnEspañol
            // 
            this.rbtnEspañol.AutoSize = true;
            this.rbtnEspañol.Checked = true;
            this.rbtnEspañol.Location = new System.Drawing.Point(35, 298);
            this.rbtnEspañol.Name = "rbtnEspañol";
            this.rbtnEspañol.Size = new System.Drawing.Size(92, 27);
            this.rbtnEspañol.TabIndex = 28;
            this.rbtnEspañol.TabStop = true;
            this.rbtnEspañol.Text = "Español";
            this.rbtnEspañol.UseVisualStyleBackColor = true;
            // 
            // pnlMicuenta
            // 
            this.pnlMicuenta.Controls.Add(this.btnCuenta);
            this.pnlMicuenta.Controls.Add(this.label5);
            this.pnlMicuenta.Location = new System.Drawing.Point(25, 60);
            this.pnlMicuenta.Name = "pnlMicuenta";
            this.pnlMicuenta.Size = new System.Drawing.Size(170, 71);
            this.pnlMicuenta.TabIndex = 24;
            // 
            // btnCuenta
            // 
            this.btnCuenta.BackColor = System.Drawing.Color.Transparent;
            this.btnCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCuenta.Image = global::Vista.Properties.Resources.male_user_100px;
            this.btnCuenta.ImageActive = null;
            this.btnCuenta.Location = new System.Drawing.Point(0, 0);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(60, 71);
            this.btnCuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCuenta.TabIndex = 2;
            this.btnCuenta.TabStop = false;
            this.btnCuenta.Zoom = 10;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Location = new System.Drawing.Point(66, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mi cuenta";
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.Controls.Add(this.btnCambiarClave);
            this.pnlAgregar.Controls.Add(this.label7);
            this.pnlAgregar.Location = new System.Drawing.Point(25, 159);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(170, 71);
            this.pnlAgregar.TabIndex = 24;
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiarClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarClave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCambiarClave.Image = global::Vista.Properties.Resources.password_reset_100px;
            this.btnCambiarClave.ImageActive = null;
            this.btnCambiarClave.Location = new System.Drawing.Point(0, 0);
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Size = new System.Drawing.Size(60, 71);
            this.btnCambiarClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCambiarClave.TabIndex = 2;
            this.btnCambiarClave.TabStop = false;
            this.btnCambiarClave.Zoom = 10;
            this.btnCambiarClave.Click += new System.EventHandler(this.btnCambiarClave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Location = new System.Drawing.Point(66, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 46);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cambiar\r\ncontraseña";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Vista.Properties.Resources.Logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(9, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(367, 368);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.administrator_male_100px;
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cargo:";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(227, 734);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1083, 32);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // pnlBarraTareas
            // 
            this.pnlBarraTareas.AutoScroll = true;
            this.pnlBarraTareas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBarraTareas.BackgroundImage")));
            this.pnlBarraTareas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBarraTareas.Controls.Add(this.pnlConsulta);
            this.pnlBarraTareas.Controls.Add(this.btnConsultas);
            this.pnlBarraTareas.Controls.Add(this.btnPerros);
            this.pnlBarraTareas.Controls.Add(this.btnPropietarios);
            this.pnlBarraTareas.Controls.Add(this.pnlEmpleados);
            this.pnlBarraTareas.Controls.Add(this.btnEmpleados);
            this.pnlBarraTareas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBarraTareas.GradientBottomLeft = System.Drawing.Color.Navy;
            this.pnlBarraTareas.GradientBottomRight = System.Drawing.Color.Navy;
            this.pnlBarraTareas.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.pnlBarraTareas.GradientTopRight = System.Drawing.Color.Navy;
            this.pnlBarraTareas.Location = new System.Drawing.Point(0, 34);
            this.pnlBarraTareas.Name = "pnlBarraTareas";
            this.pnlBarraTareas.Quality = 10;
            this.pnlBarraTareas.Size = new System.Drawing.Size(227, 732);
            this.pnlBarraTareas.TabIndex = 1;
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.BackColor = System.Drawing.Color.Transparent;
            this.pnlConsulta.Controls.Add(this.btnFactura);
            this.pnlConsulta.Controls.Add(this.btnExpediente);
            this.pnlConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConsulta.Location = new System.Drawing.Point(0, 439);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(227, 174);
            this.pnlConsulta.TabIndex = 22;
            // 
            // btnFactura
            // 
            this.btnFactura.Activecolor = System.Drawing.Color.Blue;
            this.btnFactura.BackColor = System.Drawing.Color.Transparent;
            this.btnFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFactura.BorderRadius = 4;
            this.btnFactura.ButtonText = "Facturas";
            this.btnFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactura.DisabledColor = System.Drawing.Color.DarkBlue;
            this.btnFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFactura.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFactura.Iconimage = global::Vista.Properties.Resources.invoice_100px;
            this.btnFactura.Iconimage_right = null;
            this.btnFactura.Iconimage_right_Selected = null;
            this.btnFactura.Iconimage_Selected = null;
            this.btnFactura.IconMarginLeft = 55;
            this.btnFactura.IconMarginRight = 0;
            this.btnFactura.IconRightVisible = true;
            this.btnFactura.IconRightZoom = 0D;
            this.btnFactura.IconVisible = true;
            this.btnFactura.IconZoom = 72D;
            this.btnFactura.IsTab = false;
            this.btnFactura.Location = new System.Drawing.Point(0, 88);
            this.btnFactura.Margin = new System.Windows.Forms.Padding(19, 56, 19, 56);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Normalcolor = System.Drawing.Color.Transparent;
            this.btnFactura.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnFactura.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnFactura.selected = false;
            this.btnFactura.Size = new System.Drawing.Size(227, 88);
            this.btnFactura.TabIndex = 12;
            this.btnFactura.Text = "Facturas";
            this.btnFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.Textcolor = System.Drawing.Color.White;
            this.btnFactura.TextFont = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.DoubleClick += new System.EventHandler(this.btnFactura_DoubleClick);
            // 
            // btnExpediente
            // 
            this.btnExpediente.Activecolor = System.Drawing.Color.Blue;
            this.btnExpediente.BackColor = System.Drawing.Color.Transparent;
            this.btnExpediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpediente.BorderRadius = 4;
            this.btnExpediente.ButtonText = "Expedientes";
            this.btnExpediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpediente.DisabledColor = System.Drawing.Color.DarkBlue;
            this.btnExpediente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpediente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExpediente.Iconimage = global::Vista.Properties.Resources.clipboard_100px1;
            this.btnExpediente.Iconimage_right = null;
            this.btnExpediente.Iconimage_right_Selected = null;
            this.btnExpediente.Iconimage_Selected = null;
            this.btnExpediente.IconMarginLeft = 55;
            this.btnExpediente.IconMarginRight = 0;
            this.btnExpediente.IconRightVisible = true;
            this.btnExpediente.IconRightZoom = 0D;
            this.btnExpediente.IconVisible = true;
            this.btnExpediente.IconZoom = 72D;
            this.btnExpediente.IsTab = false;
            this.btnExpediente.Location = new System.Drawing.Point(0, 0);
            this.btnExpediente.Margin = new System.Windows.Forms.Padding(15, 39, 15, 39);
            this.btnExpediente.Name = "btnExpediente";
            this.btnExpediente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnExpediente.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnExpediente.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnExpediente.selected = false;
            this.btnExpediente.Size = new System.Drawing.Size(227, 88);
            this.btnExpediente.TabIndex = 11;
            this.btnExpediente.Text = "Expedientes";
            this.btnExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpediente.Textcolor = System.Drawing.Color.White;
            this.btnExpediente.TextFont = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpediente.DoubleClick += new System.EventHandler(this.btnExpediente_DoubleClick);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Activecolor = System.Drawing.Color.Blue;
            this.btnConsultas.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultas.BorderRadius = 4;
            this.btnConsultas.ButtonText = "Consultas";
            this.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultas.DisabledColor = System.Drawing.Color.DarkBlue;
            this.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConsultas.Iconimage = global::Vista.Properties.Resources.calendar_100px;
            this.btnConsultas.Iconimage_right = null;
            this.btnConsultas.Iconimage_right_Selected = null;
            this.btnConsultas.Iconimage_Selected = null;
            this.btnConsultas.IconMarginLeft = 0;
            this.btnConsultas.IconMarginRight = 0;
            this.btnConsultas.IconRightVisible = true;
            this.btnConsultas.IconRightZoom = 0D;
            this.btnConsultas.IconVisible = true;
            this.btnConsultas.IconZoom = 79D;
            this.btnConsultas.IsTab = false;
            this.btnConsultas.Location = new System.Drawing.Point(0, 349);
            this.btnConsultas.Margin = new System.Windows.Forms.Padding(30, 115, 30, 115);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnConsultas.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnConsultas.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnConsultas.selected = false;
            this.btnConsultas.Size = new System.Drawing.Size(227, 90);
            this.btnConsultas.TabIndex = 21;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Textcolor = System.Drawing.Color.White;
            this.btnConsultas.TextFont = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            this.btnConsultas.DoubleClick += new System.EventHandler(this.btnConsultas_DoubleClick);
            // 
            // btnPerros
            // 
            this.btnPerros.Activecolor = System.Drawing.Color.Blue;
            this.btnPerros.BackColor = System.Drawing.Color.Transparent;
            this.btnPerros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPerros.BorderRadius = 4;
            this.btnPerros.ButtonText = "Perros";
            this.btnPerros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerros.DisabledColor = System.Drawing.Color.DarkBlue;
            this.btnPerros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerros.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPerros.Iconimage = global::Vista.Properties.Resources.dog_paw_100px;
            this.btnPerros.Iconimage_right = null;
            this.btnPerros.Iconimage_right_Selected = null;
            this.btnPerros.Iconimage_Selected = null;
            this.btnPerros.IconMarginLeft = 0;
            this.btnPerros.IconMarginRight = 0;
            this.btnPerros.IconRightVisible = true;
            this.btnPerros.IconRightZoom = 0D;
            this.btnPerros.IconVisible = true;
            this.btnPerros.IconZoom = 80D;
            this.btnPerros.IsTab = false;
            this.btnPerros.Location = new System.Drawing.Point(0, 259);
            this.btnPerros.Margin = new System.Windows.Forms.Padding(24, 80, 24, 80);
            this.btnPerros.Name = "btnPerros";
            this.btnPerros.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPerros.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnPerros.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnPerros.selected = false;
            this.btnPerros.Size = new System.Drawing.Size(227, 90);
            this.btnPerros.TabIndex = 20;
            this.btnPerros.Text = "Perros";
            this.btnPerros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerros.Textcolor = System.Drawing.Color.White;
            this.btnPerros.TextFont = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerros.DoubleClick += new System.EventHandler(this.btnPerros_DoubleClick);
            // 
            // btnPropietarios
            // 
            this.btnPropietarios.Activecolor = System.Drawing.Color.Blue;
            this.btnPropietarios.BackColor = System.Drawing.Color.Transparent;
            this.btnPropietarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPropietarios.BorderRadius = 4;
            this.btnPropietarios.ButtonText = "Propietarios";
            this.btnPropietarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPropietarios.DisabledColor = System.Drawing.Color.DarkBlue;
            this.btnPropietarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPropietarios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPropietarios.Iconimage = global::Vista.Properties.Resources.user_100px;
            this.btnPropietarios.Iconimage_right = null;
            this.btnPropietarios.Iconimage_right_Selected = null;
            this.btnPropietarios.Iconimage_Selected = null;
            this.btnPropietarios.IconMarginLeft = 0;
            this.btnPropietarios.IconMarginRight = 0;
            this.btnPropietarios.IconRightVisible = true;
            this.btnPropietarios.IconRightZoom = 0D;
            this.btnPropietarios.IconVisible = true;
            this.btnPropietarios.IconZoom = 85D;
            this.btnPropietarios.IsTab = false;
            this.btnPropietarios.Location = new System.Drawing.Point(0, 169);
            this.btnPropietarios.Margin = new System.Windows.Forms.Padding(19, 56, 19, 56);
            this.btnPropietarios.Name = "btnPropietarios";
            this.btnPropietarios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPropietarios.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnPropietarios.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnPropietarios.selected = false;
            this.btnPropietarios.Size = new System.Drawing.Size(227, 90);
            this.btnPropietarios.TabIndex = 19;
            this.btnPropietarios.Text = "Propietarios";
            this.btnPropietarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPropietarios.Textcolor = System.Drawing.Color.White;
            this.btnPropietarios.TextFont = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropietarios.DoubleClick += new System.EventHandler(this.btnPropietarios_DoubleClick);
            // 
            // pnlEmpleados
            // 
            this.pnlEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmpleados.Controls.Add(this.btnUsuario);
            this.pnlEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmpleados.Location = new System.Drawing.Point(0, 90);
            this.pnlEmpleados.Name = "pnlEmpleados";
            this.pnlEmpleados.Size = new System.Drawing.Size(227, 79);
            this.pnlEmpleados.TabIndex = 11;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Activecolor = System.Drawing.Color.Blue;
            this.btnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuario.BorderRadius = 4;
            this.btnUsuario.ButtonText = "Usuario";
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.DisabledColor = System.Drawing.Color.DarkBlue;
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsuario.Iconimage = global::Vista.Properties.Resources.male_user_White100px;
            this.btnUsuario.Iconimage_right = null;
            this.btnUsuario.Iconimage_right_Selected = null;
            this.btnUsuario.Iconimage_Selected = null;
            this.btnUsuario.IconMarginLeft = 55;
            this.btnUsuario.IconMarginRight = 0;
            this.btnUsuario.IconRightVisible = true;
            this.btnUsuario.IconRightZoom = 0D;
            this.btnUsuario.IconVisible = true;
            this.btnUsuario.IconZoom = 72D;
            this.btnUsuario.IsTab = false;
            this.btnUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(24, 80, 24, 80);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUsuario.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnUsuario.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnUsuario.selected = false;
            this.btnUsuario.Size = new System.Drawing.Size(227, 88);
            this.btnUsuario.TabIndex = 22;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Textcolor = System.Drawing.Color.White;
            this.btnUsuario.TextFont = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.DoubleClick += new System.EventHandler(this.btnUsuario_DoubleClick);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Activecolor = System.Drawing.Color.Blue;
            this.btnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpleados.BorderRadius = 4;
            this.btnEmpleados.ButtonText = "Empleados";
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.DisabledColor = System.Drawing.Color.DarkBlue;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.Iconimage = global::Vista.Properties.Resources.employee_100px;
            this.btnEmpleados.Iconimage_right = null;
            this.btnEmpleados.Iconimage_right_Selected = null;
            this.btnEmpleados.Iconimage_Selected = null;
            this.btnEmpleados.IconMarginLeft = 0;
            this.btnEmpleados.IconMarginRight = 0;
            this.btnEmpleados.IconRightVisible = true;
            this.btnEmpleados.IconRightZoom = 0D;
            this.btnEmpleados.IconVisible = true;
            this.btnEmpleados.IconZoom = 85D;
            this.btnEmpleados.IsTab = false;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 0);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(15, 39, 15, 39);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnEmpleados.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmpleados.selected = false;
            this.btnEmpleados.Size = new System.Drawing.Size(227, 90);
            this.btnEmpleados.TabIndex = 10;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Textcolor = System.Drawing.Color.White;
            this.btnEmpleados.TextFont = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            this.btnEmpleados.DoubleClick += new System.EventHandler(this.btnEmpleados_DoubleClick);
            // 
            // pnlBarraSuperior
            // 
            this.pnlBarraSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBarraSuperior.BackgroundImage")));
            this.pnlBarraSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBarraSuperior.Controls.Add(this.btnMinimizar);
            this.pnlBarraSuperior.Controls.Add(this.btnRestaurar);
            this.pnlBarraSuperior.Controls.Add(this.btnMaximizar);
            this.pnlBarraSuperior.Controls.Add(this.btnCerrar);
            this.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSuperior.GradientBottomLeft = System.Drawing.Color.DarkBlue;
            this.pnlBarraSuperior.GradientBottomRight = System.Drawing.Color.Navy;
            this.pnlBarraSuperior.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.pnlBarraSuperior.GradientTopRight = System.Drawing.Color.MediumBlue;
            this.pnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Quality = 10;
            this.pnlBarraSuperior.Size = new System.Drawing.Size(1310, 34);
            this.pnlBarraSuperior.TabIndex = 0;
            this.pnlBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraSuperior_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Vista.Properties.Resources.minimize_window_100px;
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(1211, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 10;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::Vista.Properties.Resources.restore_window_100px;
            this.btnRestaurar.ImageActive = null;
            this.btnRestaurar.Location = new System.Drawing.Point(1242, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(24, 30);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Zoom = 10;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Vista.Properties.Resources.maximize_window_100px;
            this.btnMaximizar.ImageActive = null;
            this.btnMaximizar.Location = new System.Drawing.Point(1242, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(24, 30);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 0;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Zoom = 10;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Vista.Properties.Resources.close_window_100px;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(1273, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1310, 766);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pnlBarraTareas);
            this.Controls.Add(this.pnlBarraSuperior);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.SizeChanged += new System.EventHandler(this.FrmMain_SizeChanged);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlMicuenta.ResumeLayout(false);
            this.pnlMicuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCuenta)).EndInit();
            this.pnlAgregar.ResumeLayout(false);
            this.pnlAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCambiarClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBarraTareas.ResumeLayout(false);
            this.pnlConsulta.ResumeLayout(false);
            this.pnlEmpleados.ResumeLayout(false);
            this.pnlBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlBarraSuperior;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuElipse borde;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlBarraTareas;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximizar;
        private Bunifu.Framework.UI.BunifuImageButton btnRestaurar;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private System.Windows.Forms.Timer HoraFecha;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmpleados;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuarioDatos;
        private System.Windows.Forms.Label lblDatosEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel pnlConsulta;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultas;
        private Bunifu.Framework.UI.BunifuFlatButton btnPerros;
        private Bunifu.Framework.UI.BunifuFlatButton btnPropietarios;
        private System.Windows.Forms.Panel pnlEmpleados;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton btnExpediente;
        private Bunifu.Framework.UI.BunifuFlatButton btnFactura;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlAgregar;
        private Bunifu.Framework.UI.BunifuImageButton btnCambiarClave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnIngles;
        private System.Windows.Forms.RadioButton rbtnEspañol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlMicuenta;
        private Bunifu.Framework.UI.BunifuImageButton btnCuenta;
        private System.Windows.Forms.Label label5;
    }
}

