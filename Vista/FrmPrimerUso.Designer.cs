namespace Vista
{
    partial class FrmPrimerUso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrimerUso));
            this.lblAccederPrimerUso = new System.Windows.Forms.Label();
            this.lblHolaPrimerUso = new System.Windows.Forms.Label();
            this.btnPrimerUso = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblContextoPrimerUso = new System.Windows.Forms.Label();
            this.rbtnIngles = new System.Windows.Forms.RadioButton();
            this.rbtnEspanol = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblAccederPrimerUso
            // 
            this.lblAccederPrimerUso.AutoSize = true;
            this.lblAccederPrimerUso.Location = new System.Drawing.Point(240, 150);
            this.lblAccederPrimerUso.Name = "lblAccederPrimerUso";
            this.lblAccederPrimerUso.Size = new System.Drawing.Size(313, 20);
            this.lblAccederPrimerUso.TabIndex = 5;
            this.lblAccederPrimerUso.Text = "Presiona el boton de acceder al primer uso";
            // 
            // lblHolaPrimerUso
            // 
            this.lblHolaPrimerUso.AutoSize = true;
            this.lblHolaPrimerUso.Location = new System.Drawing.Point(12, 30);
            this.lblHolaPrimerUso.Name = "lblHolaPrimerUso";
            this.lblHolaPrimerUso.Size = new System.Drawing.Size(746, 40);
            this.lblHolaPrimerUso.TabIndex = 4;
            this.lblHolaPrimerUso.Text = "Hola!, Bienvenido al Sistema administrado de veterinaria, en el podrás como se me" +
    "nciona anteiormente\r\nadministrar la infomación de una veterinaria, de una manera" +
    " general.";
            // 
            // btnPrimerUso
            // 
            this.btnPrimerUso.BackColor = System.Drawing.Color.DarkBlue;
            this.btnPrimerUso.color = System.Drawing.Color.DarkBlue;
            this.btnPrimerUso.colorActive = System.Drawing.Color.MediumBlue;
            this.btnPrimerUso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimerUso.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnPrimerUso.ForeColor = System.Drawing.Color.White;
            this.btnPrimerUso.Image = global::Vista.Properties.Resources.Inveternacion_admin_white;
            this.btnPrimerUso.ImagePosition = 20;
            this.btnPrimerUso.ImageZoom = 50;
            this.btnPrimerUso.LabelPosition = 41;
            this.btnPrimerUso.LabelText = "Acceder";
            this.btnPrimerUso.Location = new System.Drawing.Point(276, 178);
            this.btnPrimerUso.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnPrimerUso.Name = "btnPrimerUso";
            this.btnPrimerUso.Size = new System.Drawing.Size(215, 183);
            this.btnPrimerUso.TabIndex = 6;
            this.btnPrimerUso.Click += new System.EventHandler(this.btnPrimerUso_Click);
            // 
            // lblContextoPrimerUso
            // 
            this.lblContextoPrimerUso.AutoSize = true;
            this.lblContextoPrimerUso.Location = new System.Drawing.Point(12, 90);
            this.lblContextoPrimerUso.Name = "lblContextoPrimerUso";
            this.lblContextoPrimerUso.Size = new System.Drawing.Size(757, 60);
            this.lblContextoPrimerUso.TabIndex = 7;
            this.lblContextoPrimerUso.Text = resources.GetString("lblContextoPrimerUso.Text");
            // 
            // rbtnIngles
            // 
            this.rbtnIngles.AutoSize = true;
            this.rbtnIngles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnIngles.Location = new System.Drawing.Point(119, 337);
            this.rbtnIngles.Name = "rbtnIngles";
            this.rbtnIngles.Size = new System.Drawing.Size(70, 24);
            this.rbtnIngles.TabIndex = 0;
            this.rbtnIngles.Text = "Ingles";
            this.rbtnIngles.UseVisualStyleBackColor = true;
            this.rbtnIngles.CheckedChanged += new System.EventHandler(this.rbtnIngles_CheckedChanged);
            // 
            // rbtnEspanol
            // 
            this.rbtnEspanol.AutoSize = true;
            this.rbtnEspanol.Checked = true;
            this.rbtnEspanol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnEspanol.Location = new System.Drawing.Point(16, 337);
            this.rbtnEspanol.Name = "rbtnEspanol";
            this.rbtnEspanol.Size = new System.Drawing.Size(83, 24);
            this.rbtnEspanol.TabIndex = 0;
            this.rbtnEspanol.TabStop = true;
            this.rbtnEspanol.Text = "Español";
            this.rbtnEspanol.UseVisualStyleBackColor = true;
            this.rbtnEspanol.CheckedChanged += new System.EventHandler(this.rbtnEspanol_CheckedChanged);
            // 
            // FrmPrimerUso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 389);
            this.Controls.Add(this.rbtnEspanol);
            this.Controls.Add(this.rbtnIngles);
            this.Controls.Add(this.lblContextoPrimerUso);
            this.Controls.Add(this.btnPrimerUso);
            this.Controls.Add(this.lblAccederPrimerUso);
            this.Controls.Add(this.lblHolaPrimerUso);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrimerUso";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrimerUso";
            this.Load += new System.EventHandler(this.FrmPrimerUso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnPrimerUso;
        private System.Windows.Forms.Label lblAccederPrimerUso;
        private System.Windows.Forms.Label lblHolaPrimerUso;
        private System.Windows.Forms.Label lblContextoPrimerUso;
        private System.Windows.Forms.RadioButton rbtnIngles;
        private System.Windows.Forms.RadioButton rbtnEspanol;
    }
}