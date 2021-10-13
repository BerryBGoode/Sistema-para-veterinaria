using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;

namespace Controlador
{
    public class ControladorCambiarClave
    {
        public static string Usuario { get; set; }
        public static string ClaveAntigua { get; set; }
        public static string NuevaClave { get; set; }
        public ControladorCambiarClave(string pUsuario, string pClaveAntigua, string pNuevaClave)
        {
            Usuario = pUsuario;
            ClaveAntigua = pClaveAntigua;
            NuevaClave = pNuevaClave;
        }
        public static int CambiarClave()
        {
            return ModeloCambiarClave.cambiarClave(Usuario, ClaveAntigua, NuevaClave);
        }

        public ControladorCambiarClave(string pusuario, string pclaveantigua)
        {
            Usuario = pusuario;
            ClaveAntigua = pclaveantigua;
        }
        public static int VerficarClave()
        {
            return ModeloLogIn.AccesoLogIn(Usuario, ClaveAntigua);
        }
    }
}
