namespace Vista
{
    partial class FrmMostrarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarUsuarios));
            this.tsBarra = new System.Windows.Forms.ToolStrip();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.btnRecargar = new System.Windows.Forms.ToolStripButton();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGenerar = new System.Windows.Forms.Panel();
            this.btnGenerarPDF = new Bunifu.Framework.UI.BunifuImageButton();
            this.label16 = new System.Windows.Forms.Label();
            this.tsBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlGenerar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerarPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // tsBarra
            // 
            this.tsBarra.BackColor = System.Drawing.Color.MediumBlue;
            this.tsBarra.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBarra.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBarra.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtBuscar,
            this.btnBuscar,
            this.btnCerrar,
            this.btnRecargar});
            this.tsBarra.Location = new System.Drawing.Point(0, 0);
            this.tsBarra.Name = "tsBarra";
            this.tsBarra.Size = new System.Drawing.Size(641, 27);
            this.tsBarra.TabIndex = 6;
            this.tsBarra.Text = "toolStrip1";
            this.tsBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsBarra_MouseDown);
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoSize = false;
            this.txtBuscar.BackColor = System.Drawing.Color.MediumBlue;
            this.txtBuscar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(365, 25);
            this.txtBuscar.Text = "Buscar por nombre de usuario o número de documento ";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Image = global::Vista.Properties.Resources.search_white_100px;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 24);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrar.Image = global::Vista.Properties.Resources.close_window_100px;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 24);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRecargar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRecargar.Image = global::Vista.Properties.Resources.refresh_100px;
            this.btnRecargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(128, 24);
            this.btnRecargar.Text = "Recargar lista";
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 67);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(607, 504);
            this.dgvUsuarios.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Listado general de usuarios";
            // 
            // pnlGenerar
            // 
            this.pnlGenerar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGenerar.Controls.Add(this.btnGenerarPDF);
            this.pnlGenerar.Controls.Add(this.label16);
            this.pnlGenerar.Location = new System.Drawing.Point(545, 37);
            this.pnlGenerar.Name = "pnlGenerar";
            this.pnlGenerar.Size = new System.Drawing.Size(78, 29);
            this.pnlGenerar.TabIndex = 36;
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarPDF.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenerarPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarPDF.Image")));
            this.btnGenerarPDF.ImageActive = null;
            this.btnGenerarPDF.Location = new System.Drawing.Point(0, 0);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(35, 29);
            this.btnGenerarPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGenerarPDF.TabIndex = 6;
            this.btnGenerarPDF.TabStop = false;
            this.btnGenerarPDF.Zoom = 10;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "PDF";
            // 
            // FrmMostrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 588);
            this.Controls.Add(this.pnlGenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.tsBarra);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMostrarUsuarios";
            this.Opacity = 0.9D;
            this.Text = "FrmMostrarUsuarios";
            this.Load += new System.EventHandler(this.FrmMostrarUsuarios_Load);
            this.tsBarra.ResumeLayout(false);
            this.tsBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlGenerar.ResumeLayout(false);
            this.pnlGenerar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerarPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBarra;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnRecargar;
        private System.Windows.Forms.Panel pnlGenerar;
        private Bunifu.Framework.UI.BunifuImageButton btnGenerarPDF;
        private System.Windows.Forms.Label label16;
    }
}