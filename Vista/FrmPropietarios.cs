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
    public partial class FrmPropietarios : Form
    {
        public FrmPropietarios()
        {
            InitializeComponent();
            cargarListas();
            Niveles();
            pnlActualizar.Enabled = false;
            pnlEliminar.Enabled = false;
            pnlRecargar.Enabled = false;
            pnlActualizarTelefono.Enabled = false;            
        }
        void Niveles()
        {
            switch (ControladorLogIn.tipousuario)
            {
                case 3:
                    dgvPropietarios.Columns[0].Visible = false;
                    dgvPropietarios.Columns[4].Visible = false;
                    dgvPropietarios.Columns[8].Visible = false;
                    dgvPropietarios.Size = new Size(643, 215);
                    //dgvPropietarios.Location = new Point(156, 262);
                    dgvContacto_Propietario.Location = new Point(593, 285);
                    dgvContacto_Propietario.Size = new Size(445, 124);

                    dgvContacto_Propietario.Columns[0].Visible = false;
                    dgvContacto_Propietario.Columns[5].Visible = false;
                    break;
                case 4:
                    dgvPropietarios.Columns[0].Visible = false;
                    dgvPropietarios.Columns[4].Visible = false;
                    dgvPropietarios.Columns[8].Visible = false;
                    dgvContacto_Propietario.Columns[0].Visible = false;
                    dgvContacto_Propietario.Columns[5].Visible = false;
                    dgvPropietarios.Size = new Size(643, 215);
                    dgvContacto_Propietario.Location = new Point(593, 285);
                    dgvContacto_Propietario.Size = new Size(445, 124);

                    //dgvPropietarios.Location = new Point(156, 262);

                    break;
                default:
                    break;
            }
        }
        //Limpiar campos

        void LimpiarCampos()
        {
            txtIDpropietario.Clear();
            txtNombrePropietario.Clear();
            txtApellidosPropietario.Clear();
            txtNumDocumento.Clear();
            txtNumTelefono.Clear();
            cargarListas();

            pnlActualizar.Enabled = false;
            pnlEliminar.Enabled = false;
            pnlRecargar.Enabled = false;
            pnlActualizarTelefono.Enabled = false;
            pnlAgregar.Enabled = true;
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        ControladorPropietario a = new ControladorPropietario();
        
        #region CRUD de Propietario       
       
        //Mostrar
        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            switch (FrmMostrarPropietarios.valormostrar)
            {
                case 1:
                    FrmMostrarPropietarios show = new FrmMostrarPropietarios();
                    show.Show();
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
                
        #region Lectura de datos
        void cargarListas()
        {
            cargarTipoDocumento();
            cargarDepartamento();
            cargarEstado();
            CargarMunicipios();
            cargarPropietarios();
            CargarContacto_propietario();
        }
        void cargarTipoDocumento()
        {
            try
            {
                cmbTipoDocumento.DataSource = ControladorPropietario.CargarTipoDoc();
                cmbTipoDocumento.DisplayMember = "tipodoc";
                cmbTipoDocumento.ValueMember = "idtipodocumento";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipo de documentos", "Error de cargar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void CargarMunicipios()
        {
            try
            {
                cmbMunicipio.DataSource = ControladorPropietario.CargarMunicipios();
                cmbMunicipio.DisplayMember = "municipio";
                cmbMunicipio.ValueMember = "idmunicipio";
            }
            catch (Exception)
            {

                throw;
            }
        }
        void cargarEstado()
        {
            try
            {
                cmbEstado.DataSource = ControladorPropietario.cargarEstado();
                cmbEstado.DisplayMember = "estado_propietario";
                cmbEstado.ValueMember = "idestado_propietario";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los estados", "Error de cargar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        void cargarDepartamento()
        {
            try
            {
                cmbDepartamento.DataSource = ControladorPropietario.cargarDepartamento();
                cmbDepartamento.ValueMember = "iddepartamento";
                cmbDepartamento.DisplayMember = "departamento";

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los departamentos", "Error de cargar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void CargarMunicipioSelect()//Evento select index change
        {
            try
            {
                int iddepartamento = Convert.ToInt16(cmbDepartamento.SelectedValue);

                cmbMunicipio.DataSource = ControladorPropietario.CargarMunicipioSelect(iddepartamento);
                cmbMunicipio.DisplayMember = "municipio";
                cmbMunicipio.ValueMember = "idmunicipio";
            }
            catch (Exception)
            {

            }
            
        }
        void cargarPropietarios()//Añadir en una inner join  a numero de telefono
        {
            dgvPropietarios.DataSource = ControladorPropietario.CargarPropietarios();

            dgvPropietarios.Columns[0].HeaderText = "Número de lista";//Vis = F, != root
            dgvPropietarios.Columns[1].HeaderText = "Nombres";
            dgvPropietarios.Columns[2].HeaderText = "Apellidos";
            dgvPropietarios.Columns[3].HeaderText = "Fecha de nacimiento";
            dgvPropietarios.Columns[4].HeaderText = "Tipo de documento";//Vis = F, != Root
            dgvPropietarios.Columns[5].HeaderText = "Número de documento";
            dgvPropietarios.Columns[6].HeaderText = "Municipio";
            dgvPropietarios.Columns[7].HeaderText = "Departamento";
            dgvPropietarios.Columns[8].HeaderText = "Estado";//Visible = false en todos menos root            
        }
        void CargarContacto_propietario()
        {
            dgvContacto_Propietario.DataSource = ControladorPropietario.CargarContacto_Propietario();
            dgvContacto_Propietario.Columns[0].HeaderText = "Número de lista de contacto";//Vis = F, != Root
            dgvContacto_Propietario.Columns[1].HeaderText = "Nombres";
            dgvContacto_Propietario.Columns[2].HeaderText = "Apellidos";
            dgvContacto_Propietario.Columns[3].HeaderText = "Número de contacto";
            dgvContacto_Propietario.Columns[4].HeaderText = "Número de documento";
            dgvContacto_Propietario.Columns[5].HeaderText = "Número de lista del propietario";//Vis = F, !=root
        }
        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMunicipioSelect();
        }

        #endregion
        
        //Inserción
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPropietario();
        }
        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            AgregarNumero();
        }
        void AgregarPropietario()
        {
            DateTime hoy = DateTime.Today;

            if (txtNombrePropietario.Text.Trim() == "" || txtApellidosPropietario.Text.Trim() == "" || txtNumDocumento.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos vacíos, porfavor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtNacimiento.Value.Date >= hoy|| dtNacimiento.Value.AddYears(25) > hoy)
            {
                MessageBox.Show("Verifique su edad, recuerde que la edad mínima para registrar es 25 años", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a.nombre_propietario = txtNombrePropietario.Text;
                a.apellido_propietario = txtApellidosPropietario.Text;
                a.fecha_nacimiento = dtNacimiento.Text;
                a.idtipodocumento = Convert.ToInt16(cmbTipoDocumento.SelectedValue);
                a.num_documento = txtNumDocumento.Text;
                a.idmunicipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                a.idestado = Convert.ToInt16(cmbEstado.SelectedValue);
                int resultado = a.AgregarPropietario();
                if (resultado >= 1)
                {
                    cargarPropietarios();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al ingresar datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        void AgregarNumero()
        {
            if (txtNumTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos vacíos, porfavor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a.idpropietario = Convert.ToInt16(txtIDpropietario.Text);
                a.num_telefono = txtNumTelefono.Text;
                bool respuestas = a.AgregarNumTelefono();
                if (respuestas == true )
                {
                    cargarPropietarios();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar número de télefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void dgvPropietarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int finalp = dgvPropietarios.CurrentRow.Index;

            txtIDpropietario.Text = dgvPropietarios[0, finalp].Value.ToString();
            txtNombrePropietario.Text = dgvPropietarios[1, finalp].Value.ToString();
            txtApellidosPropietario.Text = dgvPropietarios[2, finalp].Value.ToString();
            dtNacimiento.Text = dgvPropietarios[3, finalp].Value.ToString();
            string tipodoc = dgvPropietarios[4, finalp].Value.ToString();
            txtNumDocumento.Text = dgvPropietarios[5, finalp].Value.ToString();
            string municipio = dgvPropietarios[6, finalp].Value.ToString();
            string idestado = dgvPropietarios[8, finalp].Value.ToString();//hay solo 7 posiciones
            string departamento = dgvPropietarios[7, finalp].Value.ToString();
            txtIDcontacto.Clear();

            cmbTipoDocumento.DataSource = ControladorPropietario.cargarTipoDocUPDATE(tipodoc);
            cmbTipoDocumento.DisplayMember = "tipodoc";
            cmbTipoDocumento.ValueMember = "idtipodocumento";

            cmbDepartamento.DataSource = ControladorPropietario.cargarDepartamentoUPDATE(departamento);
            cmbDepartamento.DisplayMember = "departamento";
            cmbDepartamento.ValueMember = "iddepartamento";

            cmbEstado.DataSource = ControladorPropietario.cargarEstadoUPDATE(idestado);
            cmbEstado.DisplayMember = "estado_propietario";
            cmbEstado.ValueMember = "idestado_propietario";           

            cmbMunicipio.DataSource = ControladorPropietario.cargarMunicipioUPDATE(municipio);
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "idmunicipio";

            pnlAgregar.Enabled = false;
            pnlEliminar.Enabled = true;
            pnlActualizar.Enabled = true;
         
        }
        private void dgvContacto_Propietario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dgvContacto_Propietario.CurrentRow.Index;
            
            txtIDcontacto.Text = dgvContacto_Propietario[0, a].Value.ToString();
            txtNumTelefono.Text = dgvContacto_Propietario[4, a].Value.ToString();
            txtIDpropietario.Text = dgvContacto_Propietario[5, a].Value.ToString();

            pnlActualizarTelefono.Enabled = true;
        }

        //Actualización
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            ActualizarPropietario();
        }
        private void btnActualizarContacto_Click(object sender, EventArgs e)
        {
            ActualizarContacto_propietario();
            CargarContacto_propietario();
        }
        private void cmbTipoDocumento_Click(object sender, EventArgs e)
        {
            cargarTipoDocumento();
        }
        private void cmbEstado_Click(object sender, EventArgs e)
        {
            cargarEstado();
        }
        private void cmbMunicipio_Click(object sender, EventArgs e)
        {           
            CargarMunicipioSelect();
        }
        private void cmbDepartamento_Click(object sender, EventArgs e)
        {
            cargarDepartamento();
        }
        void ActualizarPropietario()
        {
            DateTime hoy = DateTime.Today;

            if (txtNombrePropietario.Text.Trim() == "" || txtApellidosPropietario.Text.Trim() == "" || txtNumDocumento.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos vacíos, porfavor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtNacimiento.Value.Date >= hoy || dtNacimiento.Value.AddYears(25) > hoy)
            {
                MessageBox.Show("Verifique su edad, recuerde que la edad mínima para registrar es 25 años", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a.idpropietario = Convert.ToInt16(txtIDpropietario.Text);
                a.nombre_propietario = txtNombrePropietario.Text;
                a.apellido_propietario = txtApellidosPropietario.Text;
                a.fecha_nacimiento = dtNacimiento.Text;
                a.idtipodocumento = Convert.ToInt16(cmbTipoDocumento.SelectedValue);
                a.num_documento = txtNumDocumento.Text;
                a.idmunicipio = Convert.ToInt16(cmbMunicipio.SelectedValue);                
                a.idestado = Convert.ToInt16(cmbEstado.SelectedValue);
                int valorRespuesta = a.ActualizarPropietario();
                if (valorRespuesta == 2)
                {
                    cargarPropietarios();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualiar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                }
            }
        }
        void ActualizarContacto_propietario()
        {
            if (txtNumTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Si desea actualizar el número de télefono, recuerde que tiene que seleccionar la fila de donde están sus datos de contacto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a.idnum_telefono = Convert.ToInt16(txtIDcontacto.Text);
                a.num_telefono = txtNumTelefono.Text;
                bool resultado = a.ActualizaContacto_propietario();
                if (resultado ==  true)
                {
                    CargarContacto_propietario();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualiar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                }
            }
        }
        
        //Eliminación
        void EliminarPropietario()
        {
            a.idpropietario = Convert.ToInt16(txtIDpropietario.Text);
            bool retorno = a.EliminarPropietario();
            if (retorno == true)
            {
                cargarPropietarios();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al eliminar datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult drq;
            switch (FrmMain.valortraducir)
            {
                case 1:
                    drq = MessageBox.Show("Do you want eliminate owner " + txtNombrePropietario.Text + " " + txtApellidosPropietario.Text + ", You find that if you delete this owner, the patients that this owner has will be deleted", "Confirm action",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drq == DialogResult.Yes)
                    {
                        EliminarPropietario();
                        pnlActualizar.Enabled = false;
                        pnlEliminar.Enabled = false;
                        pnlRecargar.Enabled = false;
                        pnlActualizarTelefono.Enabled = false;
                        pnlActualizar.Enabled = true;            
                    }
                    break;
                case 2:
                    drq = MessageBox.Show("Deseá eliminar al propietario " + txtNombrePropietario.Text + " " + txtApellidosPropietario.Text + ", te encuenta que si eliminas a este propietario, se eliminarán los pacientes que tiene este propietario", "Confirmar acción",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drq == DialogResult.Yes)
                    {
                        EliminarPropietario();
                        pnlActualizar.Enabled = false;
                        pnlEliminar.Enabled = false;
                        pnlRecargar.Enabled = false;
                        pnlActualizarTelefono.Enabled = false;
                        pnlActualizar.Enabled = true;            
                    }

                    break;
                default:
                    break;
            }
        } 
        #endregion
        private void chkContactos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContactos.Checked == true)
            {
                grpContacto.Enabled = true;
            }
            else
            {
                grpContacto.Enabled = false;
            }
        }

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
                dgvPropietarios.DataSource = ControladorPropietario.CargarBusqueda(txtBuscar.Text);
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            dgvPropietarios.DataSource = ControladorPropietario.CargarPropietarios();
        }

        private void txtNumTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            if (txtNumTelefono.Text.Contains('-') && e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }

        private void txtNumDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validaciones.SoloNumeros(e);
            //if (e.KeyChar == '-' || char.IsNumber(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (txtNumDocumento.Text.Contains('-') && e.KeyChar == '-')
            //{
            //    e.Handled = true;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
            int valorbloq, valordoc;
            valordoc = Convert.ToInt16(cmbTipoDocumento.SelectedValue);
            switch (valordoc)
            {
                case 1:
                    if (e.KeyChar == '-' && txtNumDocumento.Text.Contains('-'))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                    break;
                case 2:
                    if (e.KeyChar == '-')
                    {
                        if (e.KeyChar == '-' && txtNumDocumento.Text.Contains('-'))
                        {
                            valorbloq = 2;//Si ingresa aquí es porque ya existen 2
                            if (e.KeyChar == '-' && txtNumDocumento.Text.Contains("--"))
                            {
                                if (valorbloq == 2 && e.KeyChar == '-' && txtNumDocumento.Text.Contains('-'))
                                {
                                    valorbloq = 3;
                                    while (valorbloq > 3)
                                    {
                                        e.Handled = false;
                                    }
                                    e.Handled = true;
                                }
                            }
                            //e.Handled = false;
                        }
                    }
                    break;
                case 3:
                    break;
                default:
                    break;
            }            
        }
        void Traducir()
        {
            switch (FrmMain.valortraducir)
            {
                case 1:
                    tlsFrmName.Text = InglesPropietarios.tlsFrm;
                    grpDatosPropietario.Text = InglesPropietarios.grpDatos;
                    grpContacto.Text = InglesPropietarios.grpContacto;
                    groupBox3.Text = InglesEmpleados.grpAccionesEmp;
                    lblNombres.Text = InglesPropietarios.lblNombres;
                    lblApellidos.Text = InglesPropietarios.lblApellidos;
                    lblnacimiento.Text = InglesPropietarios.lblFechaNacimiento;
                    lblTipoDocumento.Text = InglesPropietarios.lblTipoDocumento;
                    lblNumDoc.Text = InglesPropietarios.lblNumDocumento;
                    lblEstado.Text = InglesPropietarios.lblEstado;
                    lblDepartamento.Text = InglesPropietarios.lblDepartamento;
                    lblMunicipio.Text = InglesPropietarios.lblMunicipio;
                    chkContactos.Text = InglesPropietarios.chkContacto;
                    lblNumContacto.Text = InglesPropietarios.lblContacto;
                    lblAgregarContacto.Text = InglesPropietarios.lblAgregarcontacto;
                    lblActualizarContacto.Text = InglesPropietarios.lblActualizarcontacto;
                    lblAgregar.Text = InglesPropietarios.lblAgregar;
                    lblMostrar.Text = InglesPropietarios.lblMostrar;
                    lblActualizar.Text = InglesPropietarios.lblActualizar;
                    lblEliminar.Text = InglesPropietarios.lblEliminar;
                    lblLimpiar.Text = InglesPropietarios.lblLimpiar;
                    lblBuscar1.Text = InglesPropietarios.Buscar;
                    lblRecargar1.Text = InglesPropietarios.Recargar;
                    lblDescripBuscar1.Text = InglesPropietarios.lbldescripbuscar;
                    lblListaContacto.Text = InglesPropietarios.lbldgvContacto;
                    label7.Text = InglesPropietarios.lbldgvPropietarios;

                    lblDescripBuscar1.Location = new Point(4, 409);

                    dgvPropietarios.Columns[0].HeaderText = "Number of list";//Vis = F, != root
                    dgvPropietarios.Columns[1].HeaderText = "Names";
                    dgvPropietarios.Columns[2].HeaderText = "Last names";
                    dgvPropietarios.Columns[3].HeaderText = "Date of birth";
                    dgvPropietarios.Columns[4].HeaderText = "Type of document";//Vis = F, != Root
                    dgvPropietarios.Columns[5].HeaderText = "Number of document";
                    dgvPropietarios.Columns[6].HeaderText = "Municipality";
                    dgvPropietarios.Columns[7].HeaderText = "Departament";
                    dgvPropietarios.Columns[8].HeaderText = "State";//Visible = false en todos menos root            

                    dgvContacto_Propietario.Columns[0].HeaderText = "Number of list of contact";//Vis = F, != Root
                    dgvContacto_Propietario.Columns[1].HeaderText = "Names";
                    dgvContacto_Propietario.Columns[2].HeaderText = "Last names";
                    dgvContacto_Propietario.Columns[3].HeaderText = "Number of contact";
                    dgvContacto_Propietario.Columns[4].HeaderText = "Number of document";
                    dgvContacto_Propietario.Columns[5].HeaderText = "Number of list of owner";//Vis = F, !=root
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
        private void FrmPropietarios_Load(object sender, EventArgs e)
        {
            Traducir();
            FrmMostrarPropietarios.valormostrar = 1;
        }
    }
}
