namespace Vista
{
    partial class FrmMetodo1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMetodo1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbTipoUser = new System.Windows.Forms.ComboBox();
            this.btnVerficarAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtClaveAdmin = new System.Windows.Forms.TextBox();
            this.txtCorreoAdmin = new System.Windows.Forms.TextBox();
            this.txtUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRecuperar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtDocBloq = new System.Windows.Forms.TextBox();
            this.txtCorreBloq = new System.Windows.Forms.TextBox();
            this.txtUsuarioBloq = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlBarraSuperior = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cmbTipoUser);
            this.groupBox1.Controls.Add(this.btnVerficarAdmin);
            this.groupBox1.Controls.Add(this.txtClaveAdmin);
            this.groupBox1.Controls.Add(this.txtCorreoAdmin);
            this.groupBox1.Controls.Add(this.txtUsuarioAdmin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(339, 492);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales del administrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.admin_settings_male_Blue100px;
            this.pictureBox1.Location = new System.Drawing.Point(95, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // cmbTipoUser
            // 
            this.cmbTipoUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUser.FormattingEnabled = true;
            this.cmbTipoUser.Location = new System.Drawing.Point(19, 340);
            this.cmbTipoUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoUser.Name = "cmbTipoUser";
            this.cmbTipoUser.Size = new System.Drawing.Size(292, 28);
            this.cmbTipoUser.TabIndex = 12;
            // 
            // btnVerficarAdmin
            // 
            this.btnVerficarAdmin.Activecolor = System.Drawing.Color.Blue;
            this.btnVerficarAdmin.BackColor = System.Drawing.Color.DarkBlue;
            this.btnVerficarAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerficarAdmin.BorderRadius = 4;
            this.btnVerficarAdmin.ButtonText = "Verficar credenciales";
            this.btnVerficarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerficarAdmin.DisabledColor = System.Drawing.Color.DarkBlue;
            this.btnVerficarAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerficarAdmin.Iconimage = global::Vista.Properties.Resources.checkmark_100px;
            this.btnVerficarAdmin.Iconimage_right = null;
            this.btnVerficarAdmin.Iconimage_right_Selected = null;
            this.btnVerficarAdmin.Iconimage_Selected = null;
            this.btnVerficarAdmin.IconMarginLeft = 0;
            this.btnVerficarAdmin.IconMarginRight = 0;
            this.btnVerficarAdmin.IconRightVisible = true;
            this.btnVerficarAdmin.IconRightZoom = 0D;
            this.btnVerficarAdmin.IconVisible = true;
            this.btnVerficarAdmin.IconZoom = 65D;
            this.btnVerficarAdmin.IsTab = false;
            this.btnVerficarAdmin.Location = new System.Drawing.Point(47, 412);
            this.btnVerficarAdmin.Margin = new System.Windows.Forms.Padding(17, 49, 17, 49);
            this.btnVerficarAdmin.Name = "btnVerficarAdmin";
            this.btnVerficarAdmin.Normalcolor = System.Drawing.Color.DarkBlue;
            this.btnVerficarAdmin.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnVerficarAdmin.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerficarAdmin.selected = false;
            this.btnVerficarAdmin.Size = new System.Drawing.Size(247, 62);
            this.btnVerficarAdmin.TabIndex = 11;
            this.btnVerficarAdmin.Text = "Verficar credenciales";
            this.btnVerficarAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerficarAdmin.Textcolor = System.Drawing.Color.White;
            this.btnVerficarAdmin.TextFont = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerficarAdmin.Click += new System.EventHandler(this.btnVerficarAdmin_Click);
            // 
            // txtClaveAdmin
            // 
            this.txtClaveAdmin.Location = new System.Drawing.Point(19, 282);
            this.txtClaveAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClaveAdmin.Name = "txtClaveAdmin";
            this.txtClaveAdmin.Size = new System.Drawing.Size(292, 25);
            this.txtClaveAdmin.TabIndex = 3;
            this.txtClaveAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveAdmin_KeyPress);
            // 
            // txtCorreoAdmin
            // 
            this.txtCorreoAdmin.Location = new System.Drawing.Point(21, 229);
            this.txtCorreoAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreoAdmin.Name = "txtCorreoAdmin";
            this.txtCorreoAdmin.Size = new System.Drawing.Size(290, 25);
            this.txtCorreoAdmin.TabIndex = 2;
            // 
            // txtUsuarioAdmin
            // 
            this.txtUsuarioAdmin.Location = new System.Drawing.Point(19, 173);
            this.txtUsuarioAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuarioAdmin.Name = "txtUsuarioAdmin";
            this.txtUsuarioAdmin.Size = new System.Drawing.Size(292, 25);
            this.txtUsuarioAdmin.TabIndex = 1;
            this.txtUsuarioAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioAdmin_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Correo del administrador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contraseña del administrado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btnRecuperar);
            this.groupBox2.Controls.Add(this.txtDocBloq);
            this.groupBox2.Controls.Add(this.txtCorreBloq);
            this.groupBox2.Controls.Add(this.txtUsuarioBloq);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(369, 65);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(339, 492);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credenciales del usuario bloqueado";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vista.Properties.Resources.user_rights_100px;
            this.pictureBox2.Location = new System.Drawing.Point(93, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Activecolor = System.Drawing.Color.Blue;
            this.btnRecuperar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnRecuperar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecuperar.BorderRadius = 4;
            this.btnRecuperar.ButtonText = "habilitar credenciales";
            this.btnRecuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecuperar.DisabledColor = System.Drawing.Color.DarkBlue;
            this.btnRecuperar.Enabled = false;
            this.btnRecuperar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRecuperar.Iconimage = global::Vista.Properties.Resources.checkmark_100px;
            this.btnRecuperar.Iconimage_right = null;
            this.btnRecuperar.Iconimage_right_Selected = null;
            this.btnRecuperar.Iconimage_Selected = null;
            this.btnRecuperar.IconMarginLeft = 0;
            this.btnRecuperar.IconMarginRight = 0;
            this.btnRecuperar.IconRightVisible = true;
            this.btnRecuperar.IconRightZoom = 0D;
            this.btnRecuperar.IconVisible = true;
            this.btnRecuperar.IconZoom = 65D;
            this.btnRecuperar.IsTab = false;
            this.btnRecuperar.Location = new System.Drawing.Point(46, 412);
            this.btnRecuperar.Margin = new System.Windows.Forms.Padding(17, 49, 17, 49);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Normalcolor = System.Drawing.Color.DarkBlue;
            this.btnRecuperar.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnRecuperar.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnRecuperar.selected = false;
            this.btnRecuperar.Size = new System.Drawing.Size(247, 62);
            this.btnRecuperar.TabIndex = 11;
            this.btnRecuperar.Text = "habilitar credenciales";
            this.btnRecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecuperar.Textcolor = System.Drawing.Color.White;
            this.btnRecuperar.TextFont = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // txtDocBloq
            // 
            this.txtDocBloq.Enabled = false;
            this.txtDocBloq.Location = new System.Drawing.Point(19, 282);
            this.txtDocBloq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDocBloq.Name = "txtDocBloq";
            this.txtDocBloq.Size = new System.Drawing.Size(292, 25);
            this.txtDocBloq.TabIndex = 3;
            this.txtDocBloq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocBloq_KeyPress);
            // 
            // txtCorreBloq
            // 
            this.txtCorreBloq.Enabled = false;
            this.txtCorreBloq.Location = new System.Drawing.Point(19, 225);
            this.txtCorreBloq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreBloq.Name = "txtCorreBloq";
            this.txtCorreBloq.Size = new System.Drawing.Size(292, 25);
            this.txtCorreBloq.TabIndex = 2;
            // 
            // txtUsuarioBloq
            // 
            this.txtUsuarioBloq.Enabled = false;
            this.txtUsuarioBloq.Location = new System.Drawing.Point(19, 173);
            this.txtUsuarioBloq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuarioBloq.Name = "txtUsuarioBloq";
            this.txtUsuarioBloq.Size = new System.Drawing.Size(292, 25);
            this.txtUsuarioBloq.TabIndex = 1;
            this.txtUsuarioBloq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioBloq_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Correo del usuario bloqueado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Documento del usuario bloqueado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre de usuario bloqueado:";
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
            this.pnlBarraSuperior.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Quality = 10;
            this.pnlBarraSuperior.Size = new System.Drawing.Size(720, 34);
            this.pnlBarraSuperior.TabIndex = 4;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Vista.Properties.Resources.minimize_window_100px;
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(654, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 30);
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
            this.btnCerrar.Location = new System.Drawing.Point(684, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 30);
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
            this.toolStrip1.Size = new System.Drawing.Size(720, 27);
            this.toolStrip1.TabIndex = 27;
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
            // FrmMetodo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(720, 570);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlBarraSuperior);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMetodo1";
            this.Opacity = 0.9D;
            this.Text = "FrmMetodo1";
            this.Load += new System.EventHandler(this.FrmMetodo1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClaveAdmin;
        private System.Windows.Forms.TextBox txtCorreoAdmin;
        private System.Windows.Forms.TextBox txtUsuarioAdmin;
        private Bunifu.Framework.UI.BunifuFlatButton btnVerficarAdmin;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecuperar;
        private System.Windows.Forms.TextBox txtDocBloq;
        private System.Windows.Forms.TextBox txtCorreBloq;
        private System.Windows.Forms.TextBox txtUsuarioBloq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlBarraSuperior;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ComboBox cmbTipoUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBack;
    }
}