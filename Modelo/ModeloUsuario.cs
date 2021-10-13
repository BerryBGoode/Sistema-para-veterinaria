using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModeloUsuario
    {
        #region Lectura de datos
        public static DataTable CargaTipoUsuario()
        {
            DataTable cargar = new DataTable();
            try
            {
                string query = "SELECT * FROM tbtipousuario";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar = null;
            }
        }
        public static DataTable CargarEstadoUsuario()
        {
            DataTable cargar = new DataTable();
            try
            {
                string query = "SELECT * FROM tbestadousuario";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar;
            }
        }
        public static DataTable CargarEmpleados()
        {
            DataTable cargar = new DataTable();
            try
            {
                string query = "SELECT * FROM vwfrmempleados";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar= null;
            }
        }
        //Mostrar
        public static DataTable CargarUsuarios()
        {
            DataTable cargar = new DataTable();
            try
            {
                string query = "SELECT * FROM vwusuarios";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar = null;
            }
        }
        public static DataTable BuscarUsuarios(string busqueda)
        {
            DataTable cargar = new DataTable();
            try
            {
                string query = "SELECT * FROM vwusuarios WHERE usuario = ?param1 OR num_doc = ?param1 OR correo = ?param1 ";/*OR tipoUsuario = ?param1 OR estado_usuario = ?param1*/
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", busqueda));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar = null;
            }
        }
        #endregion

        //Inserción
        public static bool InsertarUsuario(string pusuario, string pclave, string pcorreo,int pidempleado,int pidtipousuario, int pidestado_usuario)
        {
            bool valor;
            try
            {
                string query = "INSERT INTO tbusuario (usuario, clave, correo, idempleado, idtipo_usuario, idestado_usuario) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";
                MySqlCommand cmd = new MySqlCommand(string.Format(query, pusuario, pclave, pcorreo, pidempleado, pidtipousuario, pidestado_usuario), ModeloConexion.Conexion());
                valor = Convert.ToBoolean(cmd.ExecuteNonQuery());
                if (valor == true)
                {
                    valor = true;
                }
                return valor;
            }
            catch (Exception)
            {
                return valor = false;
            }
        }

        //Actualización
        public static DataTable CargarTipoUsuario(string id)
        {
            DataTable cargar = new DataTable();
            try
            {
                string query = "SELECT * FROM tbtipousuario WHERE tipoUsuario = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar;
            }
        }
        public static DataTable CargarEstadoUsuarios(string id)
        {
            DataTable cargar = new DataTable();
            try
            {
                string query = "SELECT * FROM tbestadousuario WHERE estado_usuario = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar = null;
            }
        }
        public static int ActualizacionUsuario(int pidusuario, string pusuario, string pcorreo, int pidempleado, int pidtipousuario, int pidestado_usuario)
        {
            int valor;
            try
            {
                string query = "UPDATE tbusuario SET usuario = '" + pusuario + "', correo = '"+pcorreo+"', idempleado = '" + pidempleado + "', idtipo_usuario = '" + pidtipousuario + "', idestado_usuario = '" + pidestado_usuario + "' WHERE idusuario = '"+pidusuario+"'";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                valor = Convert.ToInt16(cmd.ExecuteNonQuery());
                if (valor >= 1)
                {
                    valor = 1;
                }
                return valor;
            }
            catch (Exception)
            {
                return valor = -1;
            }
        }

        //Eliminación
        public static bool EliminarUsuario(int pidusuario)
        {
            bool respuesta;
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("DELETE FROM tbusuario WHERE idusuario = ?param1"), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", pidusuario));
                respuesta = Convert.ToBoolean(cmd.ExecuteNonQuery());
                if (respuesta == true)
                {
                    respuesta = true;
                }
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta = false;
            }
        }
    }
}
