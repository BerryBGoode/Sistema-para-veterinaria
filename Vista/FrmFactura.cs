using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
            pnlAgregar.Enabled = true;
            pnlActualizar.Enabled = false;
            pnlEliminar.Enabled = false;
            FrmMostrarFactura.valormostrar = 1;
        }
        ControladorFactura objFactura = new ControladorFactura();
        int final;
        DateTime ahora = DateTime.Today;
        string formato = "yyyy/MM/dd";

        void NivelUsuario()
        {
            switch (ControladorLogIn.tipousuario)
            {
                case 1:
                    dgvEmpleados.Columns[8].Visible = false;
                    dgvFacturas.Columns[7].Visible = false;
                    dgvFacturas.Columns[8].Visible = false;
                    break;
                case 5:
                    dgvEmpleados.Columns[8].Visible = false;
                    dgvPropietarios.Columns[4].Visible = false;
                    dgvPropietarios.Columns[8].Visible = false;
                    dgvFacturas.Columns[7].Visible = false;
                    dgvFacturas.Columns[8].Visible = false;
                    break;
                default:
                    break;
            }
        }
        void Limpiar()
        {
            txtIDFactura.Clear();
            txtNumListaEmpleado.Clear();
            txtNumListaPropietario.Clear();
            txtTotalPagar.Clear();
            CargarEstadoFactura();
            
            btnMostrar.Enabled = true;
            pnlAgregar.Enabled = true;
            pnlActualizar.Enabled = false;
            pnlEliminar.Enabled = false;
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            switch (FrmMostrarFactura.valormostrar)
            {
                case 1:
                    FrmMostrarFactura ab = new FrmMostrarFactura();
                    ab.Show();
                    break;
                default:
                    break;
            }
        }
        #region Lectura de datos
        void CargarEstadoFactura()
        {
            try
            {
                cmbEstadoFactura.DataSource = ControladorFactura.CargarEstadoFactura();//Ingresar datos en la base xd
                cmbEstadoFactura.DisplayMember = "estado_factura";
                cmbEstadoFactura.ValueMember = "idestado_factura";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la lista de estado de la factura", "Error de cargar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        void CargarEmpleado()
        {
            dgvEmpleados.DataSource = ControladorFactura.CargarEmpleados();
            dgvEmpleados.Columns[0].HeaderText = "Número de lista de usuario";
            dgvEmpleados.Columns[1].HeaderText = "Nombre de usuario";
            dgvEmpleados.Columns[2].HeaderText = "Correo";
            dgvEmpleados.Columns[3].HeaderText = "Nombres";
            dgvEmpleados.Columns[4].HeaderText = "Apellidos";
            dgvEmpleados.Columns[5].HeaderText = "Número de documento";
            dgvEmpleados.Columns[6].HeaderText = "Tipo de usuario";
            dgvEmpleados.Columns[7].HeaderText = "Estado del usuario";
            dgvEmpleados.Columns[8].HeaderText = "Número de lista del empleado";

        }
        void CargarPropietario()
        {
            dgvPropietarios.DataSource = ControladorFactura.CargarPropietarios();
            dgvPropietarios.Columns[0].HeaderText = "Número de lista del propietario";//Vis = F, != root
            dgvPropietarios.Columns[1].HeaderText = "Nombres";
            dgvPropietarios.Columns[2].HeaderText = "Apellidos";
            dgvPropietarios.Columns[3].HeaderText = "Fecha de nacimiento";
            dgvPropietarios.Columns[4].HeaderText = "Tipo de documento";//Vis = F, != Root
            dgvPropietarios.Columns[5].HeaderText = "Número de documento";
            dgvPropietarios.Columns[6].HeaderText = "Municipio";
            dgvPropietarios.Columns[7].HeaderText = "Departamento";
            dgvPropietarios.Columns[8].HeaderText = "Estado del propietario";//Visible = false en todos menos root            

        }
        void CargarFactura()
        {
            dgvFacturas.DataSource = ControladorFactura.CargarFactura();
            dgvFacturas.Columns[0].HeaderText = "Número de lista de factura";
            dgvFacturas.Columns[1].HeaderText = "Nombre del propietario";
            dgvFacturas.Columns[2].HeaderText = "Apellido del propietario";
            dgvFacturas.Columns[3].HeaderText = "Monto";
            dgvFacturas.Columns[4].HeaderText = "Fecha de facturación";
            dgvFacturas.Columns[5].HeaderText = "Nombre del usuario";
            dgvFacturas.Columns[6].HeaderText = "Estado de la factura";
            dgvFacturas.Columns[7].HeaderText = "Número de lista del propietario";//
            dgvFacturas.Columns[8].HeaderText = "Número de lista del usuario";

        }
        private void FrmFactura_Load(object sender, EventArgs e)
        {
            CargarEstadoFactura();
            CargarEmpleado();
            CargarPropietario();
            CargarFactura();
            pnlRecargar.Enabled = false;
            pnlRecargar2.Enabled = false;

            switch (FrmMain.valortraducir)
            {
                case 1:
                    label11.Text = InglesFactura.lblAgregarFact;
                    label10.Text = InglesFactura.lblMostrarFact;
                    label9.Text = InglesFactura.lblActualizarFact;
                    label8.Text = InglesFactura.lblEliminarFact;
                    label7.Text = InglesFactura.lblLimpiarFact;
                    label1.Text = InglesFactura.lblListaPropiFactura;
                    label2.Text = InglesFactura.lblListaDocFactura;
                    label3.Text = InglesFactura.lblEstadoFactura;
                    label4.Text = InglesFactura.lblTotalFactura;
                    label6.Text = InglesFactura.lblFechaFactura;
                    label18.Text = InglesFactura.txtBuscarPropieFactura;
                    label17.Text = InglesFactura.lblRecargarFactBoton;
                    label20.Text = InglesFactura.lblListaDocFactura;
                    label19.Text = InglesFactura.lblBuscarFactBoton;
                    label14.Text = InglesFactura.lblBuscarUsuarioPropie;
                    label12.Text = InglesFactura.lblListPropieDGV;
                    label13.Text = InglesFactura.lblListUsuarioDGV;
                    rbtnEmpleado.Text = InglesFactura.rbtnEmpleado;
                    rbtnPropietario.Text = InglesFactura.rbtnPropietario;
                    groupBox1.Text = InglesFactura.grbDatosFactura;
                    groupBox3.Text = InglesFactura.grbAccionesFactura;
                    label15.Text = InglesFactura.lblBuscarFactBoton;
                    label16.Text = InglesFactura.lblRecargarFactBoton;
                    toolStripLabel1.Text = "invoice form";

                    label18.Location = new Point(11, 433);
                    dgvEmpleados.Columns[0].HeaderText = "Number of list of user";
                    dgvEmpleados.Columns[1].HeaderText = "Username";
                    dgvEmpleados.Columns[2].HeaderText = "Adress gmail";
                    dgvEmpleados.Columns[3].HeaderText = "Names";
                    dgvEmpleados.Columns[4].HeaderText = "Last names";
                    dgvEmpleados.Columns[5].HeaderText = "Number of document";
                    dgvEmpleados.Columns[6].HeaderText = "Type of user";
                    dgvEmpleados.Columns[7].HeaderText = "State of user";
                    dgvEmpleados.Columns[8].HeaderText = "Number of list of user";

                    dgvPropietarios.Columns[0].HeaderText = "Número de lista del propietario";//Vis = F, != root
                    dgvPropietarios.Columns[1].HeaderText = "Names";
                    dgvPropietarios.Columns[2].HeaderText = "Last names";
                    dgvPropietarios.Columns[3].HeaderText = "Date of birth";
                    dgvPropietarios.Columns[4].HeaderText = "Type of document";//Vis = F, != Root
                    dgvPropietarios.Columns[5].HeaderText = "Number of document";
                    dgvPropietarios.Columns[6].HeaderText = "Municipality";
                    dgvPropietarios.Columns[7].HeaderText = "Departament";
                    dgvPropietarios.Columns[8].HeaderText = "State of owner";//Visible = false en todos menos root            

                    dgvFacturas.Columns[0].HeaderText = "Number of list";
                    dgvFacturas.Columns[1].HeaderText = "Names of owner";
                    dgvFacturas.Columns[2].HeaderText = "Last names of owner";
                    dgvFacturas.Columns[3].HeaderText = "Totay pay";
                    dgvFacturas.Columns[4].HeaderText = "Billing date";
                    dgvFacturas.Columns[5].HeaderText = "Username";
                    dgvFacturas.Columns[6].HeaderText = "Invoice state";
                    dgvFacturas.Columns[7].HeaderText = "Number of list of owner";//
                    dgvFacturas.Columns[8].HeaderText = "Number of list of user";
                    break;

                default:
                    break;
            }
        }
        //Inserción
        void AgregarFactura()
        {
            if (dtFechaFactura.Value.Date > ahora)
            {
                MessageBox.Show("La factura, tiene que estar hecha el día de ahora, no acepta futuras a "+ahora.ToString(formato), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtFechaFactura.Value.AddMonths(12) < ahora)
            {
                MessageBox.Show("La factura, tiene que estar hecha un día de ahora, no se acepta pasadas a "+ahora.ToString(formato), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
            else if (txtNumListaEmpleado.Text.Trim() == "" || txtNumListaPropietario.Text.Trim() == "" || txtTotalPagar.Text == "")
            {
                MessageBox.Show("Existen campos vacíos, porfavor llenar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                objFactura.idpropietario = Convert.ToInt16(txtNumListaPropietario.Text);
                objFactura.idestado_factura = Convert.ToInt16(cmbEstadoFactura.SelectedValue);
                objFactura.fecha_factura = dtFechaFactura.Text;
                objFactura.totalpaga = "$"+txtTotalPagar.Text;
                objFactura.idusuario = Convert.ToInt16(txtNumListaEmpleado.Text);
                int respuesta = objFactura.IngresarFactura();
                if (respuesta >= 1)
                {
                    dgvFacturas.DataSource = ControladorFactura.CargarFactura();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarFactura();
        }
        private void dgvPropietarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            final = dgvPropietarios.CurrentRow.Index;
            txtNumListaPropietario.Text = dgvPropietarios[0, final].Value.ToString();                        
        }
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            final = dgvEmpleados.CurrentRow.Index;
            txtNumListaEmpleado.Text = dgvEmpleados[0, final].Value.ToString();            
        }

        //Actualización
        void ActualizarFactura()
        {
            if (dtFechaFactura.Value.Date > ahora)
            {
                MessageBox.Show("La factura, tiene que estar hecha el día de ahora, no acepta futuras a " + ahora.ToString(formato), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtFechaFactura.Value.AddMonths(12) < ahora)
            {
                MessageBox.Show("La factura, tiene que estar hecha un día de ahora, no se acepta pasadas a " + ahora.ToString(formato), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNumListaEmpleado.Text.Trim() == "" || txtNumListaPropietario.Text.Trim() == "" || txtTotalPagar.Text == "")
            {
                MessageBox.Show("Existen campos vacíos, porfavor llenar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                objFactura.idfactura = Convert.ToInt16(txtIDFactura.Text);
                objFactura.idpropietario = Convert.ToInt16(txtNumListaPropietario.Text);
                objFactura.fecha_factura = dtFechaFactura.Text;
                objFactura.idusuario = Convert.ToInt16(txtNumListaEmpleado.Text);
                objFactura.idestado_factura = Convert.ToInt16(cmbEstadoFactura.SelectedValue);
                objFactura.totalpaga = txtTotalPagar.Text;
                int respuestaUPDATE = objFactura.ActualizarFactura();
                if (respuestaUPDATE == 1)
                {
                    dgvFacturas.DataSource = ControladorFactura.CargarFactura();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error consulte error con un administrador", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private void dgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            final = dgvFacturas.CurrentRow.Index;
            txtIDFactura.Text = dgvFacturas[0, final].Value.ToString();
            txtNumListaPropietario.Text = dgvFacturas[7, final].Value.ToString();
            string estado = dgvFacturas[6, final].Value.ToString();
            txtTotalPagar.Text = dgvFacturas[3, final].Value.ToString();
            dtFechaFactura.Text = dgvFacturas[4, final].Value.ToString();
            txtNumListaEmpleado.Text = dgvFacturas[8, final].Value.ToString();

            cmbEstadoFactura.DataSource = ControladorFactura.CargarEstadoUPDATE(estado);
            cmbEstadoFactura.DisplayMember = "estado_factura";
            cmbEstadoFactura.ValueMember = "idestado_factura";

            CargarEstadoFactura();
            pnlAgregar.Enabled = false;
            pnlActualizar.Enabled = true;
            pnlEliminar.Enabled = true;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarFactura();
        }

        void BorrarFactura()
        {
            if (txtNumListaEmpleado.Text.Trim() == "" || txtNumListaPropietario.Text.Trim() == "" || txtTotalPagar.Text == "")
            {
                MessageBox.Show("Existen campos vacíos, porfavor llenar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                objFactura.idfactura = Convert.ToInt16(txtIDFactura.Text);
                int solucion = objFactura.BorrarFactura();
                if (solucion == 1)
                {
                    dgvFacturas.DataSource = ControladorFactura.CargarFactura();
                    Limpiar();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int selectdel = dgvFacturas.CurrentRow.Index;
            DialogResult drq;
            switch (FrmMain.valortraducir)
            {
                case 1:
                    drq = MessageBox.Show("Do you want to delete the invoice from " + dgvFacturas[1, selectdel].Value.ToString() + " " + dgvFacturas[2, selectdel].Value.ToString(), "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drq == DialogResult.Yes)
                    {
                        BorrarFactura();
                    }
                    break;
                case 2:
                    drq = MessageBox.Show("Deseas eliminar la factura de " + dgvFacturas[1, selectdel].Value.ToString()+ " "+dgvFacturas[2, selectdel].Value.ToString(), "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drq == DialogResult.Yes)
                    {
                        BorrarFactura();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnBackForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtnPropietario.Checked == true)
            {
                if (txtBuscar.Text.Trim() != "")
                {
                    dgvPropietarios.DataSource = ControladorPropietario.CargarBusqueda(txtBuscar.Text);
                    pnlRecargar2.Enabled = true;
                }                
            }
            else if (rbtnEmpleado.Checked == true)
            {
                if (txtBuscar.Text.Trim() != "")
                {
                    dgvEmpleados.DataSource = ControladorUsuario.BuscarUsuarios(txtBuscar.Text);
                    pnlRecargar2.Enabled = true;
                }
            }
        }

        private void rbtnPropietario_CheckedChanged(object sender, EventArgs e)
        {
            label14.Enabled = true;
            txtBuscar.Enabled = true;
            pnlBuscar2.Enabled = true;
            txtBuscar.Clear();
            pnlRecargar2.Enabled = false;
            
        }

        private void rbtnEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            label14.Enabled = true;
            txtBuscar.Enabled = true;
            pnlBuscar2.Enabled = true;
            txtBuscar.Clear();
            pnlRecargar2.Enabled = false;
        }

        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            if (txtBuscarFactura.Text.Trim() == "")
            {                
            }
            else
            {
                dgvFacturas.DataSource = ControladorFactura.CargarFacturaBuscarfrm(txtBuscarFactura.Text);
                pnlRecargar.Enabled = true;
            }
        }

        private void btnRecargarFactura_Click(object sender, EventArgs e)
        {
            dgvFacturas.DataSource = ControladorFactura.CargarFactura();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            if (rbtnEmpleado.Checked == true)
            {
                dgvEmpleados.DataSource = ControladorFactura.CargarEmpleados();
            }
            else if (rbtnPropietario.Checked == true)
            {
                dgvPropietarios.DataSource = ControladorFactura.CargarPropietarios();
            }
        }

        private void txtsIDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtTotalPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloDecimales(e);
            if (txtTotalPagar.Text.Contains('.') && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }
    }
}
