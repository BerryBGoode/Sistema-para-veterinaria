using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmMostrarPerros : Form
    {
        public FrmMostrarPerros()
        {
            InitializeComponent();
            dgvListasPacientes_propie.DataSource = Controlador.PerrosController.cargarpropietarioShow();

            dgvListasPacientes_propie.Columns[0].HeaderText = "Número de lista";
            dgvListasPacientes_propie.Columns[1].HeaderText = "Paciente";
            dgvListasPacientes_propie.Columns[2].HeaderText = "Fecha de nacimiento";
            dgvListasPacientes_propie.Columns[3].HeaderText = "Peso";
            dgvListasPacientes_propie.Columns[4].HeaderText = "Tamaño";
            dgvListasPacientes_propie.Columns[5].HeaderText = "Raza";
            dgvListasPacientes_propie.Columns[6].HeaderText = "Genero";
            dgvListasPacientes_propie.Columns[7].HeaderText = "Nombre del propietario";
            dgvListasPacientes_propie.Columns[8].HeaderText = "Número de documento";

            dgvListasPacientes_propie.Columns[0].Visible = false;
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

        private void txtBuscarPaciente_Enter(object sender, EventArgs e)
        {
            if (txtBuscarPaciente.Text.Trim()== "Buscar por nombre o documento de propietario")
            {
                txtBuscarPaciente.Text = "";
            }
        }
        private void txtBuscarPaciente_Leave(object sender, EventArgs e)
        {
            if (txtBuscarPaciente.Text.Trim() == "")
            {
                txtBuscarPaciente.Text = "Buscar por nombre o documento de propietario";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvListasPacientes_propie.DataSource = Controlador.PerrosController.BuscarListageneral(txtBuscarPaciente.Text);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            dgvListasPacientes_propie.DataSource = Controlador.PerrosController.cargarpropietarioShow();
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
            if (NameFile.Trim() != "")
            {
                FileStream archivo = new FileStream(NameFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

                PdfWriter.GetInstance(doc, archivo);
                doc.Open();
                string remitente = "Veterinaria patitas saludables";
                string envio = "Fecha" + DateTime.Now.ToString();

                Chunk chunk = new Chunk("Reporte general de pacientes", FontFactory.GetFont("Trebuchet MS", 14, iTextSharp.text.Font.NORMAL));
                doc.Add(new Paragraph(chunk));
                doc.AddAuthor(Controlador.AtributoLogin.usuario);

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Reporte general de pacientes"));
                doc.Add(new Paragraph(remitente));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                FrmMostrarFactura.reporte(doc, dgvListasPacientes_propie);//Aqui se envia el texto escrito por defecto al método reporte, para que el método reporte para que agrege las listas
                doc.AddCreationDate();
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(remitente));
                doc.Close();
                Process.Start(NameFile);
            }

        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            GenerarPDF();
        }
        void Traducir()
        {
            switch (FrmMain.valortraducir)
            {
                case 1:
                    txtBuscarPaciente.Text = InglesPerros.txtBuscarPaciente;
                    btnBuscar.Text = InglesPerros.lblBuscarPerrosBoton;
                    btnRecargar.Text = InglesPerros.btnRecargar;
                    lblPacientesdgv.Text = InglesPerros.lblListadoPacientes;
                    btnCerrar.Text = "Close form";

                    dgvListasPacientes_propie.Columns[0].HeaderText = "Number of list";
                    dgvListasPacientes_propie.Columns[1].HeaderText = "Pacient name";
                    dgvListasPacientes_propie.Columns[2].HeaderText = "Date of birth";
                    dgvListasPacientes_propie.Columns[3].HeaderText = "Weight";
                    dgvListasPacientes_propie.Columns[4].HeaderText = "Size";
                    dgvListasPacientes_propie.Columns[5].HeaderText = "Breed";
                    dgvListasPacientes_propie.Columns[6].HeaderText = "Gender";
                    dgvListasPacientes_propie.Columns[7].HeaderText = "Names of owner";
                    dgvListasPacientes_propie.Columns[8].HeaderText = "Number of document";
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
        private void FrmMostrarPerros_Load(object sender, EventArgs e)
        {
            Traducir();
            valormostrar = 2;
        }
        public static int valormostrar { get; set; }
    }
}
