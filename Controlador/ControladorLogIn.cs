using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Modelo;


namespace Controlador
{
    public class ControladorLogIn
    {
        #region Log In
        //Atributos
        public string clave { get; set; }
        public string usuario { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public static int tipousuario { get; set; }
        public int idempleado { get; set; }


        //Métodos
        public List<string> EncontrarDatosUsuario()
        {
            return ModeloLogIn.SelecDatos(usuario);
        }
        public int AccesoLogIn()
        {
            return ModeloLogIn.AccesoLogIn(usuario, clave);
        }
        public int IntetosVerif(string pusuario, string pclave)
        {
            return ModeloLogIn.ErrorAcceso(pusuario, pclave);
        }
        #endregion

        #region Cuenta
        public List<string> Cargarlista()
        {
            return ModeloLogIn.MiCuentaDts(usuario);
        }
        #endregion
    }
    public class AtributoLogin
    {
        public static string usuario { get; set; }
    }
    public class AtributosCuenta
    {
        public static string nombre { get; set; }
        public static string apellidos { get; set; }
        public static string documento { get; set; }
        public static string cargo { get; set; }
        public static string usuario { get; set; }
        public static string correo { get; set; }
    }
}


