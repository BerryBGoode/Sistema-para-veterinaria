namespace Vista
{
    partial class FrmMétodosRecup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMétodosRecup));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.borde = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMetodo1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMetodo3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMetodo2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlBarraSuperior = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMetodo1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMetodo3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMetodo2)).BeginInit();
            this.pnlBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 34);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(544, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(293, 22);
            this.toolStripLabel1.Text = "Métodos de recuperación de contraseña";
            // 
            // borde
            // 
            this.borde.ElipseRadius = 10;
            this.borde.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 120);
            this.label1.TabIndex = 6;
            this.label1.Text = "Por intervención de administrador: \r\nEste método consiste en que el\r\nque un admin" +
    "istrador del sistema\r\ningrese sus credenciales, las habilite\r\ny despúes poner la" +
    "s del usuario \r\nbloqueado ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 80);
            this.label2.TabIndex = 7;
            this.label2.Text = "Por mensaje al correo:\r\nConsiste enviar un mensaje via correo\r\ndonde se le enviar" +
    "á la contraseña por\r\ndefecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 140);
            this.label3.TabIndex = 8;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMetodo1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 153);
            this.panel1.TabIndex = 9;
            // 
            // btnMetodo1
            // 
            this.btnMetodo1.BackColor = System.Drawing.Color.DarkBlue;
            this.btnMetodo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMetodo1.Image = global::Vista.Properties.Resources.Inveternacion_admin_white;
            this.btnMetodo1.ImageActive = null;
            this.btnMetodo1.Location = new System.Drawing.Point(24, 27);
            this.btnMetodo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMetodo1.Name = "btnMetodo1";
            this.btnMetodo1.Size = new System.Drawing.Size(157, 105);
            this.btnMetodo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMetodo1.TabIndex = 5;
            this.btnMetodo1.TabStop = false;
            this.btnMetodo1.Zoom = 10;
            this.btnMetodo1.Click += new System.EventHandler(this.btnMetodo1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMetodo3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 153);
            this.panel2.TabIndex = 10;
            // 
            // btnMetodo3
            // 
            this.btnMetodo3.BackColor = System.Drawing.Color.DarkBlue;
            this.btnMetodo3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMetodo3.Image = global::Vista.Properties.Resources.mail_100px;
            this.btnMetodo3.ImageActive = null;
            this.btnMetodo3.Location = new System.Drawing.Point(24, 21);
            this.btnMetodo3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMetodo3.Name = "btnMetodo3";
            this.btnMetodo3.Size = new System.Drawing.Size(157, 105);
            this.btnMetodo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMetodo3.TabIndex = 5;
            this.btnMetodo3.TabStop = false;
            this.btnMetodo3.Zoom = 10;
            this.btnMetodo3.Click += new System.EventHandler(this.btnMetodo3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMetodo2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 164);
            this.panel3.TabIndex = 11;
            // 
            // btnMetodo2
            // 
            this.btnMetodo2.BackColor = System.Drawing.Color.DarkBlue;
            this.btnMetodo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMetodo2.Image = ((System.Drawing.Image)(resources.GetObject("btnMetodo2.Image")));
            this.btnMetodo2.ImageActive = null;
            this.btnMetodo2.Location = new System.Drawing.Point(24, 31);
            this.btnMetodo2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMetodo2.Name = "btnMetodo2";
            this.btnMetodo2.Size = new System.Drawing.Size(157, 105);
            this.btnMetodo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMetodo2.TabIndex = 5;
            this.btnMetodo2.TabStop = false;
            this.btnMetodo2.Zoom = 10;
            this.btnMetodo2.Click += new System.EventHandler(this.btnMetodo2_Click);
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
            this.pnlBarraSuperior.Size = new System.Drawing.Size(544, 34);
            this.pnlBarraSuperior.TabIndex = 3;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Vista.Properties.Resources.minimize_window_100px;
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(478, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.btnCerrar.Location = new System.Drawing.Point(508, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmMétodosRecup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(544, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlBarraSuperior);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMétodosRecup";
            this.Opacity = 0.9D;
            this.Text = "FrmMétodosRecup";
            this.Load += new System.EventHandler(this.FrmMétodosRecup_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMetodo1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMetodo3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMetodo2)).EndInit();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private Bunifu.Framework.UI.BunifuElipse borde;
        private Bunifu.Framework.UI.BunifuImageButton btnMetodo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnMetodo2;
        private Bunifu.Framework.UI.BunifuImageButton btnMetodo3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}