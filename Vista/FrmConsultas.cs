using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class FrmConsultas : Form
    {
        public FrmConsultas()
        {
            
            InitializeComponent();
            CargarListas();
            CargarGridDatos();
            NivelesUsuario();
            pnlActualizar.Enabled = false;
            pnlEliminar.Enabled = false;
        }
        public DataTable datos;

        void LimpiarCampos()
        {
            txtDiagnostico.Clear();
            txtIdconsulta.Clear();
            txtIdperro.Clear();
            txtReceta.Clear();
            txtTratamiento.Clear();
            CargarListas();
            pnlActualizar.Enabled = false;
            pnlAgregar.Enabled = true;
            pnlEliminar.Enabled = false;
            pnlRecargar.Enabled = false;
            pnlRecargar2.Enabled = false;
        }
        
        #region CRUD de consultas
        
        #region Lectura de datos 
        void CargarListas()
        {
            try
            {
                dgvListaPerros.DataSource = ControladorConsulta.CargarListaPerro_Controller();

                dgvListaPerros.Columns[0].HeaderText = "Número de lista del paciente";
                dgvListaPerros.Columns[1].HeaderText = "Paciente";
                dgvListaPerros.Columns[2].HeaderText = "Peso";
                dgvListaPerros.Columns[3].HeaderText = "Raza";
                dgvListaPerros.Columns[4].HeaderText = "Propietario";
                dgvListaPerros.Columns[5].HeaderText = "Número de documento del propietario";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar listas, consulte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        void CargarGridDatos()
        {
            datos = ControladorConsulta.CargarConsulta_Controller();
            dgvListaConsultas.DataSource = datos;

            dgvListaConsultas.Columns[0].HeaderText = "Número de lista de consulta";
            dgvListaConsultas.Columns[1].HeaderText = "Paciente";
            dgvListaConsultas.Columns[2].HeaderText = "Peso";
            dgvListaConsultas.Columns[3].HeaderText = "Raza";
            dgvListaConsultas.Columns[4].HeaderText = "Propietario";
            dgvListaConsultas.Columns[5].HeaderText = "Documento del propietario";
            dgvListaConsultas.Columns[6].HeaderText = "Diagnostico";
            dgvListaConsultas.Columns[7].HeaderText = "Receta";
            dgvListaConsultas.Columns[8].HeaderText = "Tratamiento";
            dgvListaConsultas.Columns[9].HeaderText = "Fecha de la consulta";
            dgvListaConsultas.Columns[10].HeaderText = "Número de lista del paciente";

            dgvListaConsultas.Columns[10].Visible = false;
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            switch (FrmMostarConsultas.valormostrar)
            {
                case 1:
                    FrmMostarConsultas mostrar = new FrmMostarConsultas();
                    mostrar.Show();                
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region inserción de datos
        private void dgvListaPerros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = dgvListaPerros.CurrentRow.Index;
            txtIdperro.Text = dgvListaPerros[0, id].Value.ToString();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            envioDatos();            
        }
        void envioDatos()
        {
            DateTime hoy = DateTime.Today;
            string Formato = "yyyy/MM/dd";
            //Validación de campos vacíos
            if (txtDiagnostico.Text.Trim() == "" || txtIdperro.Text.Trim() == "" || txtReceta.Text.Trim() == "" || txtTratamiento.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos incompletos, por favor completar todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtConsulta.Value.AddMonths(-1) > hoy)//Fecha futuras
            {
                MessageBox.Show("La fecha que se quiere registrar no es valida, no se pueden registrar fechas un mes antes de ahora "+hoy.ToString(Formato), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtConsulta.Value.AddMonths(1) < hoy)//Pasadas
            {
                MessageBox.Show("La fecha que se quiere registrar no es valida, no se pueden registrar fechas un mes despues de ahora "+hoy.ToString(Formato) , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ControladorConsulta agregar;
                int idperro;
                string diagnostico, receta, tratamiento, fecha_consulta;
                diagnostico = txtDiagnostico.Text;
                receta = txtReceta.Text;
                tratamiento = txtTratamiento.Text;
                fecha_consulta = dtConsulta.Text;
                AtributosExpediente.Confirmarfecha = fecha_consulta;
                idperro = Convert.ToInt16(txtIdperro.Text);
                agregar = new ControladorConsulta(idperro, diagnostico, receta, tratamiento, fecha_consulta);

                bool respuesta = agregar.EnviarDatos_Controller();

                if (respuesta == true)
                {
                    CargarGridDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Consulta no agregada", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       
        #endregion
        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            CargarListas();
            CargarGridDatos();
            FrmMostarConsultas.valormostrar = 1;
            switch (FrmMain.valortraducir)
            {
                case 1:
                    toolStripLabel1.Text = InglesConsulta.tlsFrmConsulta;
                    label1.Text = InglesConsulta.lblDiagnosticoConsulta;
                    label2.Text = InglesConsulta.lblListaPeConsulta;
                    label3.Text = InglesConsulta.lblRecetaConsulta;
                    label4.Text = InglesConsulta.lblTratamientoConsulta;
                    label5.Text = InglesConsulta.lblFechaConsulta;
                    label6.Text = InglesConsulta.lblMostrarConsul;
                    label7.Text = InglesConsulta.lblAgregarConsul;
                    label8.Text = InglesConsulta.lblLimpiarConsul;
                    label9.Text = InglesConsulta.lblEliminarConsul;
                    label10.Text = InglesConsulta.lblActualizarConsul;
                    label11.Text = InglesConsulta.lblListPacienteDGV;
                    label12.Text = InglesConsulta.lblListConsulDGV;
                    label13.Text = InglesConsulta.lblBuscarConsul;
                    label14.Text = InglesConsulta.lblBuscarPacienteConsul;
                    label15.Text = InglesConsulta.lblBuscarPacienteBoton;
                    label16.Text = InglesConsulta.lblRecargarPacienteBoton;
                    label18.Text = InglesConsulta.lblRecargarConsulBoton;
                    label20.Text = InglesConsulta.lblBuscarConsulBoton;
                    groupBox3.Text = InglesConsulta.grbAccionesConsulta;
                    grpDatosConsulta.Text = InglesConsulta.grbDatosConsulta;

                    dgvListaPerros.Columns[0].HeaderText = "Number of list of pacient";
                    dgvListaPerros.Columns[1].HeaderText = "Pacient name";
                    dgvListaPerros.Columns[2].HeaderText = "Weight";
                    dgvListaPerros.Columns[3].HeaderText = "Breed";
                    dgvListaPerros.Columns[4].HeaderText = "Owner names";
                    dgvListaPerros.Columns[5].HeaderText = "Number of document of owner";

                    dgvListaConsultas.Columns[0].HeaderText = "Number of list";
                    dgvListaConsultas.Columns[1].HeaderText = "Pacient name";
                    dgvListaConsultas.Columns[2].HeaderText = "Weight";
                    dgvListaConsultas.Columns[3].HeaderText = "Breed";
                    dgvListaConsultas.Columns[4].HeaderText = "Owner names";
                    dgvListaConsultas.Columns[5].HeaderText = "Number of document of owner";
                    dgvListaConsultas.Columns[6].HeaderText = "Diagnosis";
                    dgvListaConsultas.Columns[7].HeaderText = "Recipe";
                    dgvListaConsultas.Columns[8].HeaderText = "Treatment";
                    dgvListaConsultas.Columns[9].HeaderText = "Appointment date";
                    dgvListaConsultas.Columns[10].HeaderText = "Number of list of pacient";
                    break;                    
                default:
                    break;
            }
        }
        #region Actualización de datos
        private void dgvListaConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dgvListaConsultas.CurrentRow.Index;

            txtIdconsulta.Text = dgvListaConsultas[0, a].Value.ToString();
            txtIdperro.Text = dgvListaConsultas[10, a].Value.ToString();
            txtDiagnostico.Text = dgvListaConsultas[6, a].Value.ToString();
            txtReceta.Text = dgvListaConsultas[7, a].Value.ToString();
            txtTratamiento.Text = dgvListaConsultas[8, a].Value.ToString();
            dtConsulta.Text =dgvListaConsultas[9, a].Value.ToString();

            pnlActualizar.Enabled = true;
            pnlEliminar.Enabled = true;
            pnlAgregar.Enabled = false;
        }
        void ActualizarDatos()
        {
            DateTime hoy = DateTime.Today;
            string Formato = "yyyy/MM/dd";
            if (txtDiagnostico.Text.Trim() == "" || txtIdperro.Text.Trim() == "" || txtIdconsulta.Text.Trim() == "" || txtReceta.Text.Trim() == "" || txtTratamiento.Text.Trim() == "")
            {
                MessageBox.Show("Ërror al actualizar, existen campos vacíos, porfavor llenelos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtConsulta.Value.AddMonths(-1) > hoy)//Fecha futuras
            {
                MessageBox.Show("La fecha que se quiere registrar no es valida, no se pueden registrar fechas un mes antes de ahora " + hoy.ToString(Formato), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtConsulta.Value.AddMonths(1) < hoy)//Pasadas
            {
                MessageBox.Show("La fecha que se quiere registrar no es valida, no se pueden registrar fechas un mes despues de ahora " + hoy.ToString(Formato), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ControladorConsulta.idconsulta = Convert.ToInt16(txtIdconsulta.Text);
                string diagnostico, receta, tratamiento, fecha;
                int idperro;
                diagnostico = txtDiagnostico.Text;
                receta = txtReceta.Text;
                tratamiento = txtTratamiento.Text;
                fecha = dtConsulta.Text;
                idperro = Convert.ToInt16(txtIdperro.Text);
                ControladorConsulta objActualizar = new ControladorConsulta(idperro, diagnostico, receta, tratamiento, fecha);
                bool respusta = objActualizar.ActualizarDatos_Controller();
                if (respusta == false)
                {
                    MessageBox.Show("Error al actualizar datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LimpiarCampos();
                    CargarGridDatos();
                }
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        #endregion

        #region Eliminación de datos
        void EliminarDatos()
        {
            ControladorConsulta.idconsulta = Convert.ToInt16(txtIdconsulta.Text);
            int valor = ControladorConsulta.EliminarConsulta_Controller();

            switch (valor)
            {
                case -1:
                    MessageBox.Show("Ocurrió un error al establecer conexión con la base de datos, verificar su acceso a internet o que los servicios del servidor estén activos", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    LimpiarCampos();
                    CargarGridDatos();
                    break;
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int selectel = dgvListaConsultas.CurrentRow.Index;
            DialogResult drq;
            switch (FrmMain.valortraducir)
            {
                case 1:
                    drq = MessageBox.Show("Do you want to delete this query from "+dgvListaConsultas[4,selectel].Value.ToString() +", owner of "+dgvListaConsultas[1, selectel].Value.ToString()+" ?, keep in mind that the file of this appointment will also be deleted","Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drq == DialogResult.Yes)
                    {
                        EliminarDatos();
                        pnlActualizar.Enabled = false;
                        pnlEliminar.Enabled = false;
                        pnlRecargar.Enabled = false;
                        pnlRecargar2.Enabled = false;
                        pnlAgregar.Enabled = true;
                    }
                    break;
                case 2:
                    drq = MessageBox.Show("¿Deseá eliminar está consulta de " + dgvListaConsultas[4, selectel].Value.ToString() + ", dueño de "+dgvListaConsultas[1, selectel].Value.ToString()+" ?, ten encuenta que también se eliminará el expediente de está consulta", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drq == DialogResult.Yes)
                    {
                        EliminarDatos();
                        pnlActualizar.Enabled = false;
                        pnlEliminar.Enabled = false;
                        pnlRecargar.Enabled = false;
                        pnlRecargar2.Enabled = false;
                        pnlAgregar.Enabled = true;
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion
        #endregion

        void NivelesUsuario()
        {
            switch (ControladorLogIn.tipousuario)
            {
                case 5:
                    pnlAgregar.Visible = false;
                    pnlActualizar.Visible = false;
                    pnlEliminar.Visible = false;
                    dgvListaPerros.Enabled = false;
                    grpDatosConsulta.Enabled = false;
                    pnlLimpiarCampos.Visible = false;

                    pnlMostrar.Location = new Point(0,0);                    
                    break;
                default:
                    break;
            }
        }

        private void btnBackForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscarpaciente_Click(object sender, EventArgs e)
        {
            if (txtBuscarpaciente.Text.Trim() == "")
            {

            }
            else
            {
                dgvListaPerros.DataSource = PerrosController.BuscarListageneral(txtBuscarpaciente.Text);
                pnlRecargar2.Enabled = true;
            }
        }

        private void btnRecargar2_Click(object sender, EventArgs e)
        {
            dgvListaPerros.DataSource = PerrosController.Cargarperros_controller();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "")
            {

            }
            else
            {
                dgvListaConsultas.DataSource = ControladorConsulta.BuscarConsulta_Controller(txtBuscar.Text);
                pnlRecargar.Enabled = true;
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            dgvListaConsultas.DataSource = ControladorConsulta.CargarConsulta_Controller();
        }
    }
}
