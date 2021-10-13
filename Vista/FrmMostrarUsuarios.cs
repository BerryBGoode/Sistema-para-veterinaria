using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using Controlador;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmMostrarUsuarios : Form
    {
        public FrmMostrarUsuarios()
        {
            InitializeComponent();
            CargarUsusarios();
            NivelUsuario();
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
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "Buscar por nombre de usuario o número de documento")
            {
                txtBuscar.Text = "";
            }
        }
        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "")
            {
                txtBuscar.Text = "Buscar por nombre de usuario o número de documento";
            }
        }
        void CargarUsusarios()
        {
            DataTable cargarDatos;
            cargarDatos = ControladorUsuario.CargarUsuarios();
            dgvUsuarios.DataSource = cargarDatos;
            dgvUsuarios.Columns[0].HeaderText = "Número de lista";//
            dgvUsuarios.Columns[1].HeaderText = "Nombre de usuario";
            dgvUsuarios.Columns[2].HeaderText = "Contraseña";//
            dgvUsuarios.Columns[3].HeaderText = "Nombres";
            dgvUsuarios.Columns[4].HeaderText = "Apellidos";
            dgvUsuarios.Columns[5].HeaderText = "Número de documento";
            dgvUsuarios.Columns[6].HeaderText = "Tipo de usuario";//
            dgvUsuarios.Columns[7].HeaderText = "Estado";//
            dgvUsuarios.Columns[8].HeaderText = "Número de lista del empleado";//\

            dgvUsuarios.Columns[0].Visible = false;
            dgvUsuarios.Columns[2].Visible = false;
            dgvUsuarios.Columns[8].Visible = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = ControladorUsuario.BuscarUsuarios(txtBuscar.Text);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarUsusarios();
        }
        void NivelUsuario()
        {
            switch (ControladorLogIn.tipousuario)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
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

                Chunk chunk = new Chunk("Reporte general de usuarios", FontFactory.GetFont("Trebuchet MS", 14, iTextSharp.text.Font.NORMAL));
                doc.Add(new Paragraph(chunk));
                doc.AddAuthor(AtributoLogin.usuario);

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Reporte general de usuarios"));
                doc.Add(new Paragraph(remitente));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                FrmMostrarFactura.reporte(doc, dgvUsuarios);//Aqui se envia el texto escrito por defecto al método reporte, para que el método reporte para que agrege las listas
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
        public static int valormostrar { get; set; }
        private void FrmMostrarUsuarios_Load(object sender, EventArgs e)
        {
            traducir();
            valormostrar = 2;
        }
        void traducir()
        {
            switch (FrmMain.valortraducir)
            {
                case 1:
                    txtBuscar.Text = InglesUsuario.txtBuscar;
                    btnBuscar.Text = InglesUsuario.Buscar;
                    btnRecargar.Text = InglesUsuario.Recargar;
                    label1.Text = InglesUsuario.lblListadgvMostrar;
                    btnCerrar.Text = "Close form";
                    dgvUsuarios.Columns[0].HeaderText = "Number of list";//
                    dgvUsuarios.Columns[1].HeaderText = "Username";
                    dgvUsuarios.Columns[2].HeaderText = "Adress gmail";//
                    dgvUsuarios.Columns[3].HeaderText = "Names";
                    dgvUsuarios.Columns[4].HeaderText = "Last names";
                    dgvUsuarios.Columns[5].HeaderText = "Number of document";
                    dgvUsuarios.Columns[6].HeaderText = "Type of user";//
                    dgvUsuarios.Columns[7].HeaderText = "State";//
                    dgvUsuarios.Columns[8].HeaderText = "Number of list of employee";//
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
