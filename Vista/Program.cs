using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int respuesta = ControladorPrimerUso.EncontrarUsuario();
            if (respuesta >= 1)
            {
                Application.Run(new FrmLogIn());
            }
            else if (respuesta == 0)
            {
                int respuesta2 = ControladorPrimerUso.EncontrarEmpleado();
                if (respuesta2 >= 1)
                {
                    //Cambiar por FRMPrimerUsuario, mensaje que no existe usuarios frmprimeruso ->frmprimerusuario
                    Application.Run(new FrmPrimerUsuario());
                }
                else if (respuesta2 == 0)
                {
                    Application.Run(new FrmPrimerUso());
                }
                else
                {
                    MessageBox.Show("Existe un error de nivel crítico, compruebe su conexión con el servidor o su conexión a internet", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Existe un error de nivel crítico, compruebe su conexión con el servidor o su conexión a internet", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
