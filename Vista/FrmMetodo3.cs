using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Controlador;
using System.Net.Mail;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmMetodo3 : Form
    {
        public FrmMetodo3()
        {
            InitializeComponent();
            CargarEstado();
           
        }

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
        //Paso 1: Verficar usuario
        void VerificarUsuario()
        {
            if (txtCorreo.Text.Trim() == "" || txtUsuario.Text.Trim() == "")
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
                string usuario, correo, estado;
                int estadoentero;
                usuario = txtUsuario.Text;
                correo = txtCorreo.Text;
                estadoentero = Convert.ToInt16(cmbEstado.SelectedValue);
                estado = cmbEstado.SelectedValue.ToString();
                switch (estadoentero)
                {
                    case 1:
                        estadoentero = 1;//Activo
                        break;
                    case 3:
                        estadoentero = 3;//Bloqueado
                        break;
                    default:
                        break;
                }
                if (estado == "1")
                {
                    estado = "Activo";
                }
                else if (estado == "3")
                {
                    estado = "Bloqueado";
                }
                bool encontrar =  ControladorRecuperar.VerficarUsuario(usuario, correo, estado);
                if (encontrar == true)
                {
                    List<string> Lista = new List<string>();
                    Lista = ControladorRecuperar.AgarraDatos(usuario, correo, estadoentero);
                    if (Lista != null)
                    {
                        txtVerfiNombre.Text = Lista[0];
                        txtVerfiApellido.Text = Lista[1];
                        txtVerfiUsuario.Text = Lista[2];
                        txtVerfiCorreo.Text = Lista[3];
                        txtVerfiDoc.Text = Lista[4];
                        txtVerfiCargo.Text = Lista[5];

                        pnlNoSoy.Enabled = true;
                        pnlEnviar.Enabled = true;
                    }
                    else
                    {
                        switch (FrmLogIn.valortraduc)
                        {
                            case 1:
                                MessageBox.Show("Error, user does not exist, check your username, email or activity status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case 2:
                                MessageBox.Show("Error, usuario no existente, verifique su nombre de usuario, correo o estado de actividad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            default:
                                break;
                        }
                    }
                }
                else
                {
                    if (FrmLogIn.valortraduc == 1)
                    {
                        MessageBox.Show("Error, user does not exist, check your username, email or activity status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (FrmLogIn.valortraduc == 2)
                    {
                        MessageBox.Show("Error, usuario no existente, verifique su nombre de usuario, correo o estado de actividad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtVerfiNombre.Clear();
                    txtVerfiApellido.Clear();
                    txtVerfiUsuario.Clear();
                    txtVerfiCorreo.Clear();
                    txtVerfiDoc.Clear();
                    txtVerfiCargo.Clear();
                }
            }
        }

        //Paso 2: Enviar mensaje 
        #region Por Mail
        const string usuario = "SoporteTecnicoVeterinaria@gmail.com";
        const string password = "@SoporteTecnico";
        void EnviarMensaje(StringBuilder Mensaje, DateTime fecha, string de, string para, string asunto, out string error)
        {
            error = "";
            try
            {
                Mensaje.Append(Environment.NewLine);
                switch (FrmLogIn.valortraduc)
                {
                    case 1:
                        Mensaje.Append(string.Format("This email has been send the day {0:yyyy/MM/dd} at {0:hh:mm:ss} Hours :\n\n", fecha));
                        break;
                    case 2:
                        Mensaje.Append(string.Format("Este correo ha sido enviar el dia {0:dd/MM/yyyy} a las {0:hh:mm:ss} Horas : \n\n", fecha));
                        break;
                    default:
                        break;
                }
                Mensaje.Append(Environment.NewLine);

                MailMessage mail = new MailMessage();
                //De parte de quien
                mail.From = new MailAddress(de);

                mail.To.Add(para);

                mail.Subject = asunto;

                mail.Body = Convert.ToString(Mensaje);
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                smtp.Port = 587;

                smtp.UseDefaultCredentials = false;

                smtp.Credentials = new System.Net.NetworkCredential(usuario, password);
                smtp.EnableSsl = true;
                smtp.Send(mail);

                error = "Exíto";
                DialogResult drq;
                FrmLogIn login;
                switch (FrmLogIn.valortraduc)
                {
                    case 1:
                        drq= MessageBox.Show("A message has been sent to your email, notification of password change, do you want to continue with the process?", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Question);                                               
                          ActualizarContrasena();
                          login = new FrmLogIn();
                          login.Show();
                          this.Hide();                      
                        break;
                    case 2:
                        drq= MessageBox.Show("Se ha enviado un mensaje a tú correo, de notificación de cambio de contraseña, ¿Deseás continuar con el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);                        
                            ActualizarContrasena();
                            login = new FrmLogIn();
                            login.Show();
                            this.Hide();                                                                
                        break;
                    default:
                        break;
                }
                   
            }
            catch (Exception a)
            {
                error = "Error " + a.Message;
                MessageBox.Show(error);
                return;
            }
        }
        #endregion 
        private void btnVerficar_Click(object sender, EventArgs e)
        {
            VerificarUsuario();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            #region    
            string clavedefecto, error, asunto, cuerpo, para;
            clavedefecto = "NewPassword123";
            error = "";
            para = txtCorreo.Text;
            StringBuilder msg;
            switch (FrmLogIn.valortraduc)
            {
                case 1:
                    asunto = "Password reset notification";
                    cuerpo = "Hi " + txtUsuario.Text + ", We are in the process of resetting your password, remember that the default password is " + clavedefecto + " you must enter that password when logging in and then continue with the process";
                    msg = new StringBuilder();
                    msg.Append(cuerpo);
                    EnviarMensaje(msg, DateTime.Now, usuario, para, asunto, out error);
                    break;
                case 2:
                    asunto = "Notificación de restablecimiento de contraseña";
                    cuerpo = "Hola " + txtUsuario.Text + ", Estamos en proceso de restablecer tú contraseña, recuerda que la contraseña por defecto es " + clavedefecto + " deberas ingresar esa contraseña al iniciar sesión y despúes seguir con el proceso";
                    msg = new StringBuilder();
                    msg.Append(cuerpo);
                    EnviarMensaje(msg, DateTime.Now, usuario, para, asunto, out error);

                    break;
                default:
                    break;
            }
            #endregion

            #region Por Mail otra vez xd

            //string para = txtCorreo.Text;
            //string clavedefecto = "NewPassword123";
            //string asunto = "Notificación de restablecimiento de contraseña";
            //string cuerpo = "Hola " + txtUsuario.Text + " Estamos en proceso de restablecer tú contraseña, recuerda que la contraseña por defecto es " + clavedefecto + " deberas ingresar esa contraseña al iniciar sesión y despúes seguir con el proceso";
            //try
            //{
            //    MailMessage mail = new MailMessage(usuario, para, asunto, cuerpo);
            //    mail.IsBodyHtml = true;

            //    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            //    smtp.EnableSsl = true;
            //    smtp.UseDefaultCredentials = false;
            //    smtp.Port = 587;
            //    smtp.Credentials = new System.Net.NetworkCredential(usuario, password);

            //    smtp.Send(mail);
            //    smtp.Dispose();
            //    ActualizarContrasena();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("a");
            //}



            #endregion
        }

        //Paso 3: Actualizar contraseña
        void ActualizarContrasena()
        {
            int solu =  ControladorRecuperar.ActualizarContrasena(txtUsuario.Text, Validacion.GetMD5("NewPassword123"));
            if (solu == 1)
            {
                  LimpiarCampos();
            }
            else
            {
                switch (FrmLogIn.valortraduc)
                {
                  case 1:
                      MessageBox.Show("Failed to change password, check with administrator", "Critical error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                  case 2:
                       MessageBox.Show("Error al cambiar la contraseña, consulte con administrador", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         break;
                  default:
                         break;
                    }
                }
         }        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogIn metodos = new FrmLogIn();
            metodos.Show();
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

        private void FrmMetodo3_Load(object sender, EventArgs e)
        {
            switch (FrmLogIn.valortraduc)
            {
                case 1:
                    label1.Text = InglesRecupContraseña.lblNombreUsuMet3;
                    label2.Text = InglesRecupContraseña.lblCorreoMet3;
                    label3.Text = InglesRecupContraseña.lblEstadoMet3;
                    groupBox1.Text = InglesRecupContraseña.grbCredencialesMet3;
                    label4.Text = InglesRecupContraseña.lblNombreMet3;
                    label5.Text = InglesRecupContraseña.lblApellidosMet3;
                    labe.Text = InglesRecupContraseña.lblUsuarioMet3;
                    label6.Text = InglesRecupContraseña.lblCorreo2Met3;
                    label7.Text = InglesRecupContraseña.lblNumDocMet3;
                    label8.Text = InglesRecupContraseña.lblCargoMet3;
                    label9.Text = InglesRecupContraseña.lblNoUsuarioMet3;
                    labelEnviar.Text = InglesRecupContraseña.lblEnviarCorreoMet3;
                    label11.Text = InglesRecupContraseña.lblVerificarMet3;
                    break;
                default:
                    break;
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
    }
}
