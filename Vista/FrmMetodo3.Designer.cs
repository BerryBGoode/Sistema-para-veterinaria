namespace Vista
{
    partial class FrmMetodo3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMetodo3));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVerfiDoc = new System.Windows.Forms.TextBox();
            this.txtVerfiCargo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVerfiCorreo = new System.Windows.Forms.TextBox();
            this.txtVerfiUsuario = new System.Windows.Forms.TextBox();
            this.txtVerfiApellido = new System.Windows.Forms.TextBox();
            this.txtVerfiNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlNoSoy = new System.Windows.Forms.Panel();
            this.btnNoSoy = new Bunifu.Framework.UI.BunifuImageButton();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlEnviar = new System.Windows.Forms.Panel();
            this.btnEnviar = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelEnviar = new System.Windows.Forms.Label();
            this.pnlVerficar = new System.Windows.Forms.Panel();
            this.btnVerficar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlBarraSuperior = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.pnlNoSoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoSoy)).BeginInit();
            this.pnlEnviar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviar)).BeginInit();
            this.pnlVerficar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerficar)).BeginInit();
            this.pnlBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(28, 87);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(253, 25);
            this.txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(318, 87);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(253, 25);
            this.txtCorreo.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVerfiDoc);
            this.groupBox1.Controls.Add(this.txtVerfiCargo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtVerfiCorreo);
            this.groupBox1.Controls.Add(this.txtVerfiUsuario);
            this.groupBox1.Controls.Add(this.txtVerfiApellido);
            this.groupBox1.Controls.Add(this.txtVerfiNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(18, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 240);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales";
            // 
            // txtVerfiDoc
            // 
            this.txtVerfiDoc.Location = new System.Drawing.Point(16, 192);
            this.txtVerfiDoc.Name = "txtVerfiDoc";
            this.txtVerfiDoc.Size = new System.Drawing.Size(253, 25);
            this.txtVerfiDoc.TabIndex = 16;
            // 
            // txtVerfiCargo
            // 
            this.txtVerfiCargo.Location = new System.Drawing.Point(306, 192);
            this.txtVerfiCargo.Name = "txtVerfiCargo";
            this.txtVerfiCargo.Size = new System.Drawing.Size(253, 25);
            this.txtVerfiCargo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cargo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Número de documento";
            // 
            // txtVerfiCorreo
            // 
            this.txtVerfiCorreo.Location = new System.Drawing.Point(306, 122);
            this.txtVerfiCorreo.Name = "txtVerfiCorreo";
            this.txtVerfiCorreo.Size = new System.Drawing.Size(252, 25);
            this.txtVerfiCorreo.TabIndex = 12;
            // 
            // txtVerfiUsuario
            // 
            this.txtVerfiUsuario.Location = new System.Drawing.Point(16, 125);
            this.txtVerfiUsuario.Name = "txtVerfiUsuario";
            this.txtVerfiUsuario.Size = new System.Drawing.Size(253, 25);
            this.txtVerfiUsuario.TabIndex = 11;
            // 
            // txtVerfiApellido
            // 
            this.txtVerfiApellido.Location = new System.Drawing.Point(306, 58);
            this.txtVerfiApellido.Name = "txtVerfiApellido";
            this.txtVerfiApellido.Size = new System.Drawing.Size(252, 25);
            this.txtVerfiApellido.TabIndex = 10;
            // 
            // txtVerfiNombre
            // 
            this.txtVerfiNombre.Location = new System.Drawing.Point(16, 58);
            this.txtVerfiNombre.Name = "txtVerfiNombre";
            this.txtVerfiNombre.Size = new System.Drawing.Size(253, 25);
            this.txtVerfiNombre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Correo";
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(15, 99);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(60, 20);
            this.labe.TabIndex = 0;
            this.labe.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombres";
            // 
            // pnlNoSoy
            // 
            this.pnlNoSoy.Controls.Add(this.btnNoSoy);
            this.pnlNoSoy.Controls.Add(this.label9);
            this.pnlNoSoy.Enabled = false;
            this.pnlNoSoy.Location = new System.Drawing.Point(18, 464);
            this.pnlNoSoy.Name = "pnlNoSoy";
            this.pnlNoSoy.Size = new System.Drawing.Size(148, 56);
            this.pnlNoSoy.TabIndex = 21;
            // 
            // btnNoSoy
            // 
            this.btnNoSoy.BackColor = System.Drawing.Color.Transparent;
            this.btnNoSoy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoSoy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNoSoy.Image = global::Vista.Properties.Resources.user_not_found_100px;
            this.btnNoSoy.ImageActive = null;
            this.btnNoSoy.Location = new System.Drawing.Point(0, 0);
            this.btnNoSoy.Name = "btnNoSoy";
            this.btnNoSoy.Size = new System.Drawing.Size(35, 56);
            this.btnNoSoy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNoSoy.TabIndex = 4;
            this.btnNoSoy.TabStop = false;
            this.btnNoSoy.Zoom = 10;
            this.btnNoSoy.Click += new System.EventHandler(this.btnNoSoy_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Location = new System.Drawing.Point(39, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 40);
            this.label9.TabIndex = 4;
            this.label9.Text = "No soy este\r\nusuario";
            // 
            // pnlEnviar
            // 
            this.pnlEnviar.Controls.Add(this.btnEnviar);
            this.pnlEnviar.Controls.Add(this.labelEnviar);
            this.pnlEnviar.Enabled = false;
            this.pnlEnviar.Location = new System.Drawing.Point(501, 464);
            this.pnlEnviar.Name = "pnlEnviar";
            this.pnlEnviar.Size = new System.Drawing.Size(111, 56);
            this.pnlEnviar.TabIndex = 21;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEnviar.Image = global::Vista.Properties.Resources.gmail_100px;
            this.btnEnviar.ImageActive = null;
            this.btnEnviar.Location = new System.Drawing.Point(0, 0);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(37, 56);
            this.btnEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.TabStop = false;
            this.btnEnviar.Zoom = 10;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // labelEnviar
            // 
            this.labelEnviar.AutoSize = true;
            this.labelEnviar.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelEnviar.Location = new System.Drawing.Point(43, 8);
            this.labelEnviar.Name = "labelEnviar";
            this.labelEnviar.Size = new System.Drawing.Size(55, 40);
            this.labelEnviar.TabIndex = 4;
            this.labelEnviar.Text = "Enviar\r\nCorreo";
            // 
            // pnlVerficar
            // 
            this.pnlVerficar.Controls.Add(this.btnVerficar);
            this.pnlVerficar.Controls.Add(this.label11);
            this.pnlVerficar.Location = new System.Drawing.Point(435, 150);
            this.pnlVerficar.Name = "pnlVerficar";
            this.pnlVerficar.Size = new System.Drawing.Size(124, 56);
            this.pnlVerficar.TabIndex = 22;
            // 
            // btnVerficar
            // 
            this.btnVerficar.BackColor = System.Drawing.Color.Transparent;
            this.btnVerficar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerficar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVerficar.Image = global::Vista.Properties.Resources.search_in_list_Blue100px;
            this.btnVerficar.ImageActive = null;
            this.btnVerficar.Location = new System.Drawing.Point(0, 0);
            this.btnVerficar.Name = "btnVerficar";
            this.btnVerficar.Size = new System.Drawing.Size(37, 56);
            this.btnVerficar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVerficar.TabIndex = 4;
            this.btnVerficar.TabStop = false;
            this.btnVerficar.Zoom = 10;
            this.btnVerficar.Click += new System.EventHandler(this.btnVerficar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Location = new System.Drawing.Point(43, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 40);
            this.label11.TabIndex = 4;
            this.label11.Text = "Verficiar\r\ndatos\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(28, 150);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(253, 28);
            this.cmbEstado.TabIndex = 3;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlBarraSuperior
            // 
            this.pnlBarraSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBarraSuperior.BackgroundImage")));
            this.pnlBarraSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBarraSuperior.Controls.Add(this.btnMinimizar);
            this.pnlBarraSuperior.Controls.Add(this.btnCerrar);
            this.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSuperior.GradientBottomLeft = System.Drawing.Color.DarkBlue;
            this.pnlBarraSuperior.GradientBottomRight = System.Drawing.Color.MediumBlue;
            this.pnlBarraSuperior.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.pnlBarraSuperior.GradientTopRight = System.Drawing.Color.MediumBlue;
            this.pnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Quality = 10;
            this.pnlBarraSuperior.Size = new System.Drawing.Size(624, 34);
            this.pnlBarraSuperior.TabIndex = 25;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Vista.Properties.Resources.minimize_window_100px;
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(559, -3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 38);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 10;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Vista.Properties.Resources.close_window_100px;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(589, -3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 38);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack});
            this.toolStrip1.Location = new System.Drawing.Point(0, 34);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(624, 27);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Image = global::Vista.Properties.Resources.back_to_100px;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 24);
            this.btnBack.Text = "Ver métodos de recuperación";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmMetodo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 542);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlBarraSuperior);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlVerficar);
            this.Controls.Add(this.pnlEnviar);
            this.Controls.Add(this.pnlNoSoy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMetodo3";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMetodo3";
            this.Load += new System.EventHandler(this.FrmMetodo3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlNoSoy.ResumeLayout(false);
            this.pnlNoSoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoSoy)).EndInit();
            this.pnlEnviar.ResumeLayout(false);
            this.pnlEnviar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnviar)).EndInit();
            this.pnlVerficar.ResumeLayout(false);
            this.pnlVerficar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerficar)).EndInit();
            this.pnlBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVerfiDoc;
        private System.Windows.Forms.TextBox txtVerfiCargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVerfiCorreo;
        private System.Windows.Forms.TextBox txtVerfiUsuario;
        private System.Windows.Forms.TextBox txtVerfiApellido;
        private System.Windows.Forms.TextBox txtVerfiNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlNoSoy;
        private Bunifu.Framework.UI.BunifuImageButton btnNoSoy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlEnviar;
        private Bunifu.Framework.UI.BunifuImageButton btnEnviar;
        private System.Windows.Forms.Label labelEnviar;
        private System.Windows.Forms.Panel pnlVerficar;
        private Bunifu.Framework.UI.BunifuImageButton btnVerficar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstado;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlBarraSuperior;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBack;
    }
}