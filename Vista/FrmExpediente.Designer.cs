namespace Vista
{
    partial class FrmExpediente
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCerrarExpediente = new System.Windows.Forms.ToolStripButton();
            this.txtIDConsulta = new System.Windows.Forms.ToolStripTextBox();
            this.lblDescripConsultaExpe = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblFechaConsultExpe = new System.Windows.Forms.Label();
            this.dtFechaExpediente = new System.Windows.Forms.DateTimePicker();
            this.chkModificar = new System.Windows.Forms.CheckBox();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.pnlActualizar = new System.Windows.Forms.Panel();
            this.btnActualizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblActualizar = new System.Windows.Forms.Label();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.pnlAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            this.pnlActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).BeginInit();
            this.pnlEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCerrarExpediente,
            this.txtIDConsulta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(382, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCerrarExpediente
            // 
            this.btnCerrarExpediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarExpediente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrarExpediente.Image = global::Vista.Properties.Resources.back_to_100px;
            this.btnCerrarExpediente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrarExpediente.Name = "btnCerrarExpediente";
            this.btnCerrarExpediente.Size = new System.Drawing.Size(24, 25);
            this.btnCerrarExpediente.Text = "Cerrar expediente";
            this.btnCerrarExpediente.Click += new System.EventHandler(this.btnCerrarExpediente_Click);
            // 
            // txtIDConsulta
            // 
            this.txtIDConsulta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIDConsulta.Name = "txtIDConsulta";
            this.txtIDConsulta.Size = new System.Drawing.Size(100, 28);
            this.txtIDConsulta.Visible = false;
            // 
            // lblDescripConsultaExpe
            // 
            this.lblDescripConsultaExpe.AutoSize = true;
            this.lblDescripConsultaExpe.ForeColor = System.Drawing.Color.Black;
            this.lblDescripConsultaExpe.Location = new System.Drawing.Point(22, 28);
            this.lblDescripConsultaExpe.Name = "lblDescripConsultaExpe";
            this.lblDescripConsultaExpe.Size = new System.Drawing.Size(199, 20);
            this.lblDescripConsultaExpe.TabIndex = 1;
            this.lblDescripConsultaExpe.Text = "Descripción de la consulta:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(26, 51);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(328, 310);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblFechaConsultExpe
            // 
            this.lblFechaConsultExpe.AutoSize = true;
            this.lblFechaConsultExpe.ForeColor = System.Drawing.Color.Black;
            this.lblFechaConsultExpe.Location = new System.Drawing.Point(22, 365);
            this.lblFechaConsultExpe.Name = "lblFechaConsultExpe";
            this.lblFechaConsultExpe.Size = new System.Drawing.Size(160, 20);
            this.lblFechaConsultExpe.TabIndex = 1;
            this.lblFechaConsultExpe.Text = "Fecha de la consulta:";
            // 
            // dtFechaExpediente
            // 
            this.dtFechaExpediente.CustomFormat = "yyyy-MM-dd";
            this.dtFechaExpediente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaExpediente.Location = new System.Drawing.Point(26, 389);
            this.dtFechaExpediente.Name = "dtFechaExpediente";
            this.dtFechaExpediente.Size = new System.Drawing.Size(328, 25);
            this.dtFechaExpediente.TabIndex = 4;
            // 
            // chkModificar
            // 
            this.chkModificar.AutoSize = true;
            this.chkModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkModificar.ForeColor = System.Drawing.Color.Black;
            this.chkModificar.Location = new System.Drawing.Point(207, 1);
            this.chkModificar.Name = "chkModificar";
            this.chkModificar.Size = new System.Drawing.Size(182, 24);
            this.chkModificar.TabIndex = 5;
            this.chkModificar.Text = "Modificar expediente";
            this.chkModificar.UseVisualStyleBackColor = true;
            this.chkModificar.Visible = false;
            this.chkModificar.CheckedChanged += new System.EventHandler(this.chkModificar_CheckedChanged);
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.Controls.Add(this.btnAgregar);
            this.pnlAgregar.Controls.Add(this.lblAgregar);
            this.pnlAgregar.Location = new System.Drawing.Point(123, 442);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(134, 58);
            this.pnlAgregar.TabIndex = 18;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregar.Image = global::Vista.Properties.Resources.add_100px;
            this.btnAgregar.ImageActive = null;
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(35, 58);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Zoom = 10;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblAgregar.Location = new System.Drawing.Point(43, 12);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(64, 40);
            this.lblAgregar.TabIndex = 4;
            this.lblAgregar.Text = "Agregar\r\ndatos";
            // 
            // pnlActualizar
            // 
            this.pnlActualizar.Controls.Add(this.btnActualizar);
            this.pnlActualizar.Controls.Add(this.lblActualizar);
            this.pnlActualizar.Location = new System.Drawing.Point(58, 441);
            this.pnlActualizar.Name = "pnlActualizar";
            this.pnlActualizar.Size = new System.Drawing.Size(134, 56);
            this.pnlActualizar.TabIndex = 19;
            this.pnlActualizar.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnActualizar.Image = global::Vista.Properties.Resources.update_left_rotation_100px;
            this.btnActualizar.ImageActive = null;
            this.btnActualizar.Location = new System.Drawing.Point(0, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(35, 56);
            this.btnActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.TabStop = false;
            this.btnActualizar.Zoom = 10;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblActualizar
            // 
            this.lblActualizar.AutoSize = true;
            this.lblActualizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblActualizar.Location = new System.Drawing.Point(43, 8);
            this.lblActualizar.Name = "lblActualizar";
            this.lblActualizar.Size = new System.Drawing.Size(80, 40);
            this.lblActualizar.TabIndex = 4;
            this.lblActualizar.Text = "Actualizar\r\ndatos";
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.Controls.Add(this.btnEliminar);
            this.pnlEliminar.Controls.Add(this.lblEliminar);
            this.pnlEliminar.Location = new System.Drawing.Point(230, 441);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(134, 56);
            this.pnlEliminar.TabIndex = 23;
            this.pnlEliminar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEliminar.Image = global::Vista.Properties.Resources.e;
            this.btnEliminar.ImageActive = null;
            this.btnEliminar.Location = new System.Drawing.Point(0, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(35, 56);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Zoom = 10;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblEliminar.Location = new System.Drawing.Point(43, 7);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(66, 40);
            this.lblEliminar.TabIndex = 5;
            this.lblEliminar.Text = "Eliminar\r\ndatos\r\n";
            // 
            // FrmExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(382, 534);
            this.Controls.Add(this.pnlEliminar);
            this.Controls.Add(this.pnlActualizar);
            this.Controls.Add(this.pnlAgregar);
            this.Controls.Add(this.chkModificar);
            this.Controls.Add(this.dtFechaExpediente);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblFechaConsultExpe);
            this.Controls.Add(this.lblDescripConsultaExpe);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmExpediente";
            this.Text = "FrmExpediente";
            this.Load += new System.EventHandler(this.FrmExpediente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlAgregar.ResumeLayout(false);
            this.pnlAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            this.pnlActualizar.ResumeLayout(false);
            this.pnlActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).EndInit();
            this.pnlEliminar.ResumeLayout(false);
            this.pnlEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCerrarExpediente;
        private System.Windows.Forms.Label lblDescripConsultaExpe;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblFechaConsultExpe;
        private System.Windows.Forms.DateTimePicker dtFechaExpediente;
        public System.Windows.Forms.ToolStripTextBox txtIDConsulta;
        private System.Windows.Forms.CheckBox chkModificar;
        private System.Windows.Forms.Panel pnlAgregar;
        private Bunifu.Framework.UI.BunifuImageButton btnAgregar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Panel pnlActualizar;
        private Bunifu.Framework.UI.BunifuImageButton btnActualizar;
        private System.Windows.Forms.Label lblActualizar;
        private System.Windows.Forms.Panel pnlEliminar;
        private Bunifu.Framework.UI.BunifuImageButton btnEliminar;
        private System.Windows.Forms.Label lblEliminar;
    }
}