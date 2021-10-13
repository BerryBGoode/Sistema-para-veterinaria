using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using Controlador;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace Vista
{
    public partial class FrmMostrarPropietarios : Form
    {
        public FrmMostrarPropietarios()
        {
            InitializeComponent();
            cargarListaPropietarios();
            CargarContactos();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            valormostrar = 1;           
        }
        void cargarListaPropietarios()
        {
            DataTable datos;
            datos = Controlador.ControladorPropietario.CargarPropietarios();
            dgvPropietarios.DataSource = datos;

            dgvPropietarios.Columns[0].HeaderText = "Número de lista";
            dgvPropietarios.Columns[1].HeaderText = "Nombres";
            dgvPropietarios.Columns[2].HeaderText = "Apellidos";
            dgvPropietarios.Columns[3].HeaderText = "Fecha de nacimiento";
            dgvPropietarios.Columns[4].HeaderText = "Tipo de documento";
            dgvPropietarios.Columns[5].HeaderText = "Número de documento";
            dgvPropietarios.Columns[6].HeaderText = "Municipio";
            dgvPropietarios.Columns[7].HeaderText = "Departamento";
            dgvPropietarios.Columns[8].HeaderText = "Estado";

            dgvPropietarios.Columns[0].Visible = false;
            dgvPropietarios.Columns[4].Visible = false;
            dgvPropietarios.Columns[7].Visible = false;                    
        }
        void BuscarPropietario()
        {
            dgvPropietarios.DataSource = Controlador.ControladorPropietario.CargarBusqueda(txtBuscar.Text);
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPropietario();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar por nombre o documento")
            {
                txtBuscar.Text = "";
            }
            
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar por nombre o documento";
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            cargarListaPropietarios();
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

                Chunk chunk = new Chunk("Reporte general de propietarios", FontFactory.GetFont("Trebuchet MS", 14, iTextSharp.text.Font.NORMAL));
                doc.Add(new Paragraph(chunk));
                doc.AddAuthor(AtributoLogin.usuario);

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Reporte general de propietarios"));
                doc.Add(new Paragraph(remitente));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                FrmMostrarFactura.reporte(doc, dgvPropietarios);//Aqui se envia el texto escrito por defecto al método reporte, para que el método reporte para que agrege las listas
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
        //DATAGRIDVIEW CONTACTO
        void CargarContactos()
        {

            dgvContactos.DataSource = ControladorPropietario.CargarContacto_Propietario();
            dgvContactos.Columns[0].HeaderText = "Número de lista";//Vis = F, != Root
            dgvContactos.Columns[1].HeaderText = "Nombres";
            dgvContactos.Columns[2].HeaderText = "Apellidos";
            dgvContactos.Columns[3].HeaderText = "Número de contacto";
            dgvContactos.Columns[4].HeaderText = "Número de documento";
            dgvContactos.Columns[5].HeaderText = "Número de lista del propietario";//Vis = F, !=root

            dgvContactos.Columns[0].Visible = false;
            dgvContactos.Columns[5].Visible = false;

        }
        private void btnBuscarcontacto_Click(object sender, EventArgs e)
        {
            dgvContactos.DataSource = ControladorPropietario.CargarContacto(txtBuscarContacto.Text);
        }
        private void btnRecargarContacto_Click(object sender, EventArgs e)
        {
            CargarContactos();
        }
        private void btnGenerarPDFContacto(object sender, EventArgs e)
        {
            GenerarPDFContacto();
        }
        void GenerarPDFContacto()
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

                Chunk chunk = new Chunk("Reporte general de propietarios y números de télefono", FontFactory.GetFont("Trebuchet MS", 14, iTextSharp.text.Font.NORMAL));
                doc.Add(new Paragraph(chunk));
                doc.AddAuthor(AtributoLogin.usuario);

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Reporte general de propietarios y números de télefono"));
                doc.Add(new Paragraph(remitente));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                FrmMostrarFactura.reporte(doc, dgvContactos);//Aqui se envia el texto escrito por defecto al método reporte, para que el método reporte para que agrege las listas
                doc.AddCreationDate();
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(remitente));
                doc.Close();
                Process.Start(NameFile);
            }

        }
        void Traducir()
        {
            switch (FrmMain.valortraducir)
            {
                case 1:
                    txtBuscar.Text = InglesPropietarios.txtBuscar;
                    lblBuscar.Text = InglesPropietarios.Buscar;
                    lblRecargar.Text = InglesPropietarios.Recargar;
                    btnBuscar.Text = InglesPropietarios.Buscar;
                    btnRecargar.Text = InglesPropietarios.Recargar;
                    lblPropietariosdgv.Text = InglesPropietarios.lblPropietariosdgv;
                    lblContactodgv.Text = InglesPropietarios.lblContactodgv;
                    lblDescrpBuscar.Text = InglesPropietarios.lblDescripBuscarMostrar;
                    btnCerrar.Text = "Close form";

                    dgvPropietarios.Columns[0].HeaderText = "Number of list";//Vis = F, != root
                    dgvPropietarios.Columns[1].HeaderText = "Names";
                    dgvPropietarios.Columns[2].HeaderText = "Last names";
                    dgvPropietarios.Columns[3].HeaderText = "Date of birth";
                    dgvPropietarios.Columns[4].HeaderText = "Type of document";//Vis = F, != Root
                    dgvPropietarios.Columns[5].HeaderText = "Number of document";
                    dgvPropietarios.Columns[6].HeaderText = "Municipality";
                    dgvPropietarios.Columns[7].HeaderText = "Departament";
                    dgvPropietarios.Columns[8].HeaderText = "State";//Visible = false en todos menos root            

                    dgvContactos.Columns[0].HeaderText = "Number of list of contact";//Vis = F, != Root
                    dgvContactos.Columns[1].HeaderText = "Names";
                    dgvContactos.Columns[2].HeaderText = "Last names";
                    dgvContactos.Columns[3].HeaderText = "Number of contact";
                    dgvContactos.Columns[4].HeaderText = "Number of document";
                    dgvContactos.Columns[5].HeaderText = "Number of list of owner";//Vis = F, !=root
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
        private void FrmMostrarPropietarios_Load(object sender, EventArgs e)
        {
            Traducir();
            valormostrar = 2;
        }
        public static int valormostrar { get; set; }
    }
}
