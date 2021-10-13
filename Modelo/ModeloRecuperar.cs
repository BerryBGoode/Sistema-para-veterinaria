using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloRecuperar
    {
        #region Método 1
        public static DataTable CargarTipoUsuario()
        {
            DataTable cargar = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM tbtipousuario WHERE idtipoUsuario = 1 OR idtipoUsuario = 2 "), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar = null;
            }
        }
        public static int VerficarAdmin(string pusuarioadmin, string pcorreoadmin, string pclave, int ptipouser)
        {
            int resultado, estado;
            estado = 1;
            try
            {

                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM tbusuario WHERE usuario = BINARY ?param1 AND correo = BINARY ?param2 AND clave = ?param3 AND idtipo_usuario = BINARY ?param4 AND idestado_usuario = BINARY ?param5"), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", pusuarioadmin);
                cmd.Parameters.AddWithValue("param2", pcorreoadmin);
                cmd.Parameters.AddWithValue("param3", pclave);
                cmd.Parameters.AddWithValue("param4", ptipouser);
                cmd.Parameters.AddWithValue("param5", estado);
                resultado = Convert.ToInt16(cmd.ExecuteScalar());
                return resultado;
            }
            catch (Exception)
            {
                return resultado = -1;
            }
        }
        public static int RecuperarUsuario(string pusuariobloq, string pcorreobloq, string pdocbloq, string pnewclave)
        {
            int valor, estado;
            estado = 3;
            try
            {
                string query1 = "SELECT * FROM tbempleado a, tbusuario b WHERE b.idempleado = a.idempleado AND b.usuario = BINARY ?param1 AND b.correo = BINARY ?param2 AND a.num_doc = BINARY ?param3 AND b.idestado_usuario = BINARY ?param4";
                MySqlCommand cmd = new MySqlCommand(string.Format(query1), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", pusuariobloq);
                cmd.Parameters.AddWithValue("param2", pcorreobloq);
                cmd.Parameters.AddWithValue("param3", pdocbloq);
                cmd.Parameters.AddWithValue("param4", estado);
                valor = Convert.ToInt16(cmd.ExecuteScalar());
                if (valor >= 1)
                {
                    int intentos, NewEstado;
                    NewEstado = 1;
                    intentos = 0;                                 
                    string query2 = "UPDATE tbusuario SET idestado_usuario = '" + NewEstado + "', intentos = '" + intentos + "', clave = '" + pnewclave + "' WHERE usuario = '"+pusuariobloq+"'";
                    MySqlCommand cmd2 = new MySqlCommand(string.Format(query2), ModeloConexion.Conexion());
                    valor = Convert.ToInt16(cmd2.ExecuteNonQuery());
                    valor = 1;
                }
                else
                {
                    valor = 0;
                }
                return valor;
            }
            catch (Exception)
            {
                return valor = -1;
            }
        }
        #endregion Método 2

        #region Método 2
        public static bool VerficarUsuario(string pusuario, string pcorreo, string pdocumento, string estado)
        {
            bool respuesta;          
            try
            {                           
                string query = "SELECT * FROM vwusuarios WHERE usuario = BINARY ?param1 AND correo = BINARY ?param2 AND estado_usuario = BINARY ?param3 AND num_doc = BINARY ?param4";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", pusuario);
                cmd.Parameters.AddWithValue("param2", pcorreo);
                cmd.Parameters.AddWithValue("param3", estado);
                cmd.Parameters.AddWithValue("param4", pdocumento);
                respuesta = Convert.ToBoolean(cmd.ExecuteScalar());                                                
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta = false;
            }            
        }
        public static List<string> ImprimirCredenciales(string pusuario, string pcorreo)
        {
            List<string> Credenciales = new List<string>();
            try
            {
                string query = "SELECT b.nombre_emp, b.apellido_emp, a.usuario, a.correo, b.num_doc, c.cargo FROM tbusuario a, tbempleado b, tbcargo c WHERE a.idempleado = b.idempleado AND b.idcargo = c.idcargo AND a.usuario = ?param1 AND a.correo = ?param2";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", pusuario);
                cmd.Parameters.AddWithValue("param2", pcorreo);
                MySqlDataReader adr = cmd.ExecuteReader();
                while (adr.Read())
                {
                    Credenciales.Add(adr.GetString(0));
                    Credenciales.Add(adr.GetString(1));
                    Credenciales.Add(adr.GetString(2));
                    Credenciales.Add(adr.GetString(3));
                    Credenciales.Add(adr.GetString(4));
                    Credenciales.Add(adr.GetString(5));
                }
                return Credenciales;
            }
            catch (Exception)
            {
                return Credenciales = null;
            }
        }
        public static bool ActualizarCredenciales(string pusuario, string pnewclave)
        {
            bool respuesta = false; ;
            int intentos, estado;
            intentos = 0;
            estado = 1;
            try
            {
                string query = "UPDATE tbusuario SET clave = '" + pnewclave + "', intentos = '" + intentos + "', idestado_usuario = '" + estado + "' WHERE usuario = '" + pusuario + "'";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                respuesta = Convert.ToBoolean(cmd.ExecuteNonQuery());
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta;
            }
        }
        #endregion

        #region Método 3        
        public static DataTable CargarEstado()
        {
            DataTable cargar = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM tbestadousuario WHERE idestado_usuario = 1 OR idestado_usuario = 3"), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar = null;
            }
        }
        //Verificar
        public static bool VerficarUsuarioM3(string pusuario, string pcorreo, string estado)
        {
            bool verficar = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM vwusuarios WHERE usuario = BINARY ?param1 AND correo = BINARY ?param2 AND estado_usuario = BINARY ?param3"), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", pusuario);
                cmd.Parameters.AddWithValue("param2", pcorreo);
                cmd.Parameters.AddWithValue("param3", estado);
                verficar = Convert.ToBoolean(cmd.ExecuteScalar());
                return verficar;
            }
            catch (Exception)
            {
                return verficar;
            }
        }
        //Imprimir en los controles
        public static List<string> AgarrarCredenciales(string pusuario, string pcorreo, int pestado)
        {
            List<string> Credenciales = new List<string>();
            try
            {
                string query = "SELECT b.nombre_emp, b.apellido_emp, a.usuario, a.correo, b.num_doc, c.cargo FROM tbusuario a, tbempleado b, tbcargo c WHERE a.idempleado = b.idempleado AND b.idcargo = c.idcargo AND a.usuario = ?param1 AND a.correo = ?param2 AND a.idestado_usuario = ?param3";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", pusuario);
                cmd.Parameters.AddWithValue("param2", pcorreo);
                cmd.Parameters.AddWithValue("param3", pestado);
                MySqlDataReader adr = cmd.ExecuteReader();
                while (adr.Read())
                {
                    Credenciales.Add(adr.GetString(0));
                    Credenciales.Add(adr.GetString(1));
                    Credenciales.Add(adr.GetString(2));
                    Credenciales.Add(adr.GetString(3));
                    Credenciales.Add(adr.GetString(4));
                    Credenciales.Add(adr.GetString(5));
                }
                return Credenciales;
            }
            catch (Exception)
            {
                return Credenciales = null;
            }
        }
        //despues que se envio el correo prosigue la actualización
        //Actualización de contraseña
        public static int ActualizarContrasena(string pusuario, string pnewclave)
        {
            int valor;            
            try
            {
                string query = "UPDATE tbusuario SET clave = '"+pnewclave+"' WHERE usuario = '"+pusuario+"'";
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
                return valor = 0;
            }
        }
        #endregion
    }
}
