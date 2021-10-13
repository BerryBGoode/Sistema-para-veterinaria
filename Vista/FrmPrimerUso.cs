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
    public partial class FrmPrimerUso : Form
    {
        public FrmPrimerUso()
        {
            InitializeComponent();
        }

        private void btnPrimerUso_Click(object sender, EventArgs e)
        {
            this.Hide();
            int respuesta = ControladorPrimerUso.EncontrarEmpleado();
            if (respuesta == 1)
            {
                FrmPrimerUsuario primerusuario = new FrmPrimerUsuario();
                primerusuario.Show();
            }
            else if (respuesta == 0)
            {
                FrmPrimerEmpleado primerempleado = new FrmPrimerEmpleado();
                primerempleado.Show();
            }
        }
        public static int valortraducir { get; set; }
        void Traducir()
        {
            if (rbtnIngles.Checked == true)
            {
                btnPrimerUso.LabelText = InglesPrimerUso.btnPrimerUso;
                lblHolaPrimerUso.Text = InglesPrimerUso.lblHolaPrimerUso;
                lblContextoPrimerUso.Text = InglesPrimerUso.lblContextoPrimerUso;
                lblAccederPrimerUso.Text = InglesPrimerUso.lblAccederPrimerUso;
                valortraducir = 1;
            }
            else
            {
                btnPrimerUso.LabelText = EspañolPrimerUso.btnPrimerUso;
                lblHolaPrimerUso.Text = EspañolPrimerUso.lblHolaPrimerUso;
                lblContextoPrimerUso.Text = EspañolPrimerUso.lblContextoPrimerUso;
                lblAccederPrimerUso.Text = EspañolPrimerUso.lblAccederPrimerUso;
                valortraducir = 2;
            }
        

        }
        private void FrmPrimerUso_Load(object sender, EventArgs e)
        {
            Traducir();
        }

        private void rbtnIngles_CheckedChanged(object sender, EventArgs e)
        {
            Traducir();
        }

        private void rbtnEspanol_CheckedChanged(object sender, EventArgs e)
        {
            Traducir();
        }
    }
}
