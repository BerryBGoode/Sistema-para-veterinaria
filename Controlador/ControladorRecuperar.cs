using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
    public class ControladorRecuperar
    {
        #region Método 1
        public static DataTable CargarTipoUser()
        {
            DataTable cargar = ModeloRecuperar.CargarTipoUsuario();
            return cargar;
        }
        //Artibutos Admin
        public string UsuarioAdmin { get; set; }
        public string CorreoAdmin { get; set; }
        public string ClaveAdmin { get; set; }
        public int tipouser { get; set; }
        //Atributos UsuarioBloqueado
        public string UsuarioBloqueado { get; set; }
        public string CorreoBloqueado { get; set; }
        public string DocumentoBloquedo { get;set; }

        public int ValidarAdmind()
        {
            return ModeloRecuperar.VerficarAdmin(UsuarioAdmin, CorreoAdmin, ClaveAdmin, tipouser);
        }
        public int RecuperarUsuario(string pnewclave)
        {
            return ModeloRecuperar.RecuperarUsuario(UsuarioBloqueado, CorreoBloqueado, DocumentoBloquedo, pnewclave);
        }
        #endregion

        #region Método 2
        public string usuario { get; set; }
        public string correo { get; set; }
        public string documento { get; set; }
        public string nuevaclave { get; set; }
        public string Estado { get; set; }

        public bool VerficarUsuario()
        {
            return ModeloRecuperar.VerficarUsuario(usuario, correo, documento,Estado);
        }
        public List<string> Credenciales()
        {
            return ModeloRecuperar.ImprimirCredenciales(usuario, correo);
        }
        public bool ActualizarCredenciales()
        {
            return ModeloRecuperar.ActualizarCredenciales(usuario, nuevaclave);
        }
        #endregion

        #region Método 3
        //Paso 1 Verficar datos
        public static DataTable cargarEstado()
        {
            DataTable cargar;
            return cargar =  ModeloRecuperar.CargarEstado();
        }
        public static bool VerficarUsuario(string pusuario, string pcorreo, string pestado)
        {
            return ModeloRecuperar.VerficarUsuarioM3(pusuario, pcorreo, pestado);
        }
        public static List<string> AgarraDatos(string pusuario, string pcorreo, int pestado)
        {
            return ModeloRecuperar.AgarrarCredenciales(pusuario, pcorreo, pestado);
        }
        //despues que se envio el correo prosigue la actualización
        //Paso 3: Actualización
        public static int ActualizarContrasena(string pusuario, string pnewclave)
        {
            return ModeloRecuperar.ActualizarContrasena(pusuario, pnewclave);
        }
        #endregion
    }
}
