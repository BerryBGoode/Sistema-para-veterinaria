using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Controlador;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
            LlenarListas();
            //Nivel();
            //Vadar botones
            pnlAgregar.Enabled = true;
            pnlActualizar.Enabled = false;
            btnActualizar.Cursor = Cursors.No;
            pnlEliminar.Enabled = false;
            btnEliminar.Cursor = Cursors.No;
        }

        #region Datos generales necesarios para inserción y actualización
        public DataTable datos;
        public DataTable datosContacto;
        string nombres_emp, apellidos_emp, fecha_nacimiento, num_doc;
        int idtipodocumento, idmunicipio, idcargo;
        ControladorEmpleado agregar;
        ControladorEmpleado.ControladorContacto agregarContacto;
        DateTime today = DateTime.Today;
        #endregion

        #region Limpiar datos
        void Limpiarcampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtNumDoc.Clear();
            txtidempleados.Clear();
            txtTelefono.Clear();
            dtFechaNacimiento.ResetText();
            LlenarListas();

            pnlAgregar.Enabled = true;
            pnlActualizar.Enabled = false;
            btnActualizar.Cursor = Cursors.No;
            pnlEliminar.Enabled = false;
            btnEliminar.Cursor = Cursors.No;

        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            Limpiarcampos();
        }
        #endregion

        void Nivel()
        {
            switch (ControladorLogIn.tipousuario)
            {
                case 1:
                    break;
                case 2:
                    dgvEmpleados.Columns[0].Visible = false;
                    dgvTelefono.Columns[5].Visible = false;
                    dgvTelefono.Columns[0].Visible = false;
                    break;
                default:
                    break;
            }
        }

        #region Lectura de datos
        void LlenarMunicipios()
        {
            try
            {
                int departamento = Convert.ToInt16(cmbDepartamento.SelectedValue);
                cmbMunicipio.DataSource = ControladorEmpleado.CargarMunicipio_Controlador(departamento);
                cmbMunicipio.ValueMember = "idmunicipio";
                cmbMunicipio.DisplayMember = "municipio";
            }
            catch (Exception)
            {
            }
        }
        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarMunicipios();
        }
        void LlenarTipoDocumento()
        {
            try
            {
                cmbTipoDoc.DataSource = ControladorEmpleado.CargarTipoDocumentos_Controlador();
                cmbTipoDoc.ValueMember = "idtipodocumento";
                cmbTipoDoc.DisplayMember = "tipodoc";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos de documentos, verifique su conexión a internet.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LlenarCargo()
        {
            try
            {
                cmbCargo.DataSource = ControladorEmpleado.CargarCargo();
                cmbCargo.ValueMember = "idcargo";
                cmbCargo.DisplayMember = "cargo";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos de documentos, verifique su conexión a internet.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LlenarDepartamentos()
        {
            try
            {
                cmbDepartamento.DataSource = ControladorEmpleado.CargarDepartamento_Controlador();
                cmbDepartamento.ValueMember = "iddepartamento";
                cmbDepartamento.DisplayMember = "departamento";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos de documentos, verifique su conexión a internet.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CargarGridEmpleados()
        {
            datos = ControladorEmpleado.CargarEmpleados_Controlador();
            dgvEmpleados.DataSource = datos;
            dgvEmpleados.Columns[0].HeaderText = "Número de lista";
            dgvEmpleados.Columns[1].HeaderText = "Nombres";
            dgvEmpleados.Columns[2].HeaderText = "Apellidos";
            dgvEmpleados.Columns[3].HeaderText = "Fecha de nacimiento";
            dgvEmpleados.Columns[4].HeaderText = "Tipo de documento";
            dgvEmpleados.Columns[5].HeaderText = "Número de documento";
            dgvEmpleados.Columns[6].HeaderText = "Municipio";
            dgvEmpleados.Columns[7].HeaderText = "Departamento";
            dgvEmpleados.Columns[8].HeaderText = "Cargo";
        }
        void CargarGridNumTelefono()
        {
            datosContacto = ControladorEmpleado.CargarNumTelefono_Controlador();
            dgvTelefono.DataSource = datosContacto;

            dgvTelefono.Columns[0].HeaderText = "Número de lista";
            dgvTelefono.Columns[1].HeaderText = "Nombres";
            dgvTelefono.Columns[2].HeaderText = "Apellidos";
            dgvTelefono.Columns[3].HeaderText = "Número de contacto";
            dgvTelefono.Columns[4].HeaderText = "Número de documento";
            dgvTelefono.Columns[5].HeaderText = "Número de lista de empleado";
        }
        void LlenarListas()
        {
            LlenarDepartamentos();
            LlenarMunicipios();
            CargarGridNumTelefono();
            CargarGridEmpleados();
            LlenarTipoDocumento();
            LlenarCargo();
        }
        //Mostrar
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            switch (FrmMostrarEmpleados.valormostrar)
            {
                case 1:
                    FrmMostrarEmpleados show = new FrmMostrarEmpleados();
                    show.Show();
                    break;
                case 2:
                    break;
                default:
                    break;
            }

        }

        #endregion

        #region Inserción de datos empleados
        void EnvioDatos()
        {           
            if (txtNombres.Text.Trim() == "" || txtApellidos.Text.Trim() == "" || txtNumDoc.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos incompletos, por favor completar todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtFechaNacimiento.Value.Date >= today || dtFechaNacimiento.Value.AddYears(18) > today)
            {
                MessageBox.Show("Verifique su edad, recuerde que la edad mínima para registrar es 18 años", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombres_emp = txtNombres.Text;
                apellidos_emp = txtApellidos.Text;
                fecha_nacimiento = dtFechaNacimiento.Text;
                num_doc = txtNumDoc.Text;
                idtipodocumento = Convert.ToInt16(cmbTipoDoc.SelectedValue);
                idmunicipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                idcargo = Convert.ToInt16(cmbCargo.SelectedValue);
                agregar = new ControladorEmpleado(nombres_emp, apellidos_emp, fecha_nacimiento, idtipodocumento, num_doc, idmunicipio, idcargo);
                bool respuesta = agregar.EnviarDatos();
                if (respuesta == true)
                {
                    CargarGridEmpleados();
                    Limpiarcampos();
                }
                else
                {
                    MessageBox.Show("Empleado no ha sido registrado", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            EnvioDatos();
        }
        #endregion

        #region Actualización
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dgvEmpleados.CurrentRow.Index;
            txtidempleados.Text = dgvEmpleados[0, posicion].Value.ToString();
            txtNombres.Text = dgvEmpleados[1, posicion].Value.ToString();
            txtApellidos.Text = dgvEmpleados[2, posicion].Value.ToString();
            dtFechaNacimiento.Text = dgvEmpleados[3, posicion].Value.ToString();
            string tipoDoc = dgvEmpleados[4, posicion].Value.ToString();
            txtNumDoc.Text = dgvEmpleados[5, posicion].Value.ToString();
            string Municipio = dgvEmpleados[6, posicion].Value.ToString();
            string Departamento = dgvEmpleados[7, posicion].Value.ToString();
            string Cargo = dgvEmpleados[8, posicion].Value.ToString();

            cmbTipoDoc.DataSource = ControladorEmpleado.CargarTipodocinnerjoin(tipoDoc);
            cmbTipoDoc.ValueMember = "idtipodocumento";
            cmbTipoDoc.DisplayMember = "tipodoc";

            cmbDepartamento.DataSource = ControladorEmpleado.CargarDepartamentoInnerJoin(Departamento);
            cmbDepartamento.ValueMember = "iddepartamento";
            cmbDepartamento.DisplayMember = "departamento";

            cmbCargo.DataSource = ControladorEmpleado.CargarCargoInnerJoin(Cargo);
            cmbCargo.ValueMember = "idcargo";
            cmbCargo.DisplayMember = "cargo";

            cmbMunicipio.DataSource = ControladorEmpleado.CargarMunicipioInnerJoin(Municipio);
            cmbMunicipio.ValueMember = "idmunicipio";
            cmbMunicipio.DisplayMember = "municipio";

            pnlActualizar.Enabled = true;
            pnlAgregar.Enabled = false;
            pnlEliminar.Enabled = true;
            //6/10/21 para no autocambiarse algunos datos
            if (txtNombres.Text == AtributosCredenciales.nombre && txtApellidos.Text == AtributosCredenciales.Apellidos && txtidempleados.Text == AtributosCredenciales.ID.ToString())
            {
                cmbCargo.Enabled = false;
            }
            else
            {
                cmbCargo.Enabled = true;
            }
            btnActualizar.Cursor = Cursors.Hand;
            btnEliminar.Cursor = Cursors.Hand;
        }
        void ActualizarEmpleados()
        {
            if (txtNombres.Text.Trim() == "" || txtApellidos.Text.Trim() == "" || txtNumDoc.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos incompletos, por favor completar todos los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtFechaNacimiento.Value.Date >= today || dtFechaNacimiento.Value.AddYears(18) > today)
            {
                MessageBox.Show("Verifique su edad, recuerde que la edad mínima para registrar es 18 años", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {            
                ControladorEmpleado.idempleado = Convert.ToInt16(txtidempleados.Text);
                nombres_emp = txtNombres.Text;
                apellidos_emp = txtApellidos.Text;
                fecha_nacimiento = dtFechaNacimiento.Text;
                idtipodocumento = Convert.ToInt16(cmbTipoDoc.SelectedValue);
                num_doc = txtNumDoc.Text;
                idmunicipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                idcargo = Convert.ToInt16(cmbCargo.SelectedValue);
                agregar = new ControladorEmpleado(nombres_emp, apellidos_emp, fecha_nacimiento, idtipodocumento, num_doc, idmunicipio, idcargo);
                bool respuesta = agregar.ActualizarDatos_Controlador();
                if (respuesta == true)
                {
                    CargarGridEmpleados();
                    Limpiarcampos();
                    pnlAgregar.Enabled = true;
                    pnlActualizar.Enabled = false;
                    btnActualizar.Cursor = Cursors.No;
                    pnlEliminar.Enabled = false;
                    btnEliminar.Cursor = Cursors.No;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el empleado", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            ActualizarEmpleados();
        }
        private void cmbTipoDoc_Click(object sender, EventArgs e)
        {
            LlenarTipoDocumento();
        }
        private void cmbCargo_Click(object sender, EventArgs e)
        {
            LlenarCargo();
        }
        private void cmbDepartamento_Click(object sender, EventArgs e)
        {
            LlenarDepartamentos();
        }
        private void cmbMunicipio_Click(object sender, EventArgs e)
        {
            LlenarMunicipios();
        }
        #endregion

        #region Eliminación de datos empleados
        void EliminarDatos()
        {
            if (Convert.ToInt16(txtidempleados.Text) == AtributosCredenciales.ID || txtNombres.Text == AtributosCredenciales.nombre || txtApellidos.Text == AtributosCredenciales.Apellidos)
            {
                switch (FrmMain.valortraducir)
                {
                    case 1:
                        MessageBox.Show("You can't delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        MessageBox.Show("No te puedes eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                ControladorEmpleado.idempleado = Convert.ToInt16(txtidempleados.Text);
                int valor = ControladorEmpleado.EliminarEmpleado_Controlador();
                switch (valor)
                {
                    case -1:
                        MessageBox.Show("Ocurrió un error al establecer conexión con la base de datos, verificar su acceso a internet o que los servicios del servidor estén activos", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1:
                        Limpiarcampos();
                        CargarGridEmpleados();
                        pnlAgregar.Enabled = true;
                        pnlActualizar.Enabled = false;
                        pnlEliminar.Enabled = false;
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }

            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult a;
            switch (FrmMain.valortraducir)
            {
                case 1:
                    a = MessageBox.Show("Dou you want to eliminate the employee "+txtNombres.Text+" "+txtApellidos.Text+ " ?", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (a == DialogResult.Yes)
                    {
                        EliminarDatos();
                        pnlAgregar.Enabled = true;
                        pnlActualizar.Enabled = false;
                        pnlEliminar.Enabled = false;
                    }
                    else
                    {
                        pnlAgregar.Enabled = false;
                        pnlActualizar.Enabled = true;
                        pnlEliminar.Enabled = true;
                    }

                    break;
                case 2:
                    a = MessageBox.Show("¿Desea eliminar al empleado " + txtNombres.Text + " "+txtApellidos.Text+" ?", "Confimar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (a == DialogResult.Yes)
                    {
                        EliminarDatos();
                        pnlAgregar.Enabled = true;
                        pnlActualizar.Enabled = false;
                        pnlEliminar.Enabled = false;
                    }
                    else
                    {
                        pnlAgregar.Enabled = false;
                        pnlActualizar.Enabled = true;
                        pnlEliminar.Enabled = true;
                    }                
                    break;
                default:
                    break;
            }

        }
        #endregion
        private void chkContactos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContactos.Checked !=false)
            {
                grpContacto.Enabled = true;
            }
            else
            {
                grpContacto.Enabled = false;
                txtTelefono.Clear();
            }
        }
        private void btnBackFrom_Click(object sender, EventArgs e)
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
                dgvEmpleados.DataSource = ControladorEmpleado.CargarEmpleadosBuscar(txtBuscar.Text);
                pnlRecargar.Enabled = true;
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = ControladorEmpleado.CargarEmpleados_Controlador();
        }
        #region Inserción de número de teléfono
        void EnvioTelefono()
        {
            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("El campo telefono esta incompleto, por favor completar el campo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string contacto;
                int idempleado;
                contacto = txtTelefono.Text;
                idempleado = Convert.ToInt16(txtidempleados.Text);
                agregarContacto = new ControladorEmpleado.ControladorContacto(contacto, idempleado);
                bool respuesta = agregarContacto.EnviarTelefono();
                if (respuesta == true)
                {
                    txtTelefono.Clear();
                    CargarGridNumTelefono();
                }
                else
                {
                    MessageBox.Show("El número de teléfono no ha sido registrado", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
            if (e.KeyChar == '-' || char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (txtNumDoc.Text.Contains('-') && e.KeyChar == '-')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }          
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            if (txtTelefono.Text.Contains('-') && e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            switch (FrmMain.valortraducir)
            {
                case 1:
                    lblNaneFrm.Text = InglesEmpleados.tslFormEmp;
                    lblAgregar.Text = InglesEmpleados.lblAgregarEmp;
                    lblActualizar.Text = InglesEmpleados.lblActualizarEmp;
                    lblEliminar.Text = InglesEmpleados.lblEliminarEmp;
                    lblLimpiar.Text = InglesEmpleados.lblLimpiarEmp;
                    lblTextoBuscar.Text = InglesEmpleados.lblBuscarEmp;
                    lblBuscar1.Text = InglesEmpleados.lblBuscarEmpBoton;
                    lblRecargar1.Text = InglesEmpleados.lblRecargarEmpBoton;
                    lblNombres.Text = InglesEmpleados.lblNombresEmp;
                    lblApellidos.Text = InglesEmpleados.lblApellidosEmp;
                    lblnacimiento.Text = InglesEmpleados.lblnacimientoEmp;
                    lblTipoDocumento.Text = InglesEmpleados.lblTipoDocumentoEmp;
                    lblNumDoc.Text = InglesEmpleados.lblNumDocEmp;
                    label1.Text = InglesEmpleados.lblCargoEmp;                    
                    lblDepartamento.Text = InglesEmpleados.lblDepartamentoEmp;
                    lblMunicipio.Text = InglesEmpleados.lblMunicipioEmp;
                    lblMostrar.Text = InglesEmpleados.lblMostrarEmp;
                    chkContactos.Text = InglesEmpleados.chkContactosEmp;
                    grpContacto.Text = InglesEmpleados.grpContactoEmp;
                    grpDatos.Text = InglesEmpleados.grpDatosEmp;
                    groupBox1.Text = InglesEmpleados.grpAccionesEmp;
                    lblAgregarTel.Text = InglesEmpleados.lblAgregarTelEmp;
                    lblActualizarTel.Text = InglesEmpleados.lblActualizarTelEmp;
                    lblDGVEmpleados.Text = InglesEmpleados.lblListEmpDGV;
                    lblDGVtelempleados.Text = InglesEmpleados.lblListTelEmpDGV;
                    lblNumTelefono.Text = InglesEmpleados.lblNumTelefonoEmp;

                    dgvEmpleados.Columns[0].HeaderText = "Number of list";
                    dgvEmpleados.Columns[1].HeaderText = "Names";
                    dgvEmpleados.Columns[2].HeaderText = "Last names";
                    dgvEmpleados.Columns[3].HeaderText = "Date of birth";
                    dgvEmpleados.Columns[4].HeaderText = "Type of document";
                    dgvEmpleados.Columns[5].HeaderText = "Number of document";
                    dgvEmpleados.Columns[6].HeaderText = "Municipality";
                    dgvEmpleados.Columns[7].HeaderText = "Departament";
                    dgvEmpleados.Columns[8].HeaderText = "Work position";

                    dgvTelefono.Columns[0].HeaderText = "Number of list";
                    dgvTelefono.Columns[1].HeaderText = "Names";
                    dgvTelefono.Columns[2].HeaderText = "Last names";
                    dgvTelefono.Columns[3].HeaderText = "Number of contact";
                    dgvTelefono.Columns[4].HeaderText = "Number of document";
                    dgvTelefono.Columns[5].HeaderText = "Number of list of employee";

                    break;
                default:
                    break;
            }
            FrmMostrarEmpleados.valormostrar = 1;
        }

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            EnvioTelefono();
        }
        #endregion

        #region Actualización de número de teléfono
        private void dgvTelefono_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dgvTelefono.CurrentRow.Index;
            txtidNumTelefono.Text = dgvTelefono[0, posicion].Value.ToString();
            txtTelefono.Text = dgvTelefono[3, posicion].Value.ToString();
            txtidempleados.Text = dgvTelefono[5, posicion].Value.ToString();

            pnlActualizarTelefono.Enabled = true;
            pnlAgregarTelefono.Enabled = false;
        }
        void ActualizarNumTelefono()
        {
            ControladorEmpleado.ControladorContacto.idcontacto_emp = Convert.ToInt16(txtidNumTelefono.Text);
            int idempleado;
            string contacto;
            contacto = txtTelefono.Text;
            idempleado = Convert.ToInt16(txtidempleados.Text);
            agregarContacto = new ControladorEmpleado.ControladorContacto(contacto, idempleado);
            bool respuesta = agregarContacto.ActualizarContacto_Controlador();
            if (respuesta == true)
            {                
                txtTelefono.Clear();
                CargarGridNumTelefono();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el número de teléfono", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnActualizarTelefono_Click(object sender, EventArgs e)
        {
            ActualizarNumTelefono();
        }
        #endregion
        private void txtNombre_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
            if (txtNombres.Text.Contains(' ') && e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            if (txtApellidos.Text.Contains(' ') && e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
