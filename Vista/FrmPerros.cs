using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Controlador;
using System.Linq;
using iTextSharp.text;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmPerros : Form
    {
        public FrmPerros()
        {
            InitializeComponent();
            cargar_listas();
            CargarGridDatos();
            pnlRecargar.Enabled = false;
            pnlRecargar2.Enabled = false;
            pnlActualizar.Enabled = false;
            pnlEliminar.Enabled = false;
        }
        public DataTable datos;
        public PerrosController objperros = new PerrosController();
        DateTime future = DateTime.Today;

        void LimpiarCampos()
        {
            txtIDperro.Clear();//Desea agregar otro perro del mismo propietario
            txtnombreperro.Clear();
            txtnumListapropietario.Clear();
            txtpeso.Clear();
            txttamano.Clear();
            cargar_listas();

            pnlAgregar.Enabled = true;
            pnlRecargar.Enabled = false;
            pnlRecargar2.Enabled = false;
            pnlActualizar.Enabled = false;
            pnlEliminar.Enabled = false;
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            switch (FrmMostrarPerros.valormostrar)
            {
                case 1:
                    FrmMostrarPerros mostrar = new FrmMostrarPerros();
                    mostrar.Show();
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
        #region CRUD Perros
        //Lectura de datos
        void llenar_raza()
        {
            try
            {
                cmbraza.DataSource = PerrosController.raza_controller();
                cmbraza.DisplayMember = "raza";
                cmbraza.ValueMember = "idraza";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la raza, consulte con el administrador",
                                "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void llenar_genero()
        {
            try
            {
                cmbgenero.DataSource = PerrosController.genero_controller();
                cmbgenero.DisplayMember = "genero";
                cmbgenero.ValueMember = "idgenero";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar , consulte con el administrador",
                                "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
        void cargar_listas()
        {
            llenar_genero();
            llenar_raza();           
        }
        void CargarGridDatos()
        {
            datos = PerrosController.Cargarperros_controller();
            dgvPerrosPropietarios.DataSource = datos;
            dgvPerrosPropietarios.Columns[0].HeaderText = "Número de lista";
            dgvPerrosPropietarios.Columns[1].HeaderText = "Paciente";
            dgvPerrosPropietarios.Columns[2].HeaderText = "Fecha de nacimiento";
            dgvPerrosPropietarios.Columns[3].HeaderText = "Peso";
            dgvPerrosPropietarios.Columns[4].HeaderText = "Tamaño";
            dgvPerrosPropietarios.Columns[5].HeaderText = "Raza";
            dgvPerrosPropietarios.Columns[6].HeaderText = "Genero";
            dgvPerrosPropietarios.Columns[7].HeaderText = "Nombre del propietario";
            dgvPerrosPropietarios.Columns[8].HeaderText = "Número de documento";
            dgvPerrosPropietarios.Columns[9].HeaderText = "Número de lista de propietario";

            dgvListapropietarios.DataSource = ControladorPropietario.CargarPropietarios();
            dgvListapropietarios.Columns[0].HeaderText = "Número de lista del propietario";//Vis = F, != root
            dgvListapropietarios.Columns[1].HeaderText = "Nombres";
            dgvListapropietarios.Columns[2].HeaderText = "Apellidos";
            dgvListapropietarios.Columns[3].HeaderText = "Fecha de nacimiento";
            dgvListapropietarios.Columns[4].HeaderText = "Tipo de documento";//Vis = F, != Root
            dgvListapropietarios.Columns[5].HeaderText = "Número de documento";
            dgvListapropietarios.Columns[6].HeaderText = "Municipio";
            dgvListapropietarios.Columns[7].HeaderText = "Departamento";
            dgvListapropietarios.Columns[8].HeaderText = "Estado del propietario";//Visible = false en todos menos root       

            dgvListapropietarios.Columns[4].Visible = false;
            dgvPerrosPropietarios.Columns[9].Visible = false;
        }

        //Inserción        
        void envioperros()
        {            
            if (dtFecha_nacimiento.Value.Date >= future || dtFecha_nacimiento.Value.Date == future)
            {
                MessageBox.Show("Verfique la edad del paciente, puse ser ingresado un dia o más despúes de su nacimiento");
            }
            else if ( txtnombreperro.Text.Trim() == "" || txtnumListapropietario.Text.Trim() == "" || txtpeso.Text.Trim() == "" || txttamano.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos vacíos, porfavor llenar la información requerida.", "Existen campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PerrosController agregar = new PerrosController();
                agregar.nombre_perro = txtnombreperro.Text;
                agregar.fecha_nacimiento = dtFecha_nacimiento.Text;
                agregar.peso = txtpeso.Text + " lbs";
                agregar.idpropietario = Convert.ToInt16(txtnumListapropietario.Text);
                agregar.idgenero = Convert.ToInt16(cmbgenero.SelectedValue);
                agregar.idraza = Convert.ToInt16(cmbraza.SelectedValue);
                agregar.tamano = txttamano.Text;
                bool respuesta = agregar.EnviarPerros_Controller();

                if (respuesta == true)
                {
                    dgvPerrosPropietarios.DataSource = PerrosController.Cargarperros_controller();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            envioperros();
        }
        private void dgvListapropietarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dgvListapropietarios.CurrentRow.Index;

            txtnumListapropietario.Text = dgvListapropietarios[0, a].Value.ToString();
        }
        //Actualización
        private void dgvPerrosPropietarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PerrosController objselect = new PerrosController();
            int posicion = dgvPerrosPropietarios.CurrentRow.Index;

            //modificar
            txtIDperro.Text = dgvPerrosPropietarios[0, posicion].Value.ToString();
            txtnombreperro.Text = dgvPerrosPropietarios[1, posicion].Value.ToString();
            dtFecha_nacimiento.Text = dgvPerrosPropietarios[2, posicion].Value.ToString();
            txtpeso.Text = dgvPerrosPropietarios[3, posicion].Value.ToString();            
            txttamano.Text = dgvPerrosPropietarios[4, posicion].Value.ToString();
            string raza = dgvPerrosPropietarios[5, posicion].Value.ToString();
            string genero = dgvPerrosPropietarios[6, posicion].Value.ToString();

            txtnumListapropietario.Text = dgvPerrosPropietarios[9, posicion].Value.ToString();

            cmbgenero.DataSource = PerrosController.generoInnerJoin(genero);
            cmbgenero.DisplayMember = "genero";
            cmbgenero.ValueMember = "idgenero";

            cmbraza.DataSource = PerrosController.razaInnerJoin(raza);
            cmbraza.DisplayMember = "raza";
            cmbraza.ValueMember = "idraza";

            if (txtpeso.Text != "")
            {
                lblSistema.Visible = false;
            }
            else
            {
                lblSistema.Visible = true;
            }

            pnlEliminar.Enabled = true;
            pnlActualizar.Enabled = true;
            pnlAgregar.Enabled = false;
        }
        void ActualizarDatos()
        {
            objperros.idperro = Convert.ToInt16(txtIDperro.Text);
            objperros.nombre_perro = txtnombreperro.Text;
            objperros.fecha_nacimiento = dtFecha_nacimiento.Text;            
            objperros.peso = txtpeso.Text;                        
            objperros.tamano = txttamano.Text;
            objperros.idraza = Convert.ToInt16(cmbraza.SelectedValue);
            objperros.idgenero = Convert.ToInt16(cmbgenero.SelectedValue);
            objperros.idpropietario = Convert.ToInt16(txtnumListapropietario.Text);
            bool respuesta = objperros.Actualizarperros();
            if (respuesta == true)
            {
                CargarGridDatos();
                LimpiarCampos();
                cargar_listas();
            }
            else
            { 
                MessageBox.Show("Error al actualizar datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                     
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }
        private void cmbraza_Click(object sender, EventArgs e)
        {
            cargar_listas();
        }
        private void cmbgenero_Click(object sender, EventArgs e)
        {
            cargar_listas();
        }
        
        //Eliminación
        void Elimiarperro()
        {
            switch (FrmMain.valortraducir)
            {
                case 1:
                    if (MessageBox.Show("Do you want to eliminate the patient: " + txtnombreperro.Text + " ?", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int idperro = Convert.ToInt16(txtIDperro.Text);                
                        bool respuesta = objperros.Eliminarperro(idperro);
                        if (respuesta == true)
                        {
                            CargarGridDatos();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Error to delete the patient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 2:
                    if (MessageBox.Show("¿Quieres eliminar al paciente: " + txtnombreperro.Text + " ?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int idperro = Convert.ToInt16(txtIDperro.Text);                
                        bool respuesta = objperros.Eliminarperro(idperro);
                        if (respuesta == true)
                        {
                            CargarGridDatos();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar al paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {            
            Elimiarperro();
        }

        #endregion

        private void btnBackForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "")
            {

            }
            else
            {
                dgvPerrosPropietarios.DataSource = PerrosController.BuscarListageneral(txtBuscar.Text);
                pnlRecargar.Enabled = true;
            }
        }

        private void btnBuscarempleado_Click(object sender, EventArgs e)
        {
            if (txtBuscarpropietarios.Text.Trim() == "")
            {

            }
            else
            {
                dgvListapropietarios.DataSource = ControladorPropietario.CargarBusqueda(txtBuscarpropietarios.Text);
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            dgvPerrosPropietarios.DataSource = PerrosController.Cargarperros_controller();
        }

        private void btnRecargar2_Click(object sender, EventArgs e)
        {
            dgvListapropietarios.DataSource = ControladorPropietario.CargarPropietarios();
        }
        private void txtNombre_Tamano_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
            if (txtnombreperro.Text.Contains(' ') && e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtPesoKeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloDecimales(e);
            if (txtpeso.Text.Contains('.') && e.KeyChar == '.')
            {
                e.Handled = false;
            }
        }

        private void txtIDPropietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        void Traducir()
        {
            switch (FrmMain.valortraducir)
            {
                case 1:
                    tlsFrm.Text = InglesPerros.tslFormPerros;
                    groupBox3.Text = InglesPerros.grpAccionesPerros;
                    lblAgregar.Text = InglesPerros.lblAgregarPerros;
                    lblMostrar.Text = InglesPerros.lblMostrarPerros;
                    lblActualizar.Text = InglesPerros.lblActualizarPerros;
                    lblEliminar.Text = InglesPerros.lblEliminarPerros;
                    lblLimpiar.Text = InglesPerros.lblLimpiarPerros;
                    lblDescripBuscar1.Text = InglesPerros.lblBuscarPerros;
                    lblBuscar1.Text = InglesPerros.lblBuscarPerrosBoton;
                    lblRecargar1.Text = InglesPerros.lblRecargarPerrosBoton;
                    groupBox1.Text = InglesPerros.grpDatosPerros;
                    lblNombre.Text = InglesPerros.lblNombresPerros;
                    lblTamano.Text = InglesPerros.lblTamañoPerros;
                    lblNacimiento.Text = InglesPerros.lblnacimientoPerros;
                    lblRaza.Text = InglesPerros.lblRazaPerros;
                    lblPeso.Text = InglesPerros.lblPesoPerros;
                    lblGenero.Text = InglesPerros.lblGeneroPerros;
                    lblNumLista.Text = InglesPerros.lblNumListaPerros;
                    lblDescripBuscar2.Text = InglesPerros.lblBuscarPropiePerros;
                    lblBuscar2.Text = InglesPerros.lblBuscarPerrosBoton;
                    lblRecargar2.Text = InglesPerros.btnRecargar;
                    lbldgvPropietarios.Text = InglesPerros.lblListPropieDGV;
                    lbldgvPacientes.Text = InglesPerros.lblListPerrosDGV;

                    dgvPerrosPropietarios.Columns[0].HeaderText = "Number of list";
                    dgvPerrosPropietarios.Columns[1].HeaderText = "Pacient name";
                    dgvPerrosPropietarios.Columns[2].HeaderText = "Date of birth";
                    dgvPerrosPropietarios.Columns[3].HeaderText = "Weight";
                    dgvPerrosPropietarios.Columns[4].HeaderText = "Size";
                    dgvPerrosPropietarios.Columns[5].HeaderText = "Breed";
                    dgvPerrosPropietarios.Columns[6].HeaderText = "Gender";
                    dgvPerrosPropietarios.Columns[7].HeaderText = "Names of owner";
                    dgvPerrosPropietarios.Columns[8].HeaderText = "Number of document";
                    dgvPerrosPropietarios.Columns[9].HeaderText = "Number of list of owner";

                    dgvListapropietarios.Columns[0].HeaderText = "Number of list of owner";//Vis = F, != root
                    dgvListapropietarios.Columns[1].HeaderText = "Names";
                    dgvListapropietarios.Columns[2].HeaderText = "Last names";
                    dgvListapropietarios.Columns[3].HeaderText = "Date of birth";
                    dgvListapropietarios.Columns[4].HeaderText = "Type of document";//Vis = F, != Root
                    dgvListapropietarios.Columns[5].HeaderText = "Number of document";
                    dgvListapropietarios.Columns[6].HeaderText = "Municipality";
                    dgvListapropietarios.Columns[7].HeaderText = "Departament";
                    dgvListapropietarios.Columns[8].HeaderText = "State of owner";//Visible = false en todos menos root       
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
        private void FrmPerros_Load(object sender, EventArgs e)
        {
            Traducir();
            FrmMostrarPerros.valormostrar = 1;
        }
    }
}
