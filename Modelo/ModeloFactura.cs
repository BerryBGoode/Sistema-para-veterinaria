using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFactura
    {
        #region Mostrar
        public static DataTable CargarFacturaShow()
        {
            DataTable a = new DataTable();
            try
            {
                MySqlCommand cmdFactura = new MySqlCommand(string.Format("SELECT * FROM vwfrmfacturashow"), ModeloConexion.Conexion());
                MySqlDataAdapter adpFactura = new MySqlDataAdapter(cmdFactura);
                adpFactura.Fill(a);
                return a;
            }
            catch (Exception)
            {
                return a = null;
            }
        }
        public static DataTable BuscarFactura(string Buscar)
        {
            DataTable cargar = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM vwfrmfacturashow WHERE num_doc = ?param1 OR fecha_factura = ?param1 OR estado_factura = ?param1"), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", Buscar));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar = null;
            }
        }
        public static DataTable BuscarFacturaFRM(string Buscar)
        {
            DataTable cargar = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM vwfrmfactura WHERE fecha_factura = ?param1 OR estado_factura = ?param1 OR nombre_propie = ?param1"), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", Buscar));
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
        #region Lectura de datos
        public static DataTable CargarEstadoFactura()
        {
            DataTable cargar = new DataTable();
            try
            {
                string query = "SELECT * FROM tbestado_factura";
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
        public static DataTable CargarPropietarios()
        {
            DataTable cargar = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM vwfrmpropietarios"), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar = null;
            }
        }
        public static DataTable BuscarPropietario(string buscar)
        {
            DataTable cargar = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM vwfrmpropietarios WHERE nombre_propie = ?param1 OR num_doc = ?param1"), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", buscar);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar = null;
            }
        }
        public static DataTable CargarUsuarios()
        {
            DataTable cargar = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM vwusuarios"), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar = null;
            }
        }
        public static DataTable BuscarUsuarios(string buscar)
        {
            DataTable cargar = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM vwusuarios WHERE nombre_emp = ?param1 OR usuario = ?param1 OR num_doc = ?param1"), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", buscar);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar = null;
            }
        }
        public static DataTable CagarFactura()
        {
            DataTable ab = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM vwfrmfactura"), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(ab);
                return ab;
            }
            catch (Exception)
            {
                return ab = null;
            }
        }
        #endregion

        #region Inserción
        public static int AgregarFactura(int pidpropietario, int pidusuario, string ptotalpaga, string pfecha_factura, int pidestado_factura)
        {
            int valor;
            try
            {
                string query = "INSERT INTO tbfactura (idpropietario, idestado_factura, totalpaga, fecha_factura, idusuario) VALUES ('{0}', '{1}','{2}', '{3}', '{4}')";
                MySqlCommand cmd = new MySqlCommand(string.Format(query, pidpropietario, pidestado_factura, ptotalpaga, pfecha_factura, pidusuario), ModeloConexion.Conexion());
                valor =  Convert.ToInt16(cmd.ExecuteNonQuery());
                if (valor >= 1)
                {
                    valor = 1;
                }
                return valor;
            }
            catch (Exception)
            {
                return valor =- 1;
            }
        }
        #endregion

        #region Actualización
        public static int ActualizarFactura(int pidfactura, int pidpropietario, int pidusuario, string ptotalpaga, string pfecha_factura, int pidestado_factura)
        {
            int algo;
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE tbfactura SET idpropietario = '" + pidpropietario + "', idestado_factura = '" + pidestado_factura + "', totalpaga = '" + ptotalpaga + "', fecha_factura = '" + pfecha_factura + "', idusuario = '" + pidusuario + "' WHERE idfactura = '"+pidfactura+"'"), ModeloConexion.Conexion());
                algo = Convert.ToInt16(cmd.ExecuteNonQuery());
                if (algo >= 1)
                {
                    algo = 1;
                }
                return algo;
            }
            catch (Exception)
            {
                return algo = -1;
            }
        }
        public static DataTable CargarEstadoUp(string valor)
        {
            DataTable a = new DataTable();
            try
            {
                string query = "SELECT * FROM tbestado_factura WHERE estado_factura = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", valor));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(a);
                return a;
            }
            catch (Exception)
            {
                return a = null;
            }
        }    
        #endregion
        public static int EliminarFactura(int idfactura)
        {
            int resultado;
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("DELETE FROM tbfactura WHERE idfactura = '" + idfactura + "'"), ModeloConexion.Conexion());
                resultado = Convert.ToInt16(cmd.ExecuteNonQuery());
                if (resultado == 1)
                {
                    resultado = 1;
                }               
                return resultado;
            }
            catch (Exception)
            {
                return resultado = -1;

            }
        }
    }
}
