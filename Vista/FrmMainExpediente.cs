using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;// libreria de "DllImport"
using System.Text;
using Controlador;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmMainExpediente : Form
    {
        public FrmMainExpediente()
        {
            InitializeComponent();
            valorexpediente = 2;
        }
        public static int valorexpediente { get; set; }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlBarraSuperior_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            valorexpediente = 1;
        }

        private void lklAccederExpediente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtExpedienteAcceso.Text.Trim() == "")
            {
                switch (FrmMain.valortraducir)
                {
                    case 1:
                        MessageBox.Show("The field is empty, please fill that field", "incomplete data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        MessageBox.Show("El campo está vacío, porfavor llenar ese campo", "Campos vacíos",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                comprobarLista();
            }
        }
        
        void comprobarLista()
        {
            FrmExpediente expediente;
            ControladorExpediente aEX = new ControladorExpediente();
            aEX.NumListaConuslta = Convert.ToInt16(txtExpedienteAcceso.Text);
            List<int> lista = new List<int>();
            lista = aEX.EncontrarConsulta();
            int respuesta =  aEX.AccesoExpediente();
            if(respuesta >= 1)
            {
                int respuestaExisteExpediente = aEX.ComprobarExpediente();
                if (respuestaExisteExpediente == 0)
                {
                    aEX.NumListaConuslta = Convert.ToInt16(lista[0]);                
                    int idconsulta = Convert.ToInt16(txtExpedienteAcceso.Text);
                    expediente = new FrmExpediente(idconsulta);
                    expediente.txtIDConsulta.Text = Convert.ToString(lista[0]);
                    expediente.Show();
                    this.Hide();
                }
                else if (respuestaExisteExpediente == 1)
                {
                    AtributosExpediente.IdConsulta = Convert.ToInt16(txtExpedienteAcceso.Text);
                    DialogResult drq;
                    switch (FrmMain.valortraducir)
                    {
                        case 2:
                            drq = MessageBox.Show("El de está consulta ya existe, ¿Deseá ver la descripción de está consulta?", "Mensaje de notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);                    
                            if (drq == DialogResult.Yes)
                            {
                                expediente = new FrmExpediente();
                                expediente.Show();
                                this.Hide();
                            }                    
                            break;
                        case 1:
                            drq = MessageBox.Show("The one of this query already exists, do you want to see the description of this appointment?", "Message of notificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (drq == DialogResult.Yes)
                            {
                                expediente = new FrmExpediente();
                                expediente.Show();
                                this.Hide();
                            }                    

                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                switch (FrmMain.valortraducir)
                {
                    case 1:
                        MessageBox.Show("This appointment is not registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        MessageBox.Show("No se encuentra registrado esa consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        break;
                }
            }
        }
        private void lklMostrarPerros_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMostarConsultas frmmostrar = new FrmMostarConsultas(1);
            frmmostrar.Show();
        }

        private void txtExpedienteAcceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }


        private void FrmMainExpediente_Load(object sender, EventArgs e)
        {
            switch (FrmMain.valortraducir)
            {
                case 1:
                    label1.Text = InglesExpediente.lblMainExpe;
                    label2.Text = InglesExpediente.lbl2;
                    lklAccederExpediente.Text = InglesExpediente.lklAccederExpediente;
                    lklMostrar.Text = InglesExpediente.lklMostrarMainExpe;
                    break;
                default:
                    break;
            }

        }
    }
}
