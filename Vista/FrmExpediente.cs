using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Controlador;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmExpediente : Form
    {

        public FrmExpediente(int pidconsulta)
        {
            InitializeComponent();
            
            txtIDConsulta.Text = Convert.ToString(pidconsulta);
            chkModificar.Visible = false;           
           
        } 
      
        public FrmExpediente()
        {
            InitializeComponent();
            CargarExpediente();
            pnlAgregar.Visible = false;
            txtDescripcion.Enabled = false;
            dtFechaExpediente.Enabled = false;
            chkModificar.Visible = true;
            pnlEliminar.Visible = true;
            pnlEliminar.Enabled = false;
            pnlActualizar.Visible = true;
            pnlActualizar.Enabled = false;
        }       
        ControladorExpediente a = new ControladorExpediente();        
        private void btnCerrarExpediente_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmMainExpediente acceder = new FrmMainExpediente();
            acceder.Show();
        }
        public void CargarExpediente()
        {
            ControladorExpediente datosexpdiente = new ControladorExpediente();
            int consulta = AtributosExpediente.IdConsulta;
            FrmMainExpediente accesoexpediente = new FrmMainExpediente();
            int IDconsulta = datosexpdiente.CargarID(consulta);
            if (IDconsulta != 0)
            {
                List<string> ListaDetalle = new List<string>();
                ListaDetalle = datosexpdiente.CargarDetalle(consulta);
                txtIDConsulta.Text = Convert.ToString(consulta);
                if (ListaDetalle != null)
                {
                    CargarDetalle(Convert.ToString(ListaDetalle[0]));
                }
                List<string> ListaFecha = new List<string>();
                ListaFecha = datosexpdiente.CargarFecha(consulta);
                if (ListaFecha != null)
                {
                    CargarFecha(Convert.ToString(ListaFecha[0]));
                }
            }
        }
        void CargarDetalle(string pdetalle)
        {
            txtDescripcion.Text = Convert.ToString(pdetalle);
        }
        void CargarFecha(string pfecha)
        {
            dtFechaExpediente.Text = pfecha;
        }
        void AgregarExpediente()//Agregar descripción está bien solo necesito encontrar como enviar el id, por medio del formulario anterior
        {

            if (txtIDConsulta.Text.Trim() == "" || txtDescripcion.Text.Trim() == "")
            {
                switch (FrmMain.valortraducir)
                {
                    case 1: MessageBox.Show("There are empty fields, please fill them", "incomplete data", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    case 2:                MessageBox.Show("Existen campos vacíos, porfavor llenarlos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    default:
                        break;
                }
            }
            //else if (Convert.ToString(dtFechaExpediente.Value.Date) != AtributosExpediente.Confirmarfecha)
            //{
            //    MessageBox.Show("a");
            //}
            else
            {
                a.descrip = txtDescripcion.Text;
                a.fecha_consulta = dtFechaExpediente.Text;
                a.NumListaConuslta = Convert.ToInt16(txtIDConsulta.Text);
                int respuesta = a.AgregarExpediente();
                if (respuesta == 2)
                {
                    pnlAgregar.Visible = false;
                    txtDescripcion.Enabled = false;
                    dtFechaExpediente.Enabled = false;
                    chkModificar.Visible = true;
                    pnlEliminar.Visible = true;
                    pnlEliminar.Enabled = false;
                    pnlActualizar.Visible = true;
                    pnlActualizar.Enabled = false;
                }
                else
                {
                    switch (FrmMain.valortraducir)
                    {
                        case 1:
                            MessageBox.Show("Data entry error", "Critical error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 2:
                            MessageBox.Show("Error al ingresar datos", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        default:
                            break;
                    }
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarExpediente();
        }

        private void chkModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModificar.Checked == true)
            {
                txtDescripcion.Enabled = true;
                dtFechaExpediente.Enabled = true;
                pnlActualizar.Enabled = true;
                pnlEliminar.Enabled = true;
                pnlEliminar.Visible = true;

                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                txtDescripcion.Enabled = false;
                dtFechaExpediente.Enabled = false;
                pnlActualizar.Enabled = false;
                pnlEliminar.Enabled = false;

            }
        }
        void Actualizar()
        {
            if (txtDescripcion.Text.Trim() == "" || txtDescripcion.Enabled == false || dtFechaExpediente.Enabled == false  || btnActualizar.Enabled == false)
            {
                switch (FrmMain.valortraducir)
                {
                    case 1:
                        MessageBox.Show("Error, there are some empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        MessageBox.Show("Error, existen algunos campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                ControladorExpediente datos = new ControladorExpediente();
                AtributosExpediente.IdConsulta = Convert.ToInt16(txtIDConsulta.Text);
                int respuesta = datos.ActualizarExpediente(txtDescripcion.Text, dtFechaExpediente.Text);
                if (respuesta == 1)
                {
                    txtDescripcion.Enabled = false;
                    dtFechaExpediente.Enabled = false;
                    btnActualizar.Enabled = false;
                }
                else
                {
                    txtDescripcion.Enabled = true;
                    dtFechaExpediente.Enabled = true;
                    btnActualizar.Enabled = true;                    
                }
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        void Eliminar()
        {
            if (txtDescripcion.Text == "" || txtIDConsulta.Text == "")
            {
                switch (FrmMain.valortraducir)
                {
                    case 1:
                        MessageBox.Show("Possibly you have deleted a field from the file, if you want to delete that file, re-enter this file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        MessageBox.Show("Posiblemente has borrado un campo del expediente, si quieres eliminar ese expediente, vuelve a ingresar a este expediente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                ControladorExpediente objexpediente = new ControladorExpediente();
                AtributosExpediente.IdConsulta = Convert.ToInt16(txtIDConsulta.Text);
                bool Respuesta = objexpediente.EliminarExpediente();
                if (Respuesta == true)
                {
                    txtDescripcion.Clear();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult drq;
            switch (FrmMain.valortraducir)
            {
                case 1:
                    drq = MessageBox.Show("Do you want delete the file?", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drq == DialogResult.Yes)
                    {
                        Eliminar();
                        pnlEliminar.Enabled = false;
                        pnlActualizar.Enabled = false;
                    }
                    break;
                case 2:
                    drq = MessageBox.Show("¿Deseas eliminar este expediente?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drq == DialogResult.Yes)
                    {
                        Eliminar();
                        pnlEliminar.Enabled = false;
                        pnlActualizar.Enabled = false;
                    }
                    break;
                default:
                    break;
            }
        }

        private void FrmExpediente_Load(object sender, EventArgs e)
        {
            switch (FrmMain.valortraducir)
            {
                case 1:  
                    lblDescripConsultaExpe.Text = InglesExpediente.lblDescripConsulExpe;
                    lblFechaConsultExpe.Text = InglesExpediente.lblFechaConsulExpe;
                    chkModificar.Text = InglesExpediente.chkModificarExp;
                    lblActualizar.Text = InglesExpediente.lblActualizarrExp;
                    lblAgregar.Text = InglesExpediente.lblAgregarExp;
                    lblEliminar.Text = InglesExpediente.lblEliminarExp;
                    break;
                default:
                    break;
            }
        }
    }
}
