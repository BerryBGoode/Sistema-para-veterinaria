using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
namespace Modelo
{
    public class ModeloExpediente
    {
        #region Expediente
        public int accesoExpediente(int pid)
        {
            int valor = 1;
            try
            {
                string query = "SELECT * FROM tbconsulta WHERE idconsulta = BINARY ?param1";
                MySqlCommand cmdexpediente = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmdexpediente.Parameters.Add(new MySqlParameter("param1", pid));
                valor = Convert.ToInt16(cmdexpediente.ExecuteScalar());
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
        public static int ComprobarExpediente(int pid)
        {
            int valor;
            try
            {
                string query = "SELECT * FROM tbexpediente WHERE idconsulta = BINARY ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", pid);
                valor = Convert.ToInt16(cmd.ExecuteScalar());
                if (valor <= 0)
                {
                    valor = 0;
                }
                else if (valor >= 1)
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
        public static List<int> SelecID(int pid)
        {
            List<int> lista = new List<int>();
            try
            {
                string query = "SELECT a.idconsulta FROM tbconsulta a WHERE a.idconsulta = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", pid);
                MySqlDataReader adr = cmd.ExecuteReader();
                while (adr.Read())
                {
                    lista.Add(adr.GetInt16(0));
                }
                return lista;
            }
            catch (Exception)
            {
                return lista = null;
            }
        }
        public static int AgregarExpediente(string pdescrip, string pfecha_consulta, int pconsulta)
        {
            int respuesta;
            try
            {
                string query = "INSERT INTO tbexpediente (descrip_conducta, fecha_expediente, idconsulta) VALUES ('{0}', '{1}', '{2}')";
                MySqlCommand cmd = new MySqlCommand(string.Format(query, pdescrip, pfecha_consulta, pconsulta), ModeloConexion.Conexion());
                respuesta = Convert.ToInt16(cmd.ExecuteNonQuery());
                if (respuesta >= 1)
                {
                    respuesta = 2;
                }
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta = -1;
            }
        }
        public static int ActualizarExpediente(string pdescrip, string pfecha_consulta, int pconsulta)
        {
            int respuesta;
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE tbexpediente SET descrip_conducta = '" + pdescrip + "', fecha_expediente = '" + pfecha_consulta + "' WHERE idconsulta = '" + pconsulta + "'"), ModeloConexion.Conexion());
                respuesta = Convert.ToInt16(cmd.ExecuteNonQuery());
                if (respuesta >= 1)
                {
                    respuesta = 1;
                }
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta = 0;
            }
        }
        public static bool EliminarExpediente(int id)
        {
            bool respuesta;
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("DELETE FROM tbexpediente WHERE idconsulta = ?param1"), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", id); 
                respuesta = Convert.ToBoolean(cmd.ExecuteNonQuery());
                return respuesta;
            }
            catch (Exception)
            {
                return respuesta = false;
            }
        }
        public static int CargarIDconsulta(int idconsulta)
        {
            int ID;
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT idconsulta FROM tbexpediente WHERE idconsulta = BINARY ?param1"), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", idconsulta);
                ID = Convert.ToInt16(cmd.ExecuteScalar());
                if (ID >= 1)
                {

                }
                return ID;
            }
            catch (Exception)
            {
                return ID = 0;
            }
        }
        public static List<string> cargarDetalle(int pidconsulta)
        {
            List<string> Datos = new List<string>();
            try
            {
                string query = "SELECT descrip_conducta FROM tbexpediente WHERE idconsulta = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", pidconsulta);
                MySqlDataReader adr = cmd.ExecuteReader();
                while (adr.Read())
                {
                    Datos.Add(adr.GetString(0));
                }
                return Datos;
            }
            catch (Exception)
            {
                return Datos = null;
            }
        }
        public static List<string> CargarFechaExpediente(int idconsulta)
        {

            List<string> cargarFecha = new List<string>();
            try
            {
                string query = "SELECT fecha_expediente FROM tbexpediente WHERE idconsulta = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", idconsulta);
                MySqlDataReader reg = cmd.ExecuteReader();
                while (reg.Read())
                {
                    cargarFecha.Add(reg.GetString(0));
                }
                return cargarFecha;
            }
            catch (Exception)
            {
                return cargarFecha = null;
            }
        }
        #endregion

    }
}
