using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Controlador;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmMiCuenta : Form
    {
        public FrmMiCuenta()
        {
            InitializeComponent();
            cargar();
        }
        void cargar()
        {
            txtNombres.Text = AtributosCuenta.nombre;
            txtApellidos.Text = AtributosCuenta.apellidos;
            txtDocumento.Text = AtributosCuenta.documento;
            txtCargo.Text = AtributosCuenta.cargo;
            txtUsername.Text = AtributosCuenta.usuario;
            txtCorreo.Text = AtributosCuenta.correo;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            valor = 1;
            FrmMain main = new FrmMain();
            main.Show();
        }
        public static int valor { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void FrmMiCuenta_Load(object sender, EventArgs e)
        {
            valor = 2;
            switch (FrmMain.valortraducir)
            {
                case 1:
                    Traducir();
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void chkModificar_CheckedChanged(object sender, EventArgs e)
        {
            chkModificar.Visible = false;
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtCargo.Enabled = false;
            txtCorreo.Enabled = true;
            txtDocumento.Enabled = true;
            txtUsername.Enabled = true;
            pnlActualizar.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ControladorMiCuenta.nombre = txtNombres.Text;
            ControladorMiCuenta.apellido = txtApellidos.Text;
            ControladorMiCuenta.documento = txtDocumento.Text;
            ControladorMiCuenta.usuario = txtUsername.Text;
            ControladorMiCuenta.correo = txtCorreo.Text;
            if (txtCorreo.Text != AtributosCuenta.correo)
            {
                switch (FrmMain.valortraducir)
                {
                    case 1:
                        MessageBox.Show("Remember to activate the settings of your gmail account, activate the option of ACCESS TO LESS SECURE APPS, in order to send a message to the mail and this process does not generate conflicts", "important announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 2:
                        MessageBox.Show("Recuerde activa en ajustes de su cuenta de gmail, active la opción de ACCESO A APPS MENOS SEGURAS, para así poder enviar mensaje al correo y este proceso no genere conflictos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    default:
                        break;
                }
            }
            if (ControladorMiCuenta.ActualizarUsuario() == 1)
            {
                if (ControladorMiCuenta.ActualizarEmpleado() == true)
                {
                    chkModificar.Visible = true;
                    txtNombres.Enabled = false;
                    txtApellidos.Enabled = false;
                    txtCargo.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtDocumento.Enabled = false;
                    txtUsername.Enabled = false;
                    pnlActualizar.Visible = false;
                    switch (FrmMain.valortraducir)
                    {
                        case 1:
                            MessageBox.Show("Then you will be redirected to log in, enter with your new data", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case 2:
                            MessageBox.Show("A Continuación serás redireccionado a iniciar sesión, ingresa con tus nuevos datos", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        default:
                            break;
                    }
                    FrmLogIn login = new FrmLogIn();
                    this.Hide();
                    login.Show();
                }
            }
        }
        void Traducir()
        {
            label1.Text = "Your account";
            label3.Text = "Personal information";
            label2.Text = "Your account details";
            label4.Text = "Names";
            label5.Text = "Last names";
            label6.Text = InglesEmpleados.lblNumDocEmp;
            label7.Text = "Work position";
            label8.Text = "Username";
            label9.Text = "Adress gmail";
            lblActualizar.Text = InglesUsuario.lblActualizar;
            chkModificar.Text = "Modify data";
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
