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
    public partial class FrmMetodo1 : Form
    {
        public FrmMetodo1()
        {
            InitializeComponent();
            CargarTipoUsuario();
        }
        ControladorRecuperar objRecup = new ControladorRecuperar();

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogIn frmlogin = new FrmLogIn();
            frmlogin.Show();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void CargarTipoUsuario()
        {
            cmbTipoUser.DataSource = ControladorRecuperar.CargarTipoUser();
            cmbTipoUser.DisplayMember = "tipoUsuario";
            cmbTipoUser.ValueMember = "idtipoUsuario";
        }
        void VerificarAdmin()
        {
            if (txtClaveAdmin.Text.Trim() != "" || txtCorreoAdmin.Text.Trim() != "" || txtUsuarioAdmin.Text.Trim() != "")
            {
                //Asignando valores a los atributos
                //Credenciales del admin
                objRecup.UsuarioAdmin = txtUsuarioAdmin.Text;
                objRecup.CorreoAdmin = txtCorreoAdmin.Text;
                objRecup.ClaveAdmin = Validacion.GetMD5(txtClaveAdmin.Text);
                objRecup.tipouser = Convert.ToInt16(cmbTipoUser.SelectedValue);
                int respuesta = objRecup.ValidarAdmind();
                if (respuesta >= 1)
                {
                    txtUsuarioBloq.Enabled = true;
                    txtCorreBloq.Enabled = true;
                    txtDocBloq.Enabled = true;
                    btnRecuperar.Enabled = true;

                    txtUsuarioAdmin.Enabled = false;
                    txtCorreoAdmin.Enabled = false;
                    txtClaveAdmin.Enabled = false;
                    cmbTipoUser.Enabled = false;
                    btnVerficarAdmin.Enabled = false;
                }
                else
                {
                    switch (FrmLogIn.valortraduc)
                    {
                        case 1:
                            MessageBox.Show("Invalid user, there is probably a wrong data, or this administrator may be blocked, or he may not be an administrator.", "Error en las credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 2:
                            MessageBox.Show("Usuario invalido, probablemente exista un dato erroneo, o puede que este administrador este bloqueado, o también pueda que no sea administrador.", "Error en las credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            break;
                    }
                }

            }

        }//Mejorar el código de estos 2 métodos verificarAdmin y recuperar
        void Recuperar()
        {
            if (txtUsuarioBloq.Text.Trim() == "" || txtCorreBloq.Text.Trim() == "" || txtDocBloq.Text.Trim() == "")
            {

            }
            else
            {
                //Credenciales del usuario bloqueado
                objRecup.UsuarioBloqueado = txtUsuarioBloq.Text;
                objRecup.CorreoBloqueado = txtCorreBloq.Text;
                objRecup.DocumentoBloquedo = txtDocBloq.Text;
                string newclave = "NewPassword123";
                int respuestaRecuperar = objRecup.RecuperarUsuario(Validacion.GetMD5(newclave));
                if (respuestaRecuperar == 1)
                {
                    switch (FrmLogIn.valortraduc)
                    {
                        case 1:
                            MessageBox.Show("The user has already been successfully recovered, now what proceeds is to change the password, Remember that the default password is NewPassword123", "Notificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            break;
                        case 2:
                            MessageBox.Show("El usuario ya se ha recuperado correctamente, ahorita lo que procede es ir a cambiar contraseña, Recuerde que clave por defecto es NewPassword123", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            break;
                        default:
                            break;
                    }
                    FrmLogIn login = new FrmLogIn();
                    login.Show();
                }
            }
        }

        private void btnVerficarAdmin_Click(object sender, EventArgs e)
        {
            VerificarAdmin();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            Recuperar();
        }

        private void txtUsuarioAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NombreUsuario(e);
        }

        private void txtClaveAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clave(e);
        }

        private void txtUsuarioBloq_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NombreUsuario(e);
        }

        private void txtDocBloq_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMétodosRecup back = new FrmMétodosRecup();
            back.Show();
            this.Hide();
        }

        private void FrmMetodo1_Load(object sender, EventArgs e)
        {
            switch (FrmLogIn.valortraduc)
            {
                case 1:
                    TraducirIngles();
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
        void TraducirIngles()
        {
            groupBox1.Text = InglesRecupContraseña.grbCredencialAdmin;
            label1.Text = InglesRecupContraseña.lblUsuarioAdmin;
            label2.Text = InglesRecupContraseña.lblCorreoAdmin;
            label3.Text = InglesRecupContraseña.lblContraseñaAdmin;
            label4.Text = InglesRecupContraseña.lblTipoUserAdmin;
            label5.Text = InglesRecupContraseña.lblNombreUsuarioBloqueado;
            label6.Text = InglesRecupContraseña.lblCorreoUsuarioBloqueado;
            label7.Text = InglesRecupContraseña.lblDocumentoUsuarioBloqueado;

            groupBox1.Text = InglesRecupContraseña.grbCredencialAdmin;
            groupBox2.Text = InglesRecupContraseña.grbCredencialUsuario;
            btnVerficarAdmin.Text = InglesRecupContraseña.btnVerficarAdmin;
            btnRecuperar.Text = InglesRecupContraseña.btnRecuperarUsuarioAdmin;
        }
    }
}
