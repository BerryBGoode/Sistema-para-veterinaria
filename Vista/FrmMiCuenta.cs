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
        }
        public static int valor { get; set; }

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
    }
}
