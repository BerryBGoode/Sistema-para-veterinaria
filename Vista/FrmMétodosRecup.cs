using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmMétodosRecup : Form
    {
        public FrmMétodosRecup()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogIn FrmAcceso = new FrmLogIn();
            FrmAcceso.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            FrmMetodo1 Metodo1 = new FrmMetodo1();
            Metodo1.Show();
            this.Hide();
        }
        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            FrmMetodo2 metodo2 = new FrmMetodo2();
            metodo2.Show();
            this.Hide();
        }
        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            FrmMetodo3 metodo3 = new FrmMetodo3();
            metodo3.Show();
            this.Hide();
        }

        private void FrmMétodosRecup_Load(object sender, EventArgs e)
        {
            switch (FrmLogIn.valortraduc)
            {
                case 1:
                    label1.Text = InglesRecupContraseña.lblmetodo1;
                    label2.Text = InglesRecupContraseña.lblmetodo3;
                    label3.Text = InglesRecupContraseña.lblmetodo2;
                    toolStripLabel1.Text = InglesRecupContraseña.tslMetodosRecuperacion;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
