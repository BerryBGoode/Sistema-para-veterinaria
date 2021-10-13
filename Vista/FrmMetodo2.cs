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
    public partial class FrmMetodo2 : Form
    {
        public FrmMetodo2()
        {
            InitializeComponent();
            CargarEstado();
        }
        void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtCorreo.Clear();
            CargarEstado();
            txtVerfiNombre.Clear();
            txtVerfiApellido.Clear();
            txtVerfiDoc.Clear();
            txtVerfiCorreo.Clear();
            txtVerfiUsuario.Clear();
            txtVerfiCargo.Clear();
        }

        ControladorRecuperar objrecuperar = new ControladorRecuperar();
        void CargarEstado()
        {
            try
            {
                cmbEstado.DataSource = ControladorRecuperar.cargarEstado();
                cmbEstado.DisplayMember = "estado_usuario";
                cmbEstado.ValueMember = "idestado_usuario";
            }
            catch (Exception)
            {

            }
        }
        private void btnNoSoy_Click(object sender, EventArgs e)
        {
            switch (FrmLogIn.valortraduc)
            {
                case 1:
                    MessageBox.Show("So if it is not you, we ask that you re-enter this form again", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Entonces si no es usted, le pedimos que vuelva a a ingresar a este formulario de nuevo", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
            FrmMétodosRecup metodos = new FrmMétodosRecup();
            metodos.Show();
            this.Hide();
        }

        private void btnVerficar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtDoc.Text.Trim() == "")
            {
                switch (FrmLogIn.valortraduc)
                {
                    case 1:
                        MessageBox.Show("Error there are empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        MessageBox.Show("Error existen campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                string Estado = cmbEstado.SelectedValue.ToString();
                int EstadoEntero = Convert.ToInt16(cmbEstado.SelectedValue);
                switch (EstadoEntero)
                {
                    case 1:
                        EstadoEntero = 1;
                        break;
                    case 3:
                        EstadoEntero = 3;
                        break;
                    default:
                        break;
                }
                if (Estado == "1")
                {
                    Estado = "Activo";
                }
                else if (Estado == "3")
                {
                    Estado = "Bloqueado";
                }
                objrecuperar.correo = txtCorreo.Text;
                objrecuperar.usuario = txtUsuario.Text;
                objrecuperar.documento = txtDoc.Text;
                objrecuperar.Estado = Estado;
                bool resultado  = objrecuperar.VerficarUsuario();
                if (resultado == true)
                {
                    List<string> Credenciales = new List<string>();

                    Credenciales = objrecuperar.Credenciales();
                    if (Credenciales != null)
                    {
                        txtVerfiNombre.Text = Credenciales[0];
                        txtVerfiApellido.Text = Credenciales[1];
                        txtVerfiUsuario.Text = Credenciales[2];
                        txtVerfiCorreo.Text = Credenciales[3];
                        txtVerfiDoc.Text = Credenciales[4];
                        txtVerfiCargo.Text = Credenciales[5];

                        pnlNoSoy.Enabled = true;
                        pnlSiSoy.Enabled = true;
                    }
                    else
                    {
                        pnlNoSoy.Enabled = false;
                        pnlSiSoy.Enabled = false;
                        switch (FrmLogIn.valortraduc)
                        {
                            case 1:
                                MessageBox.Show("Error, no user found with those specifications, check the data entered", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case 2:
                                MessageBox.Show("Error no se ha encontrado usuario con esas especificaciones, verifique los datos ingresados", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            default:
                                break;
                        }
                    }
                }
                else
                {
                    switch (FrmLogIn.valortraduc)
                    {
                        case 1:
                            MessageBox.Show("Error, no user found with those specifications, check the data entered", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 2:
                            MessageBox.Show("Error no se ha encontrado usuario con esas especificaciones, verifique los datos ingresados", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            break;
                    }
                    txtVerfiNombre.Clear();
                    txtVerfiApellido.Clear();
                    txtVerfiUsuario.Clear();
                    txtVerfiCorreo.Clear();
                    txtVerfiDoc.Clear();
                    txtVerfiCargo.Clear();
                    pnlNoSoy.Enabled = false;
                    pnlSiSoy.Enabled = false;
                }

            }
        }

        private void btnSiSoy_Click(object sender, EventArgs e)
        {
            if (txtVerfiNombre.Text.Trim() == "" || txtVerfiApellido.Text.Trim() == "" || txtVerfiUsuario.Text.Trim()== "" || txtVerfiDoc.Text.Trim() == "" || txtVerfiCorreo.Text.Trim() == "" || txtVerfiCargo.Text.Trim() =="")
            {

            }
            else
            {
                objrecuperar.usuario = txtUsuario.Text;
                objrecuperar.nuevaclave = Validacion.GetMD5("NewPassword123");
                bool respuesta = objrecuperar.ActualizarCredenciales();
                if (respuesta == true)
                {
                    switch (FrmLogIn.valortraduc)
                    {
                        case 1:
                            MessageBox.Show("The user was identified, the password has already been updated, the user has been unlocked and will now be redirected to log in. Remember the new password is NewPassword123", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 2:
                            MessageBox.Show("El usuario fue identificado, ya se le ha actualizado la contraseña, se ha desbloqueado el usuario y ahorita será redireccionado a iniciar sesión. Recuerde la nueva contraseña es NewPassword123", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        default:
                            break;
                    }
                    FrmLogIn login = new FrmLogIn();
                    login.Show();
                    this.Hide();
                }
                
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NombreUsuario(e);
        }

        private void txtDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmLogIn metodos = new FrmLogIn();
            metodos.Show();
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMétodosRecup back = new FrmMétodosRecup();
            back.Show();
            this.Hide();
        }

        private void FrmMetodo2_Load(object sender, EventArgs e)
        {
            switch (FrmLogIn.valortraduc)
            {
                case 1:
                    traducir();
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
        void traducir()
        {
            Usuario.Text = InglesRecupContraseña.lblUsuarioMet2;
            Correo.Text = InglesRecupContraseña.lblCorreo2Met2;
            Estado.Text = InglesRecupContraseña.lblEstadoMet2;
            lblNumDoc.Text = InglesRecupContraseña.lblNumDocMet2;
            lblVerificar.Text = InglesRecupContraseña.lblVerificarMet2;
            groupBox1.Text = InglesRecupContraseña.grbCredencialesMet2;
            label1.Text = InglesRecupContraseña.lblNombresMet2;
            label4.Text = InglesRecupContraseña.lblApellidosMet2;
            label5.Text = InglesRecupContraseña.lblUsuarioMet2;
            label6.Text = InglesRecupContraseña.lblCorreo2Met2;
            label7.Text = InglesRecupContraseña.lblNumDoc2Met2;
            label8.Text = InglesRecupContraseña.lblCargo2Met2;
            label9.Text = InglesRecupContraseña.lblNoUsuarioMet2;
            label10.Text = InglesRecupContraseña.lblSiUsuarioMet2;
        }
    }
}
