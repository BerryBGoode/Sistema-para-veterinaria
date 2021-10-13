using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
    public class ControladorUsuario
    {
        #region Lectura de datos
        public static DataTable CargarTipoUsuario()
        {
            DataTable cargar = ModeloUsuario.CargaTipoUsuario();
            return cargar;
        }
        public static DataTable CargarEstadoUsuario()
        {
            DataTable cargar = ModeloUsuario.CargarEstadoUsuario();
            return cargar;
        }
        public static DataTable CargarEmpleados()
        {
            DataTable cargar = ModeloUsuario.CargarEmpleados();
            return cargar;
        }
        //Lectura
        public static DataTable CargarUsuarios()
        {
            DataTable cargar;
            return cargar = ModeloUsuario.CargarUsuarios();
        }
        public static DataTable BuscarUsuarios(string busqueda)
        {
            DataTable cargar = ModeloUsuario.BuscarUsuarios(busqueda);
            return cargar;
        }
        #endregion
        //Atributos
        public static int idusuario { get; set; }
        public string Nombre_usuario { get; set; }
        public string Clave { get; set; }
        public string correo { get; set; }
        public int idempleado { get; set;}
        public int idtipoUsuario { get; set; }
        public int idestado_usuario { get; set; }
        //Constructor
        public ControladorUsuario(string pnombre_usuario, string pclave, string pcorreo,int pidempleado, int pidtipoUsuario, int pidestado_usuario )//Para inserción
        {
            Nombre_usuario = pnombre_usuario;
            Clave = pclave;
            correo = pcorreo;
            idempleado = pidempleado;
            idtipoUsuario = pidtipoUsuario;
            idestado_usuario = pidestado_usuario;
        }
        public ControladorUsuario(string pnombreusuario, string pcorreo, int pidempleado, int pidtipousuario, int pidestado_usuario)//Para actualización
        {
            Nombre_usuario = pnombreusuario;
            correo = pcorreo;
            idempleado = pidempleado;
            idtipoUsuario = pidtipousuario;
            idestado_usuario = pidestado_usuario;
        }
        #region Métodos 
        //Inserción
        public bool InsertarUsuario()
        {
            return ModeloUsuario.InsertarUsuario(Nombre_usuario, Clave, correo, idempleado, idtipoUsuario, idestado_usuario);
        }

        //Actualización
        public static DataTable CargarEstados_Usuario(string id)
        {
            return ModeloUsuario.CargarEstadoUsuarios(id);
        }
        public static DataTable CargarTiposUsser(string id)
        {
            return ModeloUsuario.CargarTipoUsuario(id);
        }
        public int ActualizacionUsuario()
        {
            return ModeloUsuario.ActualizacionUsuario(idusuario, Nombre_usuario, correo, idempleado, idtipoUsuario, idestado_usuario);
        }

        //Eliminación
        public static bool EliminarUsuario()
        {
            return ModeloUsuario.EliminarUsuario(idusuario);
        }
        #endregion
    }
    public class AtributosCredenciales
    {
        public static string UsuarioVerif { get; set; }
        public static string nombre { get; set; }
        public static string Apellidos { get; set; }
        public static int ID { get; set; }
    }
}
