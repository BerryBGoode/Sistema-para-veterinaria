using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Vista
{
    public partial class FrmMostrarEmpleados : Form
    {
        public FrmMostrarEmpleados()
        {
            InitializeComponent();
            CargarLista();
            NivelUsuario();
        }
        public static int valormostrar { get; set; } 
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmEmpleados empleados = new FrmEmpleados();
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

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "Buscar por nombre, documento o cargo")
            {
                txtBuscar.Text = "";
            }
            else
            {
            }
        }
        void CargarLista()
        {
            dgvListasEmpleados.DataSource = Controlador.ControladorEmpleado.CargarEmpleados_ControladorGeneral();
            dgvListasEmpleados.Columns[0].HeaderText = "Número de lista";
            dgvListasEmpleados.Columns[1].HeaderText = "Nombre";
            dgvListasEmpleados.Columns[2].HeaderText = "Apellidos";
            dgvListasEmpleados.Columns[3].HeaderText = "Fecha de nacimiento";
            dgvListasEmpleados.Columns[4].HeaderText = "Tipo de documento";
            dgvListasEmpleados.Columns[5].HeaderText = "Número de documento";
            dgvListasEmpleados.Columns[6].HeaderText = "Municipio";
            dgvListasEmpleados.Columns[7].HeaderText = "Departamento";
            dgvListasEmpleados.Columns[8].HeaderText = "Cargo";

            dgvListasEmpleados.Columns[0].Visible = false;
        }
        void NivelUsuario()
        {
            switch (Controlador.ControladorLogIn.tipousuario)
            {
                case 1:
                    dgvListasEmpleados.Columns[4].Visible = false;
                    break;
                case 2:
                    dgvListasEmpleados.Columns[4].Visible = false;
                    dgvListasEmpleados.Columns[7].Visible = false;
                    break;
                default:
                    break;
            }
        }
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "")
            {
                
            }
            else
            {
               dgvListasEmpleados.DataSource = Controlador.ControladorEmpleado.CargarEmpleadosBuscar(txtBuscar.Text);
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "")
            {
                txtBuscar.Text = "Buscar por nombre, documento o cargo";
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarPDF();
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

                Chunk chunk = new Chunk("Reporte general de empleados", FontFactory.GetFont("Trebuchet MS", 14, iTextSharp.text.Font.NORMAL));
                doc.Add(new Paragraph(chunk));
                doc.AddAuthor(Controlador.AtributoLogin.usuario);

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Reporte general de empleados"));
                doc.Add(new Paragraph(remitente));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                FrmMostrarFactura.reporte(doc, dgvListasEmpleados);//Aqui se envia el texto escrito por defecto al método reporte, para que el método reporte para que agrege las listas
                doc.AddCreationDate();
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(remitente));
                doc.Close();
                Process.Start(NameFile);
            }

        }

        private void FrmMostrarEmpleados_Load(object sender, EventArgs e)
        {
            switch (FrmMain.valortraducir)
            {
                case 1:
                    txtBuscar.Text = InglesEmpleados.txtBuscarEmpleado;
                    btnBuscar.Text = InglesEmpleados.btnBuscadorEmpleado;
                    btnRecargar.Text = InglesEmpleados.btnRecargarEmpleado;
                    label1.Text = InglesEmpleados.lblListadoEmpleado;
                    btnCerrar.Text = "Close form";

                    dgvListasEmpleados.Columns[0].HeaderText = "Number of list";
                    dgvListasEmpleados.Columns[1].HeaderText = "Names";
                    dgvListasEmpleados.Columns[2].HeaderText = "Last names";
                    dgvListasEmpleados.Columns[3].HeaderText = "Date of birth";
                    dgvListasEmpleados.Columns[4].HeaderText = "Type of document";
                    dgvListasEmpleados.Columns[5].HeaderText = "Number of document";
                    dgvListasEmpleados.Columns[6].HeaderText = "Municipality";
                    dgvListasEmpleados.Columns[7].HeaderText = "Departament";
                    dgvListasEmpleados.Columns[8].HeaderText = "Work position";
                    break;
                default:
                    break;
            }
            valormostrar = 2;
        }
    }
}
