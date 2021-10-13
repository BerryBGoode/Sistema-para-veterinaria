namespace Vista
{
    partial class FrmMostrarPerros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarPerros));
            this.tsBarra = new System.Windows.Forms.ToolStrip();
            this.txtBuscarPaciente = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.btnRecargar = new System.Windows.Forms.ToolStripButton();
            this.lblPacientesdgv = new System.Windows.Forms.Label();
            this.dgvListasPacientes_propie = new System.Windows.Forms.DataGridView();
            this.pnlGenerar = new System.Windows.Forms.Panel();
            this.btnGenerarPDF = new Bunifu.Framework.UI.BunifuImageButton();
            this.label16 = new System.Windows.Forms.Label();
            this.tsBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListasPacientes_propie)).BeginInit();
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
            this.txtBuscarPaciente,
            this.btnBuscar,
            this.btnCerrar,
            this.btnRecargar});
            this.tsBarra.Location = new System.Drawing.Point(0, 0);
            this.tsBarra.Name = "tsBarra";
            this.tsBarra.Size = new System.Drawing.Size(710, 27);
            this.tsBarra.TabIndex = 0;
            this.tsBarra.Text = "toolStrip1";
            this.tsBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsBarra_MouseDown);
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.AutoSize = false;
            this.txtBuscarPaciente.BackColor = System.Drawing.Color.MediumBlue;
            this.txtBuscarPaciente.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPaciente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(325, 25);
            this.txtBuscarPaciente.Text = "Buscar por nombre o documento de propietario";
            this.txtBuscarPaciente.Enter += new System.EventHandler(this.txtBuscarPaciente_Enter);
            this.txtBuscarPaciente.Leave += new System.EventHandler(this.txtBuscarPaciente_Leave);
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
            this.btnCerrar.Text = "Cerrar formulario";
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
            // lblPacientesdgv
            // 
            this.lblPacientesdgv.AutoSize = true;
            this.lblPacientesdgv.ForeColor = System.Drawing.Color.Black;
            this.lblPacientesdgv.Location = new System.Drawing.Point(8, 37);
            this.lblPacientesdgv.Name = "lblPacientesdgv";
            this.lblPacientesdgv.Size = new System.Drawing.Size(212, 20);
            this.lblPacientesdgv.TabIndex = 2;
            this.lblPacientesdgv.Text = "Listado general de pacientes";
            // 
            // dgvListasPacientes_propie
            // 
            this.dgvListasPacientes_propie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListasPacientes_propie.Location = new System.Drawing.Point(12, 72);
            this.dgvListasPacientes_propie.Name = "dgvListasPacientes_propie";
            this.dgvListasPacientes_propie.RowTemplate.Height = 24;
            this.dgvListasPacientes_propie.Size = new System.Drawing.Size(686, 504);
            this.dgvListasPacientes_propie.TabIndex = 3;
            // 
            // pnlGenerar
            // 
            this.pnlGenerar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGenerar.Controls.Add(this.btnGenerarPDF);
            this.pnlGenerar.Controls.Add(this.label16);
            this.pnlGenerar.Location = new System.Drawing.Point(620, 37);
            this.pnlGenerar.Name = "pnlGenerar";
            this.pnlGenerar.Size = new System.Drawing.Size(78, 29);
            this.pnlGenerar.TabIndex = 35;
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
            // FrmMostrarPerros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(710, 588);
            this.Controls.Add(this.pnlGenerar);
            this.Controls.Add(this.dgvListasPacientes_propie);
            this.Controls.Add(this.lblPacientesdgv);
            this.Controls.Add(this.tsBarra);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMostrarPerros";
            this.Opacity = 0.9D;
            this.Text = "FrmMostrarPerros";
            this.Load += new System.EventHandler(this.FrmMostrarPerros_Load);
            this.tsBarra.ResumeLayout(false);
            this.tsBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListasPacientes_propie)).EndInit();
            this.pnlGenerar.ResumeLayout(false);
            this.pnlGenerar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerarPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBarra;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripTextBox txtBuscarPaciente;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.Label lblPacientesdgv;
        private System.Windows.Forms.DataGridView dgvListasPacientes_propie;
        private System.Windows.Forms.ToolStripButton btnRecargar;
        private System.Windows.Forms.Panel pnlGenerar;
        private Bunifu.Framework.UI.BunifuImageButton btnGenerarPDF;
        private System.Windows.Forms.Label label16;
    }
}