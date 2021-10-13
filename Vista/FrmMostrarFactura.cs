using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;
using System.Runtime.InteropServices;
using Controlador;
using System.Windows.Forms;
using System.Diagnostics;

namespace Vista
{
    public partial class FrmMostrarFactura : Form
    {
        public FrmMostrarFactura()
        {
            InitializeComponent();
            CargarFacturas();
            valormostrar = 2;
        }
        public static int valormostrar { get; set; }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void tsBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        void CargarFacturas()
        {
            dgvFacturas.DataSource = ControladorFactura.CargarListaGeneralFactura();

            dgvFacturas.Columns[0].HeaderText = "Número de lista de factura";
            dgvFacturas.Columns[1].HeaderText = "Nombres";
            dgvFacturas.Columns[2].HeaderText = "Apellidos";
            dgvFacturas.Columns[3].HeaderText = "Numero de documento";
            dgvFacturas.Columns[4].HeaderText = "Fecha de facturación";
            dgvFacturas.Columns[5].HeaderText = "Nombre del usuario";
            dgvFacturas.Columns[6].HeaderText = "Monto";
            dgvFacturas.Columns[7].HeaderText = "Estado de la factura";

            dgvFacturas.Columns[0].Visible = false;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            valormostrar = 1;
        }
        void BuscarFactura()
        {
            dgvFacturas.DataSource = ControladorFactura.CargarBusquedaFactura(txtBuscar.Text);
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "Buscar documento del propietario, fecha o estado")
            {
                txtBuscar.Text = "";
            }
        }
        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "")
            {
                txtBuscar.Text = "Buscar documento del propietario, fecha o estado";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarFactura();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            dgvFacturas.DataSource = ControladorFactura.CargarListaGeneralFactura();
        }
        void GenerarPDF()
        {
            Document doc = new Document(PageSize.Legal);
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.InitialDirectory = "@C";
            guardar.Title = "Guardar Reporte";
            guardar.DefaultExt = "pdf";
            guardar.Filter = "pdf files (*.pdf) |*.pdf| All files (*.*)|*.*";
            guardar.FilterIndex = 3;
            guardar.RestoreDirectory = true;
            string NameFile = "";
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                NameFile = guardar.FileName;
            }
            if (NameFile.Trim() != "" )
            {
                FileStream archivo = new FileStream(NameFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

                PdfWriter.GetInstance(doc, archivo);
                doc.Open();
                string remitente = "Veterinaria patitas saludables";
                string envio = "Fecha" + DateTime.Now.ToString();

                Chunk chunk = new Chunk("Reporte general de facturas", FontFactory.GetFont("Trebuchet MS", 14, iTextSharp.text.Font.NORMAL));
                doc.Add(new Paragraph(chunk));
                doc.AddAuthor(AtributoLogin.usuario);
                
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Reporte general de facturas realizadas"));
                doc.Add(new Paragraph(remitente));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                reporte(doc, dgvFacturas);//Aqui se envia el texto escrito por defecto al método reporte, para que el método reporte para que agrege las listas
                doc.AddCreationDate();
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(remitente));
                doc.Close();
                Process.Start(NameFile);
            }

        }
        public static void reporte(Document doc, DataGridView dgv)
        {
            //b == Filas
            // a == columnas
            int a, b;
            PdfPTable data = new PdfPTable(dgv.ColumnCount);
            data.DefaultCell.Padding = 2;
            data.WidthPercentage = 100;
            data.DefaultCell.BorderWidth = 1;
            data.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (a = 0; a < dgv.ColumnCount; a++)
            {
                data.AddCell(dgv.Columns[a].HeaderText);
            }
            data.HeaderRows = 1;
            data.DefaultCell.BorderWidth = 1;
            for (a = 0; a < dgv.Rows.Count; a++)
            {
                for (b = 0; b < dgv.Columns.Count; b++)
                {
                    if (dgv[b, a].Value != null)
                    {
                        data.AddCell(new Phrase(Convert.ToString(dgv[b, a].Value)));
                    }
                }
                data.CompleteRow();
            }
            doc.Add(data);
        }
        
        #region GenerarReporte
        //void Reporte(Document doc)
        //{
        //    //b == Filas
        //    // a == columnas
        //    int a, b;
        //    PdfPTable data = new PdfPTable(dgvFacturas.ColumnCount);
        //    data.DefaultCell.Padding = 2;
        //    data.WidthPercentage = 100;
        //    data.DefaultCell.BorderWidth = 1;
        //    data.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
        //    for (a = 0; a < dgvFacturas.ColumnCount; a++)
        //    {
        //        data.AddCell(dgvFacturas.Columns[a].HeaderText);
        //    }
        //    data.HeaderRows = 1;
        //    data.DefaultCell.BorderWidth = 1;
        //    for (a = 0; a < dgvFacturas.Rows.Count; a++)
        //    {
        //        for (b = 0; b < dgvFacturas.Columns.Count; b++)
        //        {
        //            if (dgvFacturas[b, a].Value != null)
        //            {
        //                data.AddCell(new Phrase(Convert.ToString(dgvFacturas[b, a].Value)));
        //            }
        //        }
        //        data.CompleteRow();
        //    }
        //    doc.Add(data);
        //}
        #endregion

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            GenerarPDF();
        }

        private void FrmMostrarFactura_Load(object sender, EventArgs e)
        {
            switch (FrmMain.valortraducir)
            {
                case 1:
                    txtBuscar.Text = InglesFactura.txtBuscar;
                    btnBuscar.Text = InglesFactura.lblBuscarFactBoton;
                    btnRecargar.Text = InglesFactura.btnRecargar;
                    label1.Text = InglesFactura.lblListadoFactura;
                    btnCerrar.Text = "Close form";

                    dgvFacturas.Columns[0].HeaderText = "Number of list invoice";
                    dgvFacturas.Columns[1].HeaderText = "Names";
                    dgvFacturas.Columns[2].HeaderText = "Last names";
                    dgvFacturas.Columns[3].HeaderText = "Number of document";
                    dgvFacturas.Columns[4].HeaderText = "Billing date";
                    dgvFacturas.Columns[5].HeaderText = "Username";
                    dgvFacturas.Columns[6].HeaderText = "Total pay";
                    dgvFacturas.Columns[7].HeaderText = "Invoice status";
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
