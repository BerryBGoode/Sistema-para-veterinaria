namespace Vista
{
    partial class FrmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            this.lklRestablecer = new System.Windows.Forms.LinkLabel();
            this.lklingresar = new System.Windows.Forms.LinkLabel();
            this.borde = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.chkContraseña = new System.Windows.Forms.CheckBox();
            this.lblAdvertencia1 = new System.Windows.Forms.Label();
            this.lblAdveterncia2 = new System.Windows.Forms.Label();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlBarraSuperior = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.rbtnEspañol = new System.Windows.Forms.RadioButton();
            this.rbtnIngles = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.pnlBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lklRestablecer
            // 
            this.lklRestablecer.ActiveLinkColor = System.Drawing.Color.White;
            this.lklRestablecer.AutoSize = true;
            this.lklRestablecer.DisabledLinkColor = System.Drawing.Color.DarkBlue;
            this.lklRestablecer.LinkColor = System.Drawing.Color.DarkBlue;
            this.lklRestablecer.Location = new System.Drawing.Point(509, 298);
            this.lklRestablecer.Name = "lklRestablecer";
            this.lklRestablecer.Size = new System.Drawing.Size(193, 20);
            this.lklRestablecer.TabIndex = 4;
            this.lklRestablecer.TabStop = true;
            this.lklRestablecer.Text = "¿Has olvido la contraseña?";
            this.lklRestablecer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklRestablecer_LinkClicked);
            // 
            // lklingresar
            // 
            this.lklingresar.ActiveLinkColor = System.Drawing.Color.White;
            this.lklingresar.AutoSize = true;
            this.lklingresar.DisabledLinkColor = System.Drawing.Color.DarkBlue;
            this.lklingresar.ForeColor = System.Drawing.Color.Black;
            this.lklingresar.LinkColor = System.Drawing.Color.Black;
            this.lklingresar.Location = new System.Drawing.Point(467, 261);
            this.lklingresar.Name = "lklingresar";
            this.lklingresar.Size = new System.Drawing.Size(99, 20);
            this.lklingresar.TabIndex = 3;
            this.lklingresar.TabStop = true;
            this.lklingresar.Text = "Iniciar sesión";
            this.lklingresar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklingresar_LinkClicked);
            // 
            // borde
            // 
            this.borde.ElipseRadius = 10;
            this.borde.TargetControl = this;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblContraseña.Location = new System.Drawing.Point(360, 136);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(93, 20);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtClave.ForeColor = System.Drawing.Color.Black;
            this.txtClave.Location = new System.Drawing.Point(364, 159);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(288, 25);
            this.txtClave.TabIndex = 2;
            this.txtClave.Enter += new System.EventHandler(this.txtClave_Enter_1);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            this.txtClave.Leave += new System.EventHandler(this.txtClave_Leave);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblNombreUsuario.Location = new System.Drawing.Point(360, 48);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(148, 20);
            this.lblNombreUsuario.TabIndex = 8;
            this.lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(364, 71);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(288, 25);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // chkContraseña
            // 
            this.chkContraseña.AutoSize = true;
            this.chkContraseña.ForeColor = System.Drawing.Color.Black;
            this.chkContraseña.Location = new System.Drawing.Point(513, 221);
            this.chkContraseña.Name = "chkContraseña";
            this.chkContraseña.Size = new System.Drawing.Size(165, 24);
            this.chkContraseña.TabIndex = 9;
            this.chkContraseña.Text = "Mostrar contraseña";
            this.chkContraseña.UseVisualStyleBackColor = true;
            this.chkContraseña.CheckedChanged += new System.EventHandler(this.chkContraseña_CheckedChanged);
            // 
            // lblAdvertencia1
            // 
            this.lblAdvertencia1.AutoSize = true;
            this.lblAdvertencia1.ForeColor = System.Drawing.Color.Crimson;
            this.lblAdvertencia1.Location = new System.Drawing.Point(360, 99);
            this.lblAdvertencia1.Name = "lblAdvertencia1";
            this.lblAdvertencia1.Size = new System.Drawing.Size(229, 20);
            this.lblAdvertencia1.TabIndex = 8;
            this.lblAdvertencia1.Text = "*Ingrese su nombre de usuario*";
            this.lblAdvertencia1.Visible = false;
            // 
            // lblAdveterncia2
            // 
            this.lblAdveterncia2.AutoSize = true;
            this.lblAdveterncia2.ForeColor = System.Drawing.Color.Crimson;
            this.lblAdveterncia2.Location = new System.Drawing.Point(360, 187);
            this.lblAdveterncia2.Name = "lblAdveterncia2";
            this.lblAdveterncia2.Size = new System.Drawing.Size(174, 20);
            this.lblAdveterncia2.TabIndex = 8;
            this.lblAdveterncia2.Text = "*Ingrese su contraseña*";
            this.lblAdveterncia2.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Vista.Properties.Resources.close_window_100px;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(670, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Vista.Properties.Resources.minimize_window_100px;
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(640, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 10;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.pnlBarraSuperior.Size = new System.Drawing.Size(710, 34);
            this.pnlBarraSuperior.TabIndex = 2;
            this.pnlBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraSuperior_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 342);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // notify
            // 
            this.notify.Text = "notifyIcon1";
            this.notify.Visible = true;
            // 
            // rbtnEspañol
            // 
            this.rbtnEspañol.AutoSize = true;
            this.rbtnEspañol.Checked = true;
            this.rbtnEspañol.Location = new System.Drawing.Point(517, 340);
            this.rbtnEspañol.Name = "rbtnEspañol";
            this.rbtnEspañol.Size = new System.Drawing.Size(83, 24);
            this.rbtnEspañol.TabIndex = 11;
            this.rbtnEspañol.TabStop = true;
            this.rbtnEspañol.Text = "Español";
            this.rbtnEspañol.UseVisualStyleBackColor = true;
            this.rbtnEspañol.CheckedChanged += new System.EventHandler(this.rbtnEspañol_CheckedChanged);
            // 
            // rbtnIngles
            // 
            this.rbtnIngles.AutoSize = true;
            this.rbtnIngles.Location = new System.Drawing.Point(624, 340);
            this.rbtnIngles.Name = "rbtnIngles";
            this.rbtnIngles.Size = new System.Drawing.Size(70, 24);
            this.rbtnIngles.TabIndex = 11;
            this.rbtnIngles.Text = "Ingles";
            this.rbtnIngles.UseVisualStyleBackColor = true;
            this.rbtnIngles.CheckedChanged += new System.EventHandler(this.rbtnIngles_CheckedChanged);
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(710, 376);
            this.Controls.Add(this.rbtnIngles);
            this.Controls.Add(this.rbtnEspañol);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblAdveterncia2);
            this.Controls.Add(this.lblAdvertencia1);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lklingresar);
            this.Controls.Add(this.lklRestablecer);
            this.Controls.Add(this.pnlBarraSuperior);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogIn";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogIng";
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.pnlBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lklRestablecer;
        private System.Windows.Forms.LinkLabel lklingresar;
        private Bunifu.Framework.UI.BunifuElipse borde;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.CheckBox chkContraseña;
        private System.Windows.Forms.Label lblAdvertencia1;
        private System.Windows.Forms.Label lblAdveterncia2;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlBarraSuperior;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.RadioButton rbtnIngles;
        private System.Windows.Forms.RadioButton rbtnEspañol;
    }
}