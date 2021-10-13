using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorMiCuenta
    {
        public static string nombre { get; set; }
        public static string apellido { get; set; }
        public static string documento { get; set; }

        public static string usuario { get; set; }
        public static string correo { get; set; }

        public static int ActualizarUsuario()
        {
            return Modelo.ModeloMicuenta.ActualizarDatos(usuario, correo);
        }
        public static bool ActualizarEmpleado()
        {
            return Modelo.ModeloMicuenta.ActualizarEmpleado(nombre, apellido, documento);
        }
    }
}
