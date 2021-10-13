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
using System.Runtime.InteropServices;
using System.IO;

namespace Vista
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
            a = new FrmMain();
            a.conexion();
        }
        FrmMain a;
        ControladorLogIn ab = new ControladorLogIn();

        void NotificacionAcceso()
        {
            notify.Icon = new System.Drawing.Icon(Path.GetFullPath(@"../../Resources/Logo.ico"));
            notify.Text = "Sistema Iniciado";
            notify.Visible = true;
            notify.BalloonTipTitle = "Bienvenido";
            notify.BalloonTipText = "Bienvenido " + txtUsuario.Text + " al sistema";
            notify.ShowBalloonTip(100);
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {           
                lblAdvertencia1.Visible = false;            
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {                
                lblAdvertencia1.Visible = true;

            }
            else
            {
                lblAdvertencia1.Visible = false;
            }
        }
        private void txtClave_Enter_1(object sender, EventArgs e)
        {
            lblAdveterncia2.Visible = false;
        }
        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text.Trim() == "")
            {
                lblAdveterncia2.Visible = true;
            }
            else
            {
                lblAdveterncia2.Visible = false;
            }
        }
        private void lklingresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtClave.Text.Trim() == "" || txtUsuario.Text.Trim() == "")//Con el if se evalua si los controles del formulario están vacios, si es cierto se va a ejecutar un mensaje donde diga que hay campos vacíos
            {
                if (rbtnEspañol.Checked == true)
                {
                    MessageBox.Show("Existen campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rbtnIngles.Checked == true)
                {
                    MessageBox.Show("There are empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else//si no el forulario principal de se va a abrir, y se va a cerrar el de "LogIn", pero hay que validar que sean datos validos existentes
            {
                EvaluarDatos();   
            }
        }
        void EvaluarDatos()
        {
            ab.clave = Validacion.GetMD5(txtClave.Text);
            ab.usuario = txtUsuario.Text;
            int respuesta = ab.AccesoLogIn();
            if (respuesta == 1)
            {
                //IF para ver si tiene clave por defecto
                if (txtClave.Text == "NewPassword123")
                {
                    if (rbtnEspañol.Checked == true)
                    {
                        MessageBox.Show("Se detecto que " + txtUsuario.Text + " tienes una clave por defecto, así que lo direccionaremos al formulario de cambiar contraseña", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (rbtnIngles.Checked == true)
                    {
                        MessageBox.Show("It was detected that " + txtUsuario.Text + " you have a default password, so we will direct you to the change password form", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    FrmCambiarClave frmCambiarClave = new FrmCambiarClave(txtUsuario.Text, 1);
                    frmCambiarClave.Show();
                    this.Hide();
                }
                else
                {
                   List<string> listadatos = new List<string>();
                   listadatos = ab.EncontrarDatosUsuario();
                   if (listadatos != null)
                   {                                            
                        ab.idempleado = int.Parse(listadatos[0]);
                        ab.nombres = listadatos[1];
                        ab.apellidos = listadatos[2];
                        //Credenciales para no eliminar al empleado que ingrese al sistema
                        AtributosCredenciales.nombre = listadatos[1];
                        AtributosCredenciales.Apellidos = listadatos[2];
                        AtributosCredenciales.ID = Convert.ToInt16(listadatos[0]);
                        AtributosCredenciales.UsuarioVerif = txtUsuario.Text;
                        if (rbtnEspañol.Checked == true)
                        {
                            MessageBox.Show("Bienvenido " + txtUsuario.Text + " al sistema", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (rbtnIngles.Checked == true)
                        {
                            MessageBox.Show("Welcome " + txtUsuario.Text + " to the system", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        ControladorLogIn.tipousuario = Convert.ToInt16(listadatos[3]);
                        //NotificacionAcceso();
                        AtributoLogin.usuario = txtUsuario.Text;
                        a = new FrmMain(listadatos[1], listadatos[2]);
                        DatosCuenta();
                        a.Show();
                        this.Hide();                      
                    }
                    else
                    {
                        if (rbtnEspañol.Checked ==true)
                        {
                           MessageBox.Show("Error al encontrar usuario, consulte con un administrador", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (rbtnIngles.Checked == true)
                        {
                            MessageBox.Show("Failed to find user, consult an administrator", "Criticar error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
            {
                string usuario = txtUsuario.Text;
                string clave = Validacion.GetMD5(txtClave.Text);
                ControladorLogIn objLogin = new ControladorLogIn();            
                if (objLogin.IntetosVerif(usuario, clave) == 1)
                {
                    if (rbtnEspañol.Checked == true)
                    {
                        MessageBox.Show("Acceso denegado, usuario o contraseña incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (rbtnIngles.Checked == true)
                    {
                        MessageBox.Show("Access Denied, Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (rbtnEspañol.Checked == true)
                    {
                        MessageBox.Show("Acceso denegado, usuario no existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (rbtnIngles.Checked == true)
                    {
                        MessageBox.Show("Access denied, user does not exist", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
                    }
                }
            }

            
        }  
        void DatosCuenta()
        {
            ab.usuario = txtUsuario.Text;
            List<string> Lista = new List<string>();
            Lista = ab.Cargarlista();
            if (Lista != null)
            {
                AtributosCuenta.nombre = Lista[0];
                AtributosCuenta.apellidos = Lista[1];
                AtributosCuenta.documento = Lista[2];
                AtributosCuenta.cargo = Lista[3];
                AtributosCuenta.usuario = Lista[4];
                AtributosCuenta.correo = Lista[5];
            }
        }
        #region Función de la barra superior
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            MostraContrasena();
            valortraduc = 2;
        }

        private void chkContraseña_CheckedChanged(object sender, EventArgs e)
        {
            MostraContrasena();
        }
        void MostraContrasena()
        {
            if (chkContraseña.Checked == false)
            {
                txtClave.PasswordChar = '*';
            }
            else
            {
                txtClave.PasswordChar = '\0';
            }
        }

        private void lklRestablecer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblAdvertencia1.Visible = false;
            lblAdveterncia2.Visible = false;
            FrmMétodosRecup frmRecuperacion = new FrmMétodosRecup();
            frmRecuperacion.Show();
            this.Hide();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clave(e);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NombreUsuario(e);   
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {           
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.V))
            {
                txtUsuario.Clear();
            }            
        }
        void Traducir()
        {
            if (rbtnIngles.Checked == true)
            {
                lblContraseña.Text = InglesLogin.lblContraseña;
                lblNombreUsuario.Text = InglesLogin.lblNombreUsuario;
                lblAdveterncia2.Text = InglesLogin.lblAdveterncia2;
                lblAdvertencia1.Text = InglesLogin.lblAdvertencia1;
                chkContraseña.Text = InglesLogin.chkContraseña;
                lklingresar.Text = InglesLogin.lklingresar;
                lklRestablecer.Text = InglesLogin.lklRestablecer;
                rbtnEspañol.Text = InglesLogin.chkTraducirLogin;
                rbtnIngles.Text = "English";
                valortraduc = 1;
            }
            else
            {
                lblContraseña.Text = "Contraseña:";
                lblNombreUsuario.Text = "Nombre de usuario:";
                lblAdveterncia2.Text = "*Ingrese su contraseña*";
                lblAdvertencia1.Text = "*Ingrese su nombre de usuario*";
                chkContraseña.Text = "Mostrar contraseña";
                lklingresar.Text = "Iniciar sesión";
                lklRestablecer.Text = "¿Has olvidado la contraseña?";
                rbtnIngles.Text = "Ingles";
                rbtnEspañol.Text = "Español";
                valortraduc = 2;
            }
        }
        public static int valortraduc { get; set; }
        private void rbtnIngles_CheckedChanged(object sender, EventArgs e)
        {
            Traducir();
        }

        private void rbtnEspañol_CheckedChanged(object sender, EventArgs e)
        {
            Traducir();
        }
    }
}
