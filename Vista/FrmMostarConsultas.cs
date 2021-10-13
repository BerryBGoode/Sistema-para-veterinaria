using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Controlador;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmMostarConsultas : Form
    {
        public FrmMostarConsultas()
        {
            InitializeComponent();
            CargarConsulta();
            dgvListaConsulta.Columns[0].Visible = false;

        }
        public FrmMostarConsultas(int dif)
        {
            InitializeComponent();
            CargarConsulta();
            pnlGenerar.Visible = false;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            valormostrar = 1;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void tsBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        void CargarConsulta()
        {
            dgvListaConsulta.DataSource = Controlador.ControladorConsulta.CargarConsultaGeneral_Controller();
            dgvListaConsulta.Columns[0].HeaderText = "Número de lista de consulta";
            dgvListaConsulta.Columns[1].HeaderText = "Paciente";
            dgvListaConsulta.Columns[2].HeaderText = "Peso";
            dgvListaConsulta.Columns[3].HeaderText = "Raza";
            dgvListaConsulta.Columns[4].HeaderText = "Propietario";
            dgvListaConsulta.Columns[5].HeaderText = "Documento del propietario";
            dgvListaConsulta.Columns[6].HeaderText = "Diagnostico";
            dgvListaConsulta.Columns[7].HeaderText = "Receta";
            dgvListaConsulta.Columns[8].HeaderText = "Tratamiento";
            dgvListaConsulta.Columns[9].HeaderText = "Fecha de la consulta";

        }
        void BuscarConsulta()
        {
            dgvListaConsulta.DataSource = Controlador.ControladorConsulta.BuscarConsulta_Controller(txtBuscar.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarConsulta();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "Buscar por nombre del paciente, documento, fecha, diagnostico o receta")
            {
                txtBuscar.Text = "";
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "")
            {
                txtBuscar.Text = "Buscar por nombre del paciente, documento, fecha, diagnostico o receta";
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarConsulta();
        }
        List<ControladorConsulta> ListaConsulta = new List<ControladorConsulta>();

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
            if (NameFile.Trim() != "")
            {
                FileStream archivo = new FileStream(NameFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

                PdfWriter.GetInstance(doc, archivo);
                doc.Open();
                string remitente = "Veterinaria patitas saludables";
                string envio = "Fecha" + DateTime.Now.ToString();

                Chunk chunk = new Chunk("Reporte general de consultas", FontFactory.GetFont("Trebuchet MS", 14, iTextSharp.text.Font.NORMAL));
                doc.Add(new Paragraph(chunk));
                doc.AddAuthor(AtributoLogin.usuario);

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Reporte general de consultas"));
                doc.Add(new Paragraph(remitente));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                FrmMostrarFactura.reporte(doc, dgvListaConsulta);//Aqui se envia el texto escrito por defecto al método reporte, para que el método reporte para que agrege las listas
                doc.AddCreationDate();
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(remitente));
                doc.Close();
                Process.Start(NameFile);
            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarPDF();
        }
        public static int valormostrar { get; set; }

        private void FrmMostarConsultas_Load(object sender, EventArgs e)
        {
            valormostrar = 2;    
            switch (FrmMain.valortraducir)
            {
                case 1:
                    txtBuscar.Text = InglesConsulta.txtBuscarConsulta;
                    btnBuscar.Text = InglesConsulta.btnBuscadorConsulta;
                    btnRecargar.Text = InglesConsulta.btnRecargarConsulta;
                    label1.Text = InglesConsulta.lblListadoConsulta;
                    btnCerrar.Text = "Close form";

                    dgvListaConsulta.Columns[0].HeaderText = "Number of list";
                    dgvListaConsulta.Columns[1].HeaderText = "Pacient name";
                    dgvListaConsulta.Columns[2].HeaderText = "Weight";
                    dgvListaConsulta.Columns[3].HeaderText = "Breed";
                    dgvListaConsulta.Columns[4].HeaderText = "Owner names";
                    dgvListaConsulta.Columns[5].HeaderText = "Number of document of owner";
                    dgvListaConsulta.Columns[6].HeaderText = "Diagnosis";
                    dgvListaConsulta.Columns[7].HeaderText = "Recipe";
                    dgvListaConsulta.Columns[8].HeaderText = "Treatment";
                    dgvListaConsulta.Columns[9].HeaderText = "Appointment date";
                    break;
                default:
                    break;
            }
        }
    }
}
