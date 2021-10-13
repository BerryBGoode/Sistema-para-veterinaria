namespace Vista
{
    partial class FrmCambiarClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambiarClave));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveAntigua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuevaClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.btnCambiarClave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlBarraSuperior = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.ckbMostrarClave = new System.Windows.Forms.CheckBox();
            this.pnlBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formulario para restablecer contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña antigua:";
            // 
            // txtClaveAntigua
            // 
            this.txtClaveAntigua.Location = new System.Drawing.Point(27, 105);
            this.txtClaveAntigua.Name = "txtClaveAntigua";
            this.txtClaveAntigua.Size = new System.Drawing.Size(311, 25);
            this.txtClaveAntigua.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nueva contraseña:";
            // 
            // txtNuevaClave
            // 
            this.txtNuevaClave.Location = new System.Drawing.Point(27, 187);
            this.txtNuevaClave.Name = "txtNuevaClave";
            this.txtNuevaClave.Size = new System.Drawing.Size(311, 25);
            this.txtNuevaClave.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmar contraseña:";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(27, 269);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.Size = new System.Drawing.Size(311, 25);
            this.txtConfirmarClave.TabIndex = 8;
            this.txtConfirmarClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarClave_KeyPress);
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.lblAdvertencia.Location = new System.Drawing.Point(59, 297);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(232, 20);
            this.lblAdvertencia.TabIndex = 9;
            this.lblAdvertencia.Text = "*Las constraseñas no coinciden*";
            this.lblAdvertencia.Visible = false;
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.Activecolor = System.Drawing.Color.Blue;
            this.btnCambiarClave.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCambiarClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCambiarClave.BorderRadius = 4;
            this.btnCambiarClave.ButtonText = "Cambiar contraseña";
            this.btnCambiarClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarClave.DisabledColor = System.Drawing.Color.MediumBlue;
            this.btnCambiarClave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCambiarClave.Iconimage = global::Vista.Properties.Resources.password_reset_White_100px;
            this.btnCambiarClave.Iconimage_right = null;
            this.btnCambiarClave.Iconimage_right_Selected = null;
            this.btnCambiarClave.Iconimage_Selected = null;
            this.btnCambiarClave.IconMarginLeft = 0;
            this.btnCambiarClave.IconMarginRight = 0;
            this.btnCambiarClave.IconRightVisible = true;
            this.btnCambiarClave.IconRightZoom = 0D;
            this.btnCambiarClave.IconVisible = true;
            this.btnCambiarClave.IconZoom = 75D;
            this.btnCambiarClave.IsTab = false;
            this.btnCambiarClave.Location = new System.Drawing.Point(51, 372);
            this.btnCambiarClave.Margin = new System.Windows.Forms.Padding(34, 144, 34, 144);
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Normalcolor = System.Drawing.Color.DarkBlue;
            this.btnCambiarClave.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnCambiarClave.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCambiarClave.selected = false;
            this.btnCambiarClave.Size = new System.Drawing.Size(255, 79);
            this.btnCambiarClave.TabIndex = 22;
            this.btnCambiarClave.Text = "Cambiar contraseña";
            this.btnCambiarClave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambiarClave.Textcolor = System.Drawing.Color.White;
            this.btnCambiarClave.TextFont = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarClave.Click += new System.EventHandler(this.btnCambiarClave_Click);
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
            this.pnlBarraSuperior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Quality = 10;
            this.pnlBarraSuperior.Size = new System.Drawing.Size(370, 34);
            this.pnlBarraSuperior.TabIndex = 1;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Vista.Properties.Resources.minimize_window_100px;
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(301, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 10;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Vista.Properties.Resources.close_window_100px;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(334, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ckbMostrarClave
            // 
            this.ckbMostrarClave.AutoSize = true;
            this.ckbMostrarClave.Location = new System.Drawing.Point(193, 330);
            this.ckbMostrarClave.Name = "ckbMostrarClave";
            this.ckbMostrarClave.Size = new System.Drawing.Size(165, 24);
            this.ckbMostrarClave.TabIndex = 23;
            this.ckbMostrarClave.Text = "Mostrar contraseña";
            this.ckbMostrarClave.UseVisualStyleBackColor = true;
            this.ckbMostrarClave.CheckedChanged += new System.EventHandler(this.ckbMostrarClave_CheckedChanged);
            // 
            // FrmCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 474);
            this.Controls.Add(this.ckbMostrarClave);
            this.Controls.Add(this.btnCambiarClave);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.txtConfirmarClave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNuevaClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClaveAntigua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBarraSuperior);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCambiarClave";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCambiarClave";
            this.Load += new System.EventHandler(this.FrmCambiarClave_Load);
            this.pnlBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlBarraSuperior;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNuevaClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaveAntigua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAdvertencia;
        private Bunifu.Framework.UI.BunifuFlatButton btnCambiarClave;
        private System.Windows.Forms.CheckBox ckbMostrarClave;
    }
}