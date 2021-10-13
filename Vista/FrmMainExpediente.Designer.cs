namespace Vista
{
    partial class FrmMainExpediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainExpediente));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlMainExpediente = new System.Windows.Forms.Panel();
            this.lklMostrar = new System.Windows.Forms.LinkLabel();
            this.lklAccederExpediente = new System.Windows.Forms.LinkLabel();
            this.txtExpedienteAcceso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBarraSuperior = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMainExpediente.SuspendLayout();
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
            // pnlMainExpediente
            // 
            this.pnlMainExpediente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMainExpediente.Controls.Add(this.lklMostrar);
            this.pnlMainExpediente.Controls.Add(this.lklAccederExpediente);
            this.pnlMainExpediente.Controls.Add(this.txtExpedienteAcceso);
            this.pnlMainExpediente.Controls.Add(this.label2);
            this.pnlMainExpediente.Controls.Add(this.label1);
            this.pnlMainExpediente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainExpediente.Location = new System.Drawing.Point(0, 38);
            this.pnlMainExpediente.Name = "pnlMainExpediente";
            this.pnlMainExpediente.Size = new System.Drawing.Size(383, 374);
            this.pnlMainExpediente.TabIndex = 2;
            // 
            // lklMostrar
            // 
            this.lklMostrar.AutoSize = true;
            this.lklMostrar.DisabledLinkColor = System.Drawing.Color.DarkBlue;
            this.lklMostrar.LinkColor = System.Drawing.Color.DarkBlue;
            this.lklMostrar.Location = new System.Drawing.Point(32, 303);
            this.lklMostrar.Name = "lklMostrar";
            this.lklMostrar.Size = new System.Drawing.Size(186, 20);
            this.lklMostrar.TabIndex = 2;
            this.lklMostrar.TabStop = true;
            this.lklMostrar.Text = "Mostrar lista de consultas";
            this.lklMostrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklMostrarPerros_LinkClicked);
            // 
            // lklAccederExpediente
            // 
            this.lklAccederExpediente.AutoSize = true;
            this.lklAccederExpediente.DisabledLinkColor = System.Drawing.Color.DarkBlue;
            this.lklAccederExpediente.ForeColor = System.Drawing.Color.Black;
            this.lklAccederExpediente.LinkColor = System.Drawing.Color.Black;
            this.lklAccederExpediente.Location = new System.Drawing.Point(88, 193);
            this.lklAccederExpediente.Name = "lklAccederExpediente";
            this.lklAccederExpediente.Size = new System.Drawing.Size(171, 20);
            this.lklAccederExpediente.TabIndex = 2;
            this.lklAccederExpediente.TabStop = true;
            this.lklAccederExpediente.Text = "Acceder al expediente";
            this.lklAccederExpediente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklAccederExpediente_LinkClicked);
            // 
            // txtExpedienteAcceso
            // 
            this.txtExpedienteAcceso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtExpedienteAcceso.ForeColor = System.Drawing.Color.Black;
            this.txtExpedienteAcceso.Location = new System.Drawing.Point(36, 114);
            this.txtExpedienteAcceso.Name = "txtExpedienteAcceso";
            this.txtExpedienteAcceso.Size = new System.Drawing.Size(284, 25);
            this.txtExpedienteAcceso.TabIndex = 1;
            this.txtExpedienteAcceso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpedienteAcceso_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número de lista de la consulta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario para acceder al expediente del paciente";
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
            this.pnlBarraSuperior.Size = new System.Drawing.Size(383, 38);
            this.pnlBarraSuperior.TabIndex = 1;
            this.pnlBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraSuperior_MouseDown_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Vista.Properties.Resources.minimize_window_100px;
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(315, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Vista.Properties.Resources.close_window_100px;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(346, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmMainExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 412);
            this.Controls.Add(this.pnlMainExpediente);
            this.Controls.Add(this.pnlBarraSuperior);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMainExpediente";
            this.Opacity = 0.9D;
            this.Text = "FrmMainExpediente";
            this.Load += new System.EventHandler(this.FrmMainExpediente_Load);
            this.pnlMainExpediente.ResumeLayout(false);
            this.pnlMainExpediente.PerformLayout();
            this.pnlBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlMainExpediente;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlBarraSuperior;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.LinkLabel lklMostrar;
        private System.Windows.Forms.LinkLabel lklAccederExpediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtExpedienteAcceso;
    }
}