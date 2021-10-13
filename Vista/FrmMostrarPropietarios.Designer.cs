namespace Vista
{
    partial class FrmMostrarPropietarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarPropietarios));
            this.dgvPropietarios = new System.Windows.Forms.DataGridView();
            this.tsBarra = new System.Windows.Forms.ToolStrip();
            this.txtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.btnRecargar = new System.Windows.Forms.ToolStripButton();
            this.lblPropietariosdgv = new System.Windows.Forms.Label();
            this.pnlGenerar = new System.Windows.Forms.Panel();
            this.btnGenerar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.lblContactodgv = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerarPDF = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlRecargar = new System.Windows.Forms.Panel();
            this.btnRecargarContacto = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblRecargar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscarcontacto = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscarContacto = new System.Windows.Forms.TextBox();
            this.lblDescrpBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietarios)).BeginInit();
            this.tsBarra.SuspendLayout();
            this.pnlGenerar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerarPDF)).BeginInit();
            this.pnlRecargar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargarContacto)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarcontacto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPropietarios
            // 
            this.dgvPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropietarios.Location = new System.Drawing.Point(12, 72);
            this.dgvPropietarios.Name = "dgvPropietarios";
            this.dgvPropietarios.RowTemplate.Height = 24;
            this.dgvPropietarios.Size = new System.Drawing.Size(643, 289);
            this.dgvPropietarios.TabIndex = 2;
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
            this.tsBarra.Size = new System.Drawing.Size(710, 27);
            this.tsBarra.TabIndex = 3;
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
            this.txtBuscar.Size = new System.Drawing.Size(325, 25);
            this.txtBuscar.Text = "Buscar por nombre o número de documento";
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
            // lblPropietariosdgv
            // 
            this.lblPropietariosdgv.AutoSize = true;
            this.lblPropietariosdgv.ForeColor = System.Drawing.Color.Black;
            this.lblPropietariosdgv.Location = new System.Drawing.Point(12, 37);
            this.lblPropietariosdgv.Name = "lblPropietariosdgv";
            this.lblPropietariosdgv.Size = new System.Drawing.Size(227, 20);
            this.lblPropietariosdgv.TabIndex = 4;
            this.lblPropietariosdgv.Text = "Listado general de propietarios";
            // 
            // pnlGenerar
            // 
            this.pnlGenerar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGenerar.Controls.Add(this.btnGenerar);
            this.pnlGenerar.Controls.Add(this.label16);
            this.pnlGenerar.Location = new System.Drawing.Point(620, 37);
            this.pnlGenerar.Name = "pnlGenerar";
            this.pnlGenerar.Size = new System.Drawing.Size(78, 29);
            this.pnlGenerar.TabIndex = 34;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.ImageActive = null;
            this.btnGenerar.Location = new System.Drawing.Point(0, 0);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(35, 29);
            this.btnGenerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.TabStop = false;
            this.btnGenerar.Zoom = 10;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
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
            // dgvContactos
            // 
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(12, 402);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowTemplate.Height = 24;
            this.dgvContactos.Size = new System.Drawing.Size(438, 189);
            this.dgvContactos.TabIndex = 2;
            // 
            // lblContactodgv
            // 
            this.lblContactodgv.AutoSize = true;
            this.lblContactodgv.ForeColor = System.Drawing.Color.Black;
            this.lblContactodgv.Location = new System.Drawing.Point(8, 379);
            this.lblContactodgv.Name = "lblContactodgv";
            this.lblContactodgv.Size = new System.Drawing.Size(323, 20);
            this.lblContactodgv.TabIndex = 4;
            this.lblContactodgv.Text = "Listado general de propietarios con contacto";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnGenerarPDF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(620, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 29);
            this.panel1.TabIndex = 34;
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
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDFContacto);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "PDF";
            // 
            // pnlRecargar
            // 
            this.pnlRecargar.Controls.Add(this.btnRecargarContacto);
            this.pnlRecargar.Controls.Add(this.lblRecargar);
            this.pnlRecargar.Enabled = false;
            this.pnlRecargar.Location = new System.Drawing.Point(588, 548);
            this.pnlRecargar.Name = "pnlRecargar";
            this.pnlRecargar.Size = new System.Drawing.Size(112, 43);
            this.pnlRecargar.TabIndex = 68;
            // 
            // btnRecargarContacto
            // 
            this.btnRecargarContacto.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargarContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargarContacto.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRecargarContacto.Image = global::Vista.Properties.Resources.refresh_blue_100px;
            this.btnRecargarContacto.ImageActive = null;
            this.btnRecargarContacto.Location = new System.Drawing.Point(0, 0);
            this.btnRecargarContacto.Name = "btnRecargarContacto";
            this.btnRecargarContacto.Size = new System.Drawing.Size(35, 43);
            this.btnRecargarContacto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRecargarContacto.TabIndex = 6;
            this.btnRecargarContacto.TabStop = false;
            this.btnRecargarContacto.Zoom = 10;
            this.btnRecargarContacto.Click += new System.EventHandler(this.btnRecargarContacto_Click);
            // 
            // lblRecargar
            // 
            this.lblRecargar.AutoSize = true;
            this.lblRecargar.Location = new System.Drawing.Point(35, 2);
            this.lblRecargar.Name = "lblRecargar";
            this.lblRecargar.Size = new System.Drawing.Size(71, 40);
            this.lblRecargar.TabIndex = 5;
            this.lblRecargar.Text = "Recargar\r\nlista";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBuscarcontacto);
            this.panel2.Controls.Add(this.lblBuscar);
            this.panel2.Location = new System.Drawing.Point(600, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 37);
            this.panel2.TabIndex = 66;
            // 
            // btnBuscarcontacto
            // 
            this.btnBuscarcontacto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarcontacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarcontacto.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscarcontacto.Image = global::Vista.Properties.Resources.search_100px;
            this.btnBuscarcontacto.ImageActive = null;
            this.btnBuscarcontacto.Location = new System.Drawing.Point(0, 0);
            this.btnBuscarcontacto.Name = "btnBuscarcontacto";
            this.btnBuscarcontacto.Size = new System.Drawing.Size(35, 37);
            this.btnBuscarcontacto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarcontacto.TabIndex = 5;
            this.btnBuscarcontacto.TabStop = false;
            this.btnBuscarcontacto.Zoom = 10;
            this.btnBuscarcontacto.Click += new System.EventHandler(this.btnBuscarcontacto_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(37, 9);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(55, 20);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscarContacto
            // 
            this.txtBuscarContacto.Location = new System.Drawing.Point(467, 445);
            this.txtBuscarContacto.Name = "txtBuscarContacto";
            this.txtBuscarContacto.Size = new System.Drawing.Size(231, 25);
            this.txtBuscarContacto.TabIndex = 65;
            // 
            // lblDescrpBuscar
            // 
            this.lblDescrpBuscar.AutoSize = true;
            this.lblDescrpBuscar.Location = new System.Drawing.Point(465, 402);
            this.lblDescrpBuscar.Name = "lblDescrpBuscar";
            this.lblDescrpBuscar.Size = new System.Drawing.Size(235, 40);
            this.lblDescrpBuscar.TabIndex = 69;
            this.lblDescrpBuscar.Text = "Buscar por nombre, número de \r\ndocumento o contacto";
            // 
            // FrmMostrarPropietarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(710, 603);
            this.Controls.Add(this.lblDescrpBuscar);
            this.Controls.Add(this.pnlRecargar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBuscarContacto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGenerar);
            this.Controls.Add(this.lblContactodgv);
            this.Controls.Add(this.lblPropietariosdgv);
            this.Controls.Add(this.tsBarra);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.dgvPropietarios);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMostrarPropietarios";
            this.Opacity = 0.9D;
            this.Text = "FrmMostrarPropietarios";
            this.Load += new System.EventHandler(this.FrmMostrarPropietarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietarios)).EndInit();
            this.tsBarra.ResumeLayout(false);
            this.tsBarra.PerformLayout();
            this.pnlGenerar.ResumeLayout(false);
            this.pnlGenerar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerarPDF)).EndInit();
            this.pnlRecargar.ResumeLayout(false);
            this.pnlRecargar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargarContacto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarcontacto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPropietarios;
        private System.Windows.Forms.ToolStrip tsBarra;
        private System.Windows.Forms.ToolStripTextBox txtBuscar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.Label lblPropietariosdgv;
        private System.Windows.Forms.ToolStripButton btnRecargar;
        private System.Windows.Forms.Panel pnlGenerar;
        private Bunifu.Framework.UI.BunifuImageButton btnGenerar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.Label lblContactodgv;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnGenerarPDF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlRecargar;
        private Bunifu.Framework.UI.BunifuImageButton btnRecargarContacto;
        private System.Windows.Forms.Label lblRecargar;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarcontacto;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscarContacto;
        private System.Windows.Forms.Label lblDescrpBuscar;
    }
}