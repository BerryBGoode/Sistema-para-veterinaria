using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using Controlador;

namespace Vista
{
    public partial class FrmMain : Form
    {
        public FrmMain(string nombre, string apellidos)
        {
            InitializeComponent();
            lblDatosEmpleado.Text =  nombre+ " " + apellidos;
        }
        public FrmMain()
        {
            InitializeComponent();
        }
        
        FrmConsultas frmconsulta = new FrmConsultas();

        void Nivelsdeusuario()
        {
            switch (ControladorLogIn.tipousuario)
            {
                case 1://Root
                    lblUsuarioDatos.Text = "Gerente";
                    //No se bloquea nada
                    break;
                case 2://Administrador de empleados
                    lblUsuarioDatos.Text = "Administrador de empleados";
                    btnConsultas.Visible = false;
                    btnFactura.Visible = false;
                    btnPerros.Visible = false;
                    btnPropietarios.Visible = false;
                    break;                            
                case 3://Especialista
                    btnEmpleados.Visible = false;
                    btnFactura.Visible = false;
                    lblUsuarioDatos.Text = "Especialista";
                    break;
                case 4://Secretario
                    lblUsuarioDatos.Text = "Secretario/a";
                    btnEmpleados.Visible = false;
                    btnFactura.Visible = false;
                    break;
                case 5://Cajero
                    lblUsuarioDatos.Text = "Cajero/a";
                    btnPerros.Visible = false;
                    btnEmpleados.Visible = false;
                    btnPropietarios.Visible = false;
                    btnExpediente.Visible = false;
                    btnFactura.Visible = true;
                    break;
                default:
                    break;
            }
        }

        //Barra de tareas
        void PersonaizarPnl()
        {
            pnlEmpleados.Visible = false;
            pnlConsulta.Visible = false;
        }
        void ocultarPnl()
        {
          
            if (pnlConsulta.Visible == true)
            {
                pnlConsulta.Visible = false;
            }

            if (pnlEmpleados.Visible == true)
            {
                pnlEmpleados.Visible = false;
            }

        }
        void MostrarPnl(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarPnl();//Ocultar submenu, si hay uno abierto
                submenu.Visible = true;
            }//pero si hay un submenu abierto, se vuelve a ocultar el submenu
            else
            {
                submenu.Visible = false;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            traducir();
            Nivelsdeusuario();
            PersonaizarPnl();
            FrmMiCuenta.valor = 1;
            FrmMainExpediente.valorexpediente = 1;
            FrmCambiarClave.valorcambiarclave = 1;
        }

        ControladorLogIn ab = new ControladorLogIn();
        #region Función de la barra superior
        //Función de la barra superior
        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("yyyy/MM/dd");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult drp;
            switch (valortraducir)
            {
                case 1:
                    drp = MessageBox.Show("You want to log out?", "Notificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drp == DialogResult.Yes)
                    {
                        FrmLogIn iniciar = new FrmLogIn();
                        iniciar.Show();
                        this.Hide();
                        FrmMostarConsultas mostrar1 = new FrmMostarConsultas();
                        mostrar1.Hide();
                    }
                    break;
                case 2:
                    drp = MessageBox.Show("¿Desea cerrar sesión?","Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drp == DialogResult.Yes)
                    {
                        FrmLogIn iniciar = new FrmLogIn();
                        iniciar.Show();
                        this.Hide();
                        FrmMostarConsultas mostrar1 = new FrmMostarConsultas();
                        mostrar1.Hide();
                    }

                    break;
                default:
                    break;
            }
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //this.Size = new Size(1310, 766);
            //this.Location = new Point();
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;//Cuando se ejecute el evento click en "btnRestaurar" se va a poder ver el "btnMaximizar"
            btnRestaurar.Visible = false;// y este no se va a ver
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false; //Cuando se ejecute el evento click al "btnMaximizar" este boton se va a ser invisible
            btnRestaurar.Visible = true;// y se va a ser visible el "btnRestuarar"
            
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Este código funciona para minimizar la ventana del programa
        }
        void botones()
        {
            //El método botones funciona para cuando la "talla" del formulario cambia de mostrar el "btnRestuarar" a mostrar el "btnMaximizar"
            if (WindowState == FormWindowState.Maximized)
            {
                btnRestaurar.Visible = true;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                btnRestaurar.Visible = false;
                btnMaximizar.Visible = true;
            }
        }
        //Funcion para que la barra superior se pueda movilizar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            //Con el evento "SizeChanged" se llama el metódo "botones"
            botones();
        }
        #endregion

        //Lamara un formulario al panel principal
        public Form currentForm;
        public void AbrirForm<MiFrm>() where MiFrm : Form, new() //se crea un método privado, esté se va a ejecutas cuando el formulario erede al formulario que se va a llamar, como parametro, tiene a un objeto de tipo Form
        {
            Form OpenForm;
            OpenForm = pnlMain.Controls.OfType<MiFrm>().FirstOrDefault();
            if (OpenForm == null)//si el frm está vacio
            {
                OpenForm = new MiFrm(); //se va a abrir un nuevo "MiFrm"
                OpenForm.TopLevel = false;
                OpenForm.FormBorderStyle = FormBorderStyle.None;//no tiene un estilo de borde
                OpenForm.Dock = DockStyle.Fill;//este nuevo frm va a estár rellenando el pnl en el que se va a mostrar
                if (currentForm != null )//si hay otro frm en el panel
                {
                    currentForm.Close();//el frm se va a cerrar
                    pnlMain.Controls.Remove(currentForm);//el frm se va a mover
                }
                currentForm = OpenForm;//entonces el formulario nuevo va a ser el igual que el anterior
                pnlMain.Controls.Add(OpenForm);//en el pnl va a mostrar ese nuevo frm
                pnlMain.Tag = OpenForm;
                OpenForm.Show(); //se va a mostrar el nuevo formulario
                OpenForm.BringToFront();
            }
            else
            {
                OpenForm.BringToFront();
            }
        }
        public void btnInicio_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = true;
        }
        //Conexion
        public void conexion()
        {
            MySqlConnection valor = ControladorConexion.connection();//se crea una variable de tipo "mysqlconnection" y se le asigna un valor procediente de el "ControladorConexion"
            if (valor == null)
            {
                MessageBox.Show("Error al establecer conexion con la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        ControladorLogIn Datos = new ControladorLogIn();
        //Mostrar submenus
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            MostrarPnl(pnlEmpleados);
        }
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            MostrarPnl(pnlConsulta);
        }



        //Mostrar formulario
        private void btnEmpleados_DoubleClick(object sender, EventArgs e)
        {
            AbrirForm<FrmEmpleados>();
        }
        private void btnConsultas_DoubleClick(object sender, EventArgs e)
        {
            AbrirForm<FrmConsultas>();
        }
        private void btnUsuario_DoubleClick(object sender, EventArgs e)
        {
            AbrirForm<FrmUsuarios>();
            ocultarPnl();
        }
        private void btnPropietarios_DoubleClick(object sender, EventArgs e)
        {
            AbrirForm<FrmPropietarios>();
        }
        private void btnPerros_DoubleClick(object sender, EventArgs e)
        {
            AbrirForm<FrmPerros>();
        }
        private void btnExpediente_DoubleClick(object sender, EventArgs e)
        {
            switch (FrmMainExpediente.valorexpediente)
            {
                case 1:
                    FrmMainExpediente frmexpediente = new FrmMainExpediente();
                    frmexpediente.Show();
                    ocultarPnl();
                    break;
                default:
                    break;
            }
        }
        private void btnFactura_DoubleClick(object sender, EventArgs e)
        {
            AbrirForm<FrmFactura>();
            ocultarPnl();
        }



        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            switch (FrmCambiarClave.valorcambiarclave)
            {
                case 1:
                    FrmCambiarClave cambiarclave = new FrmCambiarClave(AtributoLogin.usuario);
                    cambiarclave.Show();
                    break;
                default:
                    break;
            }
        }
        public void traducir()
        {
            if (rbtnIngles.Checked == true)
            {
                valortraducir = 1;
                label1.Text = InglesMain.lblBienvenidos;
                label2.Text = "Languages";
                label3.Text = InglesMain.lblCargo;
                label7.Text = InglesMain.lblCambiarContra;
                btnEmpleados.Text = InglesMain.btnEmpleados;
                btnUsuario.Text = InglesMain.btnUsuario;
                btnPropietarios.Text = InglesMain.btnPropietarios;
                btnPerros.Text = InglesMain.btnPerros;
                btnConsultas.Text = InglesMain.btnConsultas;
                btnExpediente.Text = InglesMain.btnExpediente;
                btnFactura.Text = InglesMain.btnFactura;
                groupBox1.Text = "Settings";
                label4.Text = "Account";
                label5.Text = "My account";

                lblUsuarioDatos.Location = new Point(268, 94);
                switch (ControladorLogIn.tipousuario)
                {
                    case 1:
                        lblUsuarioDatos.Text = "Manager";
                        break;
                    case 2:
                        lblUsuarioDatos.Text = "Employee manager";
                        break;
                    case 3:
                        lblUsuarioDatos.Text = "Expert";
                        break;
                    case 4:
                        lblUsuarioDatos.Text = "Secretary";
                        break;
                    case 5:
                        lblUsuarioDatos.Text = "Cashier";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                valortraducir = 2;//Español
                label1.Text = EspañolMain.lblBienvenidos;
                label2.Text = "Lenguajes";
                label3.Text = EspañolMain.lblCargo;
                label7.Text = EspañolMain.lblCambiarContra;
                btnEmpleados.Text = EspañolMain.btnEmpleados;
                btnUsuario.Text = EspañolMain.btnUsuario;
                btnPropietarios.Text = EspañolMain.btnPropietarios;
                btnPerros.Text = EspañolMain.btnPerros;
                btnConsultas.Text = EspañolMain.btnConsultas;
                btnExpediente.Text = EspañolMain.btnExpediente;
                btnFactura.Text = EspañolMain.btnFactura;
                groupBox1.Text = "Ajustes";
                label4.Text = "Cuenta";
                label5.Text = "Mi cuenta";

                lblUsuarioDatos.Location = new Point(200, 94);
                switch (ControladorLogIn.tipousuario)
                {
                    case 1:
                        lblUsuarioDatos.Text = "Gerente";
                        break;
                    case 2:
                        lblUsuarioDatos.Text = "Administrador de empleados";
                        break;
                    case 3:
                        lblUsuarioDatos.Text = "Especialista";
                        break;
                    case 4:
                        lblUsuarioDatos.Text = "Secretario/a";
                        break;
                    case 5:
                        lblUsuarioDatos.Text = "Especialista";
                        break;
                    default:
                        break;
                }

            }
        }
        public static int valortraducir { get; set; }

        private void rbtnIngles_CheckedChanged(object sender, EventArgs e)
        {
            traducir();
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            switch (FrmMiCuenta.valor)
            {
                case 1:
                    FrmMiCuenta cuenta = new FrmMiCuenta();
                    cuenta.Show();
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
