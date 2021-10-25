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
    public partial class FrmPrimerEmpleado : Form
    {
        public FrmPrimerEmpleado()
        {
            InitializeComponent();
            CargarListas();
        }

        private void chkContacto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContacto.Checked == true)
            {
                pnlContacto.Enabled = true;
            }
            else
            {
                pnlContacto.Enabled = false;
            }
        }

        void CargarListas()
        {
            CargarDepartamento();
            CargarMunicipio();
            CargarTipoDocumento();
        }
        void CargarTipoDocumento()
        {
            try
            {
                cmbTipodocumento.DataSource = ControladorEmpleado.CargarTipoDocumentos_Controlador();
                cmbTipodocumento.DisplayMember = "tipodoc";
                cmbTipodocumento.ValueMember = "idtipodocumento";
            }
            catch (Exception)
            {
                //Error
            }
        }
        void CargarDepartamento()
        {
            try
            {
                cmbDepartamento.DataSource = ControladorEmpleado.CargarDepartamento_Controlador();
                cmbDepartamento.DisplayMember = "departamento";
                cmbDepartamento.ValueMember = "iddepartamento";
            }
            catch (Exception)
            {
                //Error
            }
        }
        void CargarMunicipioSelect()
        {
            try
            {
                int iddepartamento = Convert.ToInt16(cmbDepartamento.SelectedValue);
                cmbMunicipio.DataSource = ControladorEmpleado.CargarMunicipio_Controlador(iddepartamento);
                cmbMunicipio.DisplayMember = "municipio";
                cmbMunicipio.ValueMember = "idmunicipio";
            }
            catch (Exception)
            {
                //Error, siempre va a dar error, porque no se selecciona el departamento
            }
        }
        void CargarMunicipio()
        {
            try
            {
                cmbMunicipio.DataSource = ControladorEmpleado.CargarMunicipioInicio();
                cmbMunicipio.DisplayMember = "municipio";
                cmbMunicipio.ValueMember = "idmunicipio";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMunicipioSelect();
        }
        //Inserción
        void PrimerEmpleado()
        {
            DateTime today = DateTime.Today;

            ControladorEmpleado objEmp = new ControladorEmpleado();
            if (chkContacto.Checked == true)
            {
                if (dtNacimiento.Value.Date >= today || dtNacimiento.Value.AddYears(18) > today)
                {
                    MessageBox.Show("Verifique su edad, recuerde que la edad mínima para registrar es 18 años", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtApellidos.Text.Trim() != "" || txtNombre.Text.Trim() != "" || txtNumdoc.Text != "" || txtNumContacto.Text.Trim() != "")
                {
                    ControladorEmpleado.ControladorContacto addcontacto;

                    objEmp.nombre_emp = txtNombre.Text;
                    objEmp.apellido_emp = txtApellidos.Text;
                    objEmp.fecha_nacimiento = dtNacimiento.Text;
                    objEmp.idcargo = 1;
                    objEmp.idtipodocumento = Convert.ToInt16(cmbTipodocumento.SelectedValue);
                    objEmp.num_doc = txtNumdoc.Text;
                    objEmp.idmunicipio = Convert.ToInt16(cmbMunicipio.SelectedValue);

                    bool respuesta = objEmp.EnviarDatos();
                    if (respuesta == true)
                    {
                        addcontacto = new ControladorEmpleado.ControladorContacto();
                        int idempleado = addcontacto.BuscarEmpleado(txtNumdoc.Text);
                        if (idempleado >= 1)
                        {
                            addcontacto = new ControladorEmpleado.ControladorContacto(txtNumContacto.Text, idempleado);
                            bool respuesta2 = addcontacto.EnviarTelefono();
                            if (respuesta2 == true)
                            {
                                MessageBox.Show("Se agregaron los datos correctamente, ahora que ya existe un empleado registrado, ha llegado el momento de registrar un usuario, así que irás al formulario para agregar un nuevo usuario", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FrmPrimerUsuario frmprimerusuario = new FrmPrimerUsuario();
                                this.Hide();
                                frmprimerusuario.Show();
                            }
                            else
                            {
                                //Error en la inserción de contacto
                            }
                        }
                    }
                    else
                    {
                        switch (FrmPrimerUso.valortraducir)
                        {
                            case 1:
                                MessageBox.Show("Error entering data", "Critical error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            case 2:
                                MessageBox.Show("Error al ingresar empleado", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            default:
                                break;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Existen campos vacíos, porfavor llenelos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (dtNacimiento.Value.Date >= today || dtNacimiento.Value.AddYears(18) > today)
                {
                    switch (FrmPrimerUso.valortraducir)
                    {
                        case 1:
                            MessageBox.Show("Check your age, remember that the minimum age to register is 18 years old", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 2:
                            MessageBox.Show("Verifique su edad, recuerde que la edad mínima para registrar es 18 años", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            break;
                    }
                }

                else if (txtApellidos.Text.Trim() != "" || txtNombre.Text.Trim() != "" || txtNumdoc.Text.Trim() != "")
                {
                    objEmp.nombre_emp = txtNombre.Text;
                    objEmp.apellido_emp = txtApellidos.Text;
                    objEmp.fecha_nacimiento = dtNacimiento.Text;
                    objEmp.idcargo = 1;
                    objEmp.idtipodocumento = Convert.ToInt16(cmbTipodocumento.SelectedValue);
                    objEmp.num_doc = txtNumdoc.Text;
                    objEmp.idmunicipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                    bool respuesta = objEmp.EnviarDatos();
                    if (respuesta == true)
                    {
                        switch (FrmPrimerUso.valortraducir)
                        {
                            case 1:
                                MessageBox.Show("The data was added successfully, now that there is already a registered employee, the time has come to register a user, so you will go to the form to add a new user.", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case 2:
                                MessageBox.Show("Se agregaron los datos correctamente, ahora que ya existe un empleado registra, ha llegado el momento de registrar un usuario, así que irás al formulario para agregar un nuevo usuario.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            default:
                                break;
                        }
                        FrmPrimerUsuario frmprimerusuario = new FrmPrimerUsuario();
                        this.Hide();
                        frmprimerusuario.Show();
                    }
                    else
                    {
                        switch (FrmPrimerUso.valortraducir)
                        {
                            case 1:
                                MessageBox.Show("Error entering data", "Critical error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            case 2:
                                MessageBox.Show("Error al ingresar empleado", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PrimerEmpleado();
        }

        private void txtNombre_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
            if (txtNombre.Text.Contains('-') && e.KeyChar == '-')
            {
                e.Handled = false;
            }
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            if (txtApellidos.Text.Contains(' ') && e.KeyChar == ' ')
            {
                e.Handled = true;
            }

        }

        private void txtDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            if (txtApellidos.Text.Contains(' ') && e.KeyChar == ' ')
            {
                e.Handled = true;
            }

        }

        private void txtNumContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            if (txtNumContacto.Text.Contains('-') && e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }

        private void FrmPrimerEmpleado_Load(object sender, EventArgs e)
        {
            switch (FrmPrimerUso.valortraducir)
            {
                case 1:
                    lblInfoRegistrarEmp.Text = InglesPrimerUso.lblInfoRegistrarEmp;
                    lblAgregarDatosNuevoEmp.Text = InglesPrimerUso.lblAgregarDatosNuevoEmp;
                    lblApellidosNuevoEmp.Text = InglesPrimerUso.lblApellidosNuevoEmp;
                    lblDepartamentoNuevo.Text = InglesPrimerUso.lblDepartamentoNuevoEmp;
                    lblMunicipioNuevoEmp.Text = InglesPrimerUso.lblMunicipioNuevoEmp;
                    lblNacimientoNuevoEmp.Text = InglesPrimerUso.lblNacimientoNuevoEmp;
                    lblNombreNuevoEmp.Text = InglesPrimerUso.lblNombreNuevoEmp;
                    lblNumDocNuevoEmp.Text = InglesPrimerUso.lblNumDocNuevoEmp;
                    lblNumTelsNuevoEmp.Text = InglesPrimerUso.lblNumTelsNuevoEmp;
                    lblRegistrarEmp.Text = InglesPrimerUso.lblRegistrarEmp;
                    lblTipoDocNuevoEmp.Text = InglesPrimerUso.lblTipoDocNuevoEmp;
                    grbDatosNuevoEmp.Text = InglesEmpleados.grpDatosEmp;
                    chkContacto.Text = InglesPrimerUso.chkContacto;

                    lblAgregarDatosNuevoEmp.Location = new Point(28, 10);
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
