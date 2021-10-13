using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            CargarListas();
            NivelUsuario();
            cmbEstado.Enabled = false;
            pnlRecargar.Enabled = false;
            pnlRecargar2.Enabled = false;
            pnlActualizar.Enabled = false;
            pnlEliminar.Enabled = false;
        }
        string usuario, clave, correo;
        int idempleado, idtipousuario, idestadousuario;
        public FrmMain principal = new FrmMain();
        void NivelUsuario()
        {
            switch (ControladorLogIn.tipousuario)
            {
                case 1://Root
                    //Nada bloqueado
                    break;
                case 2://Administrador de empleado
                    dgvEmpleados.Columns[0].Visible = false;
                    dgvUsuarios.Columns[0].Visible = false;
                    dgvUsuarios.Columns[8].Visible = false;
                    dgvUsuarios.Size = new Size(743, 285);
                    break;      //Los demás tipos de usuario no tienen acceso a este formulario
                default:
                    break;
            }
        }

        //Limpiar campos
        void LimpiarControles()
        {
            txtNombreUser.Clear();
            txtNumeroEmpleado.Clear();
            txtCorreo.Clear();
            
            CargarListas();

            cmbEstado.Enabled = false;
            pnlRecargar.Enabled = false;
            pnlRecargar2.Enabled = false;
            pnlActualizar.Enabled = false;
            pnlEliminar.Enabled = false;
            pnlAgregar.Enabled = true;
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        #region CRUD usuario
        //Mostrar
        #region Lectura de datos
        void CargarListas()
        {
            CargarCargo();
            CargarEstado();            
            CargarEmpleados();
            CargarUsuarios();
        }
        void CargarEstado()
        {
            try
            {
                cmbEstado.DataSource = ControladorUsuario.CargarEstadoUsuario();
                cmbEstado.DisplayMember = "estado_usuario";
                cmbEstado.ValueMember = "idestado_usuario";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los estados de usuario", "Error de cargar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void CargarCargo()
        {
            try
            {
                cmbCargo.DataSource = ControladorUsuario.CargarTipoUsuario();
                cmbCargo.DisplayMember = "tipoUsuario";
                cmbCargo.ValueMember = "idtipoUsuario";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la lista de cargos", "Error de cargar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void CargarEmpleados()
        {
            dgvEmpleados.DataSource = ControladorUsuario.CargarEmpleados();
            dgvEmpleados.Columns[0].HeaderText = "Número de lista del empleado";//
            dgvEmpleados.Columns[1].HeaderText = "Nombres";
            dgvEmpleados.Columns[2].HeaderText = "Apellidos";
            dgvEmpleados.Columns[3].HeaderText = "Fecha de nacimiento";
            dgvEmpleados.Columns[5].HeaderText = "Número de documento";
            dgvEmpleados.Columns[4].HeaderText = "Tipo de documento";
            dgvEmpleados.Columns[6].HeaderText = "Municipio";
            dgvEmpleados.Columns[7].HeaderText = "Departamento";
            dgvEmpleados.Columns[8].HeaderText = "Cargo";

        }
        void CargarUsuarios()
        {
            dgvUsuarios.DataSource = ControladorUsuario.CargarUsuarios();
            dgvUsuarios.Columns[0].HeaderText = "Número de lista";//
            dgvUsuarios.Columns[1].HeaderText = "Nombre de usuario";
            dgvUsuarios.Columns[2].HeaderText = "Correo electronico";//
            dgvUsuarios.Columns[3].HeaderText = "Nombres";
            dgvUsuarios.Columns[4].HeaderText = "Apellidos";
            dgvUsuarios.Columns[5].HeaderText = "Número de documento";
            dgvUsuarios.Columns[6].HeaderText = "Tipo de usuario";//
            dgvUsuarios.Columns[7].HeaderText = "Estado";//
            dgvUsuarios.Columns[8].HeaderText = "Número de lista del empleado";//

        }
        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            switch (FrmMostrarUsuarios.valormostrar)
            {
                case 1:
                    FrmMostrarUsuarios frmmostrar = new FrmMostrarUsuarios();
                    frmmostrar.Show();
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
        #endregion

        //Inserción
        void Insercion()
        {
            if (txtNombreUser.Text.Trim() == "" || txtNumeroEmpleado.Text.Trim() == "" || txtCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos vacíos, recuerde que si quiere ingresar datos, necesita llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                usuario = txtNombreUser.Text;
                clave = Validacion.GetMD5("NewPassword123");
                correo = txtCorreo.Text;
                idempleado = Convert.ToInt16(txtNumeroEmpleado.Text);
                idtipousuario = Convert.ToInt16(cmbCargo.SelectedValue);
                idestadousuario = 1;
                ControladorUsuario ADD = new ControladorUsuario(usuario, clave, correo, idempleado, idtipousuario, idestadousuario);
                bool resultadoF = ADD.InsertarUsuario();
                if (resultadoF == true)
                {
                    CargarUsuarios();
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show("Error al agregar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Insercion();
        }
        //Actualización
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dgvUsuarios.CurrentRow.Index;
            txtIdUsuario.Text = dgvUsuarios[0, a].Value.ToString();
            txtNombreUser.Text = dgvUsuarios[1, a].Value.ToString();
            txtCorreo.Text = dgvUsuarios[2, a].Value.ToString();
            string tipoUsuario = dgvUsuarios[6, a].Value.ToString();
            string EstadoUsuario = dgvUsuarios[7, a].Value.ToString();
            txtNumeroEmpleado.Text = dgvUsuarios[8, a].Value.ToString();

            cmbCargo.DataSource = ControladorUsuario.CargarTiposUsser(tipoUsuario);
            cmbCargo.DisplayMember = "tipoUsuario";
            cmbCargo.ValueMember = "idtipoUsuario";

            cmbEstado.DataSource = ControladorUsuario.CargarEstados_Usuario(EstadoUsuario);
            cmbEstado.DisplayMember = "estado_usuario";
            cmbEstado.ValueMember = "idestado_usuario";
            
            pnlAgregar.Enabled = false;
            cmbEstado.Enabled = true;
            pnlActualizar.Enabled = true;
            pnlEliminar.Enabled = true;
            //6/10/2021 no permite que se auto cambie de estado y de cargo
            if (txtNombreUser.Text == AtributosCredenciales.UsuarioVerif)
            {
                cmbEstado.Enabled = false;
                cmbCargo.Enabled = false;
            }
            else
            {
                cmbEstado.Enabled = true;
                cmbCargo.Enabled = true;
            }
        }
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {                       
                int a = dgvEmpleados.CurrentRow.Index;
                txtNumeroEmpleado.Text = dgvEmpleados[0, a].Value.ToString();
        }
        void Actualizacion()
        {            
            if (txtNombreUser.Text.Trim() == "" || txtNumeroEmpleado.Text.Trim() == ""|| txtCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos vacíos, porfavor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ControladorUsuario.idusuario = Convert.ToInt16(txtIdUsuario.Text);
                usuario = txtNombreUser.Text;
                correo = txtCorreo.Text;
                idempleado = Convert.ToInt16(txtNumeroEmpleado.Text);
                idtipousuario = Convert.ToInt16(cmbCargo.SelectedValue);
                idestadousuario = Convert.ToInt16(cmbEstado.SelectedValue);
                ControladorUsuario obj = new ControladorUsuario(usuario, correo,idempleado, idtipousuario, idestadousuario);
                int valoretorno = obj.ActualizacionUsuario();
                if (valoretorno >= 1)
                {
                    CargarUsuarios();
                    LimpiarControles();
                    cmbEstado.Enabled = false;
                    pnlRecargar.Enabled = false;
                    pnlRecargar2.Enabled = false;
                    pnlActualizar.Enabled = false;
                    pnlEliminar.Enabled = false;
                    pnlAgregar.Enabled = true;
                }
            }            
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizacion();
        }

        private void btnBackForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscarempleado_Click(object sender, EventArgs e)
        {
            if (txtBuscarEmpleado.Text.Trim() == "")
            {

            }
            else
            {
                dgvEmpleados.DataSource = ControladorEmpleado.CargarEmpleadosBuscar(txtBuscarEmpleado.Text);
                pnlRecargar2.Enabled = true;
            }
        }

        private void btnRecargar2_Click(object sender, EventArgs e)
        {            
            dgvEmpleados.DataSource = ControladorEmpleado.CargarEmpleados_Controlador();                       
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "")
            {

            }
            else
            {
                dgvUsuarios.DataSource = ControladorUsuario.BuscarUsuarios(txtBuscar.Text);
                pnlRecargar.Enabled = true;
            }
        }



        private void btnRecargar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = ControladorUsuario.CargarUsuarios();
        }



        private void cmbCargo_Click_1(object sender, EventArgs e)
        {
            CargarCargo();
        }

        private void cmbEstado_Click(object sender, EventArgs e)
        {
            CargarEstado();
        }

        //Eliminación
        void Eliminar()
        {
            if (txtNombreUser.Text == AtributosCredenciales.UsuarioVerif)
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
                DialogResult drp;

                switch (FrmMain.valortraducir)
                {
                    case 1:
                        drp = MessageBox.Show("Dou you want delete " + txtNombreUser.Text + " ?", "Notificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (drp == DialogResult.Yes)
                        {
                            ControladorUsuario.idusuario = Convert.ToInt16(txtIdUsuario.Text);
                            bool valorf = ControladorUsuario.EliminarUsuario();
                            if (valorf == true)
                            {
                                CargarUsuarios();
                                LimpiarControles();
                                cmbEstado.Enabled = false;
                                pnlRecargar.Enabled = false;
                                pnlRecargar2.Enabled = false;
                                pnlActualizar.Enabled = false;
                                pnlEliminar.Enabled = false;
                                pnlAgregar.Enabled = true;

                            }
                            else
                            {
                                MessageBox.Show("Error to eliminate user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case 2:
                        drp = MessageBox.Show("Desea eliminar a " + txtNombreUser.Text + " ? ", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (drp == DialogResult.Yes)
                        {
                            ControladorUsuario.idusuario = Convert.ToInt16(txtIdUsuario.Text);
                            bool valorf = ControladorUsuario.EliminarUsuario();
                            if (valorf == true)
                            {
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();

            cmbEstado.Enabled = false;
            pnlRecargar.Enabled = false;
            pnlRecargar2.Enabled = false;
            pnlActualizar.Enabled = false;
            pnlEliminar.Enabled = false;
            pnlAgregar.Enabled = true;
        }
        #endregion
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Traducir();
            FrmMostrarUsuarios.valormostrar = 1;
        }
        void Traducir()
        {
            switch (FrmMain.valortraducir)
            {
                case 1:
                    tlsFrm.Text = InglesUsuario.tlsFrm;
                    lblAgregar.Text = InglesUsuario.lblAgregar;
                    lblmostrar.Text = InglesUsuario.lblMostrar;
                    lblActualizar.Text = InglesUsuario.lblActualizar;
                    lblEliminar.Text = InglesUsuario.lblEliminar;
                    lblDescripBuscar.Text = InglesUsuario.lblDescripBuscar;
                    lblBuscar1.Text = InglesUsuario.Buscar;
                    lblRecargar1.Text = InglesUsuario.Recargar;
                    lblLimpiar.Text = InglesUsuario.lblLimpiar;
                    lblNombre.Text = InglesUsuario.lblNombre;
                    lblTipoUsuario.Text = InglesUsuario.lblTipousuario;
                    lblEstado.Text = InglesUsuario.lblEstado;
                    lblNumeroEmpleado.Text = InglesUsuario.lblNumeroLista;
                    lblCorreo.Text = InglesUsuario.lblCorreo;
                    lblDescripBuscar2.Text = InglesUsuario.lblDescripBuscar2;
                    lblBuscar2.Text = InglesUsuario.Buscar;
                    lblRecargar2.Text = InglesUsuario.Recargar;
                    lblListaEmpleados.Text = InglesUsuario.lblListaempleados;
                    lblListaUsuarios.Text = InglesUsuario.lblListaUsuarios;
                    groupBox3.Text = InglesEmpleados.grpAccionesEmp;
                    groupBox1.Text = InglesUsuario.grpdatos;

                    dgvEmpleados.Columns[0].HeaderText = "Number of list of employee";//
                    dgvEmpleados.Columns[1].HeaderText = "Names";
                    dgvEmpleados.Columns[2].HeaderText = "Last names";
                    dgvEmpleados.Columns[3].HeaderText = "Date of birth";
                    dgvEmpleados.Columns[5].HeaderText = "Number of document";
                    dgvEmpleados.Columns[4].HeaderText = "Type of document";
                    dgvEmpleados.Columns[6].HeaderText = "Municipality";
                    dgvEmpleados.Columns[7].HeaderText = "Departament";
                    dgvEmpleados.Columns[8].HeaderText = "Work position";

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
