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
    public partial class FrmPrimerUsuario : Form
    {
        public FrmPrimerUsuario()
        {
            InitializeComponent();
            dgvEmpleado.DataSource = ControladorEmpleado.CargarEmpleados_ControladorGeneral();
            dgvEmpleado.Columns[0].Visible = false;
            dgvEmpleado.Columns[1].HeaderText = "Nombres";
            dgvEmpleado.Columns[2].HeaderText = "Apellidos";
            dgvEmpleado.Columns[3].HeaderText = "Fecha de nacimiento";
            dgvEmpleado.Columns[4].Visible = false;
            dgvEmpleado.Columns[5].HeaderText = "Número de documento";
            dgvEmpleado.Columns[6].HeaderText = "Municipio";
            dgvEmpleado.Columns[7].Visible = false;
            dgvEmpleado.Columns[8].HeaderText = "Cargo";
        }
        void PrimerUsuario()
        {
            string usuario, clave, correo;
            int idempleado, idtipousuario, idestadousuario;

            usuario = txtUsuario.Text;
            clave = Validacion.GetMD5("NewPassword123");
            correo = txtCorreo.Text;
            idempleado = Convert.ToInt16(txtIDempleado.Text);
            idtipousuario = 1;//Root
            idestadousuario = 1;//Activo

            ControladorUsuario objusuario = new ControladorUsuario(usuario, clave, correo, idempleado, idtipousuario, idestadousuario);
            bool respuesta = objusuario.InsertarUsuario();
            if (respuesta == true)
            {
                switch (FrmPrimerUso.valortraducir)
                {
                    case 1:
                        MessageBox.Show("The user was entered correctly, now you will be directed to the form to log in, remember that the default password is NewPassword123.", "Proceso completa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 2:
                        MessageBox.Show("El usuario se ingreso correctamente, ahora serás direccionado al formulario para iniciar sesión, recuerda que la constraseña por defecto es NewPassword123.", "Proceso completa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    default:
                        break;
                }
                FrmLogIn frmlogin = new FrmLogIn();
                frmlogin.Show();
                this.Hide();
            }
            else
            {
                switch (FrmPrimerUso.valortraducir)
                {
                    case 1: MessageBox.Show("Error, probably that employee already has a user created or only selects the employee that you are.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    case 2: MessageBox.Show("Error, probablemente ese empleado ya tenga un usuario creado o solo selecciona bien el empleado que eres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    default:
                        break;
                }
            }            
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n1 = dgvEmpleado.CurrentRow.Index;
            txtIDempleado.Text = dgvEmpleado[0, n1].Value.ToString();
            chkSelect.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PrimerUsuario();
        }

        private void FrmPrimerUsuario_Load(object sender, EventArgs e)
        {
            switch (FrmPrimerUso.valortraducir)
            {
                case 1:
                    lblAgregarDatosNuevoEmp.Text = InglesPrimerUso.lblAgregarDatosNuevoEmp;
                    lblCorreoNuevoUsu.Text = InglesPrimerUso.lblCorreoNuevoUsu;
                    lblHolaPrimerUsuario.Text = InglesPrimerUso.lblHolaPrimerUsuario;
                    lblNombreNuevoUsu.Text = InglesPrimerUso.lblNombreNuevoUsu;
                    lblReglesPrimerUsuario.Text = InglesPrimerUso.lblReglasPrimerUsuario;
                    lblSelecEmpleados.Text = InglesPrimerUso.lblSelecEmpleados;

                    chkSelect.Location = new Point(489, 191);
                    lblAgregarDatosNuevoEmp.Location = new Point(28, 10);

                    dgvEmpleado.Columns[1].HeaderText = "Names";
                    dgvEmpleado.Columns[2].HeaderText = "Last names";
                    dgvEmpleado.Columns[3].HeaderText = "Date of birth";
                    dgvEmpleado.Columns[5].HeaderText = "Document number";
                    dgvEmpleado.Columns[6].HeaderText = "Municipality";
                    dgvEmpleado.Columns[8].HeaderText = "Work position";

                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
