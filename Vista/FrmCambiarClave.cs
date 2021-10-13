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
    public partial class FrmCambiarClave : Form
    {
        public FrmCambiarClave(string pusuario)
        {
            InitializeComponent();
            usuario = pusuario;
            txtClaveAntigua.PasswordChar = '*';
            txtConfirmarClave.PasswordChar = '*';
            txtNuevaClave.PasswordChar = '*';
        }
        public FrmCambiarClave(string pusuario, int login)
        {
            InitializeComponent();
            usuario = pusuario;
            txtClaveAntigua.PasswordChar = '*';
            txtConfirmarClave.PasswordChar = '*';
            txtNuevaClave.PasswordChar = '*';
            loginBack = login;
        }

        public string usuario { get; set;}
        public int loginBack { get; set; }
        private void txtConfirmarClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNuevaClave.Text.Trim() == txtConfirmarClave.Text.Trim())
            {
                lblAdvertencia.Visible = true;
            }
            else if (txtNuevaClave.Text != txtConfirmarClave.Text)
            {
                lblAdvertencia.Visible = false;
            }
            else
            {
                lblAdvertencia.Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            valorcambiarclave = 1;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void ActualizarClave()
        {
            ControladorCambiarClave cambiarclave;

            if (txtClaveAntigua.Text.Trim() == "" || txtConfirmarClave.Text.Trim() == "" || txtNuevaClave.Text.Trim() == "")
            {
                if (loginBack == 1)
                {
                    switch (FrmLogIn.valortraduc)
                    {
                        case 1:
                            MessageBox.Show("There are empty fields, please fill them in, to continue the process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 2:
                            MessageBox.Show("Existen campos vacíos, porfavor llenelos, para continuar el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (FrmMain.valortraducir)
                    {
                        case 1:
                            MessageBox.Show("There are empty fields, please fill them in, to continue the process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 2:
                            MessageBox.Show("Existen campos vacíos, porfavor llenelos, para continuar el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            break;
                    }

                }
            }
            else
            {
                cambiarclave = new ControladorCambiarClave(usuario, Validacion.GetMD5(txtClaveAntigua.Text));
                if (ControladorCambiarClave.VerficarClave() == 1)
                {
                    if (txtNuevaClave.Text.Trim() != txtConfirmarClave.Text.Trim())
                    {
                        lblAdvertencia.Visible = true;
                        if (loginBack == 1 )
                        {
                            switch (FrmLogIn.valortraduc)
                            {
                                case 1:
                                    MessageBox.Show("Passwords do not match, please verify they are the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                case 2:
                                    MessageBox.Show("Las contraseñas no coinciden, porfavor verifique sean las mismas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (FrmMain.valortraducir)
                            {
                                case 1:
                                    MessageBox.Show("Passwords do not match, please verify they are the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                case 2:
                                    MessageBox.Show("Las contraseñas no coinciden, porfavor verifique sean las mismas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    else
                    {
                        cambiarclave = new ControladorCambiarClave(usuario, Validacion.GetMD5(txtClaveAntigua.Text), Validacion.GetMD5(txtNuevaClave.Text));
                        int respuesA = ControladorCambiarClave.CambiarClave();
                        if (respuesA == 1)
                        {
                            if (txtClaveAntigua.Text == "NewPassword123")
                            {
                                switch (loginBack)
                                {
                                    case 1://Biene del Login 
                                        switch (FrmLogIn.valortraduc)
                                        {
                                            case 1:
                                                MessageBox.Show("The process was completed correctly, now we will direct you to the login form", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                break;
                                            case 2:
                                                MessageBox.Show("El proceso se completo correctamente, ahorita lo direccionaremos al formulario de inicio de sesión", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                break;
                                            default:
                                                break;
                                        }
                                        break;
                                    default://Viene del formulario principal
                                        switch (FrmMain.valortraducir)
                                        {
                                            case 1:
                                                MessageBox.Show("The process was completed correctly, now we will direct you to the login form", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                break;
                                            case 2:
                                                MessageBox.Show("El proceso se completo correctamente, ahorita lo direccionaremos al formulario de inicio de sesión", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                break;
                                            default:
                                                break;
                                        }
                                        break;
                                }
                                FrmLogIn frminiciar = new FrmLogIn();
                                frminiciar.Show();
                                this.Hide();
                            }
                            else
                            {
                                this.Hide();
                                switch (loginBack)
                                {
                                    case 1:
                                        if (FrmLogIn.valortraduc == 1)
                                        {
                                            MessageBox.Show("The password has been changed successfully", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else if (FrmLogIn.valortraduc == 2)
                                        {
                                            MessageBox.Show("La contraseña se ha cambiado correctamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        break;
                                    default:
                                        if (FrmMain.valortraducir == 1)
                                        {
                                            MessageBox.Show("The password has been changed successfully", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else if (FrmMain.valortraducir == 2)
                                        {
                                            MessageBox.Show("La contraseña se ha cambiado correctamente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }

                                        break;
                                }
                                FrmMain main = new FrmMain();
                            }
                        }                                                
                    }
                }                
                else
                {
                    switch (loginBack)
                    {
                        case 1:
                            if (FrmLogIn.valortraduc == 1)
                            {
                                MessageBox.Show("The current password does not match the one entered into the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (FrmLogIn.valortraduc == 2)
                            {
                                MessageBox.Show("La contraseña actual no coincide con la que se ha ingresado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        default:
                            if (FrmMain.valortraducir == 1)
                            {
                                MessageBox.Show("The current password does not match the one entered into the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (FrmMain.valortraducir == 2)
                            {
                                MessageBox.Show("La contraseña actual no coincide con la que se ha ingresado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                    }
                }
            }
        }
        private void ckbMostrarClave_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMostrarClave.Checked == true)
            {
                txtClaveAntigua.PasswordChar = '\0';
                txtConfirmarClave.PasswordChar = '\0';
                txtNuevaClave.PasswordChar = '\0';
            }
            else if(ckbMostrarClave.Checked == false)
            {
                txtClaveAntigua.PasswordChar = '*';
                txtConfirmarClave.PasswordChar = '*';
                txtNuevaClave.PasswordChar = '*';
            }
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            ActualizarClave();
        }
        //Traducción
        private void FrmCambiarClave_Load(object sender, EventArgs e)
        {
            if (loginBack == 1)
            {
                switch (FrmLogIn.valortraduc)
                {
                    case 1:
                        label1.Text = InglesCambiarClave.label1;
                        label2.Text = InglesCambiarClave.label2;
                        label3.Text = InglesCambiarClave.label3;
                        label4.Text = InglesCambiarClave.label4;
                        lblAdvertencia.Text = InglesCambiarClave.labeladvertencia;
                        ckbMostrarClave.Text = InglesCambiarClave.chkbox1;
                        btnCambiarClave.Text = InglesCambiarClave.btnCambiarContrasena;
                        break;
                    default:
                        break;
                }

            }
            switch (FrmMain.valortraducir)
            {
                case 1:
                    label1.Text = InglesCambiarClave.label1;
                    label2.Text = InglesCambiarClave.label2;
                    label3.Text = InglesCambiarClave.label3;
                    label4.Text = InglesCambiarClave.label4;
                    lblAdvertencia.Text = InglesCambiarClave.labeladvertencia;
                    ckbMostrarClave.Text = InglesCambiarClave.chkbox1;
                    btnCambiarClave.Text = InglesCambiarClave.btnCambiarContrasena;
                    break;
                default:
                    break;
            }
            valorcambiarclave = 2;
        }
        public static int valorcambiarclave { get; set; }
    }
}
