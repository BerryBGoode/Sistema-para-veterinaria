using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloPropietario
    {
        #region Mostrar
        public static DataTable BuscarPropietarios(String buscar)
        {
            DataTable cargar = new DataTable();
            try
            {
                string query = "SELECT * FROM vwfrmpropietarios WHERE nombre_propie = ?param1 OR num_doc = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", buscar));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar = null;
            }
        }
        public static DataTable BuscarContacto(string buscar)
        {
            DataTable cargardatos = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT nombre_propie, apellido_propie, num_Contacto, num_doc FROM vwContacto_propietario WHERE nombre_propie = ?param1 OR num_doc = ?param1 OR num_Contacto = ?param1"), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", buscar);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargardatos);
                return cargardatos;
            }
            catch (Exception)
            {
                return cargardatos = null;
            }
        }
        #endregion

        #region Lectura de datos
        public static DataTable CargarTipoDoc()
        {
            DataTable cargar = new DataTable();
            try
            {
                string query = "SELECT * FROM tbtipo_doc";
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
        public static DataTable cargarEstado()
        {
            DataTable cargarEstado = new DataTable();
            try
            {
                string query = "SELECT * FROM tbestado_propietario";
                MySqlCommand cmdEstado = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                MySqlDataAdapter adpEstado = new MySqlDataAdapter(cmdEstado);
                adpEstado.Fill(cargarEstado);
                return cargarEstado;
            }
            catch (Exception)
            {
                return cargarEstado = null;
            }
        }    
        public static DataTable CargarDepartamento()
        {
            DataTable cargarDepartamento = new DataTable();
            try
            {
                string query = "SELECT * FROM tbdepartamento";
                MySqlCommand cmdDepartamento = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdDepartamento);
                adp.Fill(cargarDepartamento);
                return cargarDepartamento;
            }
            catch (Exception)
            {
                return cargarDepartamento = null;
            }
        }
        public static DataTable CargarMunicipio()
        {
            DataTable cargar = new DataTable();
            string query = "SELECT * FROM tbmunicipio";
            try
            {
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
        public static DataTable CargarMunicipioSelect(int pid)
        {
            DataTable cargar = new DataTable();
            try
            {
                string query = "SELECT * FROM tbmunicipio WHERE iddepartamento = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", pid));
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
                string query = "SELECT * FROM vwfrmpropietarios";
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
        public static DataTable CargarContacto_Propietario()
        {
            DataTable cargar = new DataTable();
            try
            {
                string query = "SELECT * FROM vwContacto_propietario";
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
        #endregion

        #region Inserción
        public static int AgregarPropietario(string pnombre, string papellidos, string pfecha_nacimiento, int ptipodoc, string pnum_doc, int pidmunicipio, int pidestado)
        {
            int retorno;
            try
            {
                string query = "INSERT INTO tbpropietario(nombre_propie, apellido_propie, fecha_nacimiento, idtipodocumento, num_doc, idmunicipio, idestado_propietario) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')";
                MySqlCommand cmdInsert = new MySqlCommand(string.Format(query, pnombre, papellidos, pfecha_nacimiento, ptipodoc, pnum_doc, pidmunicipio, pidestado), ModeloConexion.Conexion());
                retorno = Convert.ToInt16(cmdInsert.ExecuteNonQuery());
                if (retorno == 1)
                {
                    retorno = 1;
                }
                else
                {
                    retorno = 2;
                }
                return retorno;
            }
            catch (Exception)
            {
                return retorno = -1;
            }
        }
        public static bool AgregarNumTelefono(int pidpropietario, string pnum_telefono)
        {
            bool datos;
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO tbcontacto_propie (num_Contacto, idpropietario) VALUES ('{0}', '{1}')", pnum_telefono, pidpropietario), ModeloConexion.Conexion());
                datos = Convert.ToBoolean(cmd.ExecuteNonQuery());
                return datos;
            }
            catch (Exception)
            {
                return datos = false;
            }
        }
        #endregion

        #region Actualización
        public static DataTable CargarTipoDocUP(string id)
        {
            DataTable cargar = new DataTable();
            try
            {
                string query = "SELECT * FROM tbtipo_doc WHERE tipodoc = ?param1";
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
        public static DataTable CargarEstadoUp(string id)
        {
            DataTable valor = new DataTable();
            try
            {
                string query = "SELECT * FROM tbestado_propietario WHERE estado_propietario = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(valor);
                return valor;
            }
            catch (Exception)
            {
                return valor = null;
            }
        }
        public static DataTable CargarDepartamentoUP(string id)
        {
            DataTable a = new DataTable();
            try
            {
                string query = "SELECT * FROM tbdepartamento WHERE departamento = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(a);
                return a;
            }
            catch (Exception)
            {
                return a = null;
            }
        }
        public static DataTable CargarMunicipioUP(string id)
        {
            DataTable b = new DataTable();
            try
            {
                string query = "SELECT * FROM tbmunicipio WHERE municipio = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(b);
                return b;
            }
            catch (Exception)
            {
                return b = null;
            }
        }
        public static int ActualizarPropietario(int pid, string pnombre, string papellidos, string pnacimiento, int pidtipodocumento, string pnum_doc, int pidmunicipio, int pidestado)
        {
            int valor = 1;
            try
            {
                string query = "UPDATE tbpropietario SET nombre_propie = '" + pnombre + "', apellido_propie = '" + papellidos + "', fecha_nacimiento = '" + pnacimiento + "', idtipodocumento = '" + pidtipodocumento + "', num_doc = '" + pnum_doc + "', idmunicipio = '" + pidmunicipio + "', idestado_propietario = '" + pidestado + "' WHERE idpropietario = '" + pid + "'";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                valor = Convert.ToInt16(cmd.ExecuteNonQuery());
                if (valor >= 1)
                {
                    valor = 2;
                }
                return valor;
            }
            catch (Exception)
            {
                return valor = -1;
            }
        }
        public static bool ActualizarContacto_Propietario(int pid, string pnumContacto)
        {
            bool valor;
            try
            {
                string query = "UPDATE tbcontacto_propie SET num_Contacto = '" + pnumContacto + "' WHERE idnum_Contacto = '" + pid + "'";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
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
        #endregion

        #region
        public static bool EliminarPropietario(int pidpropietario)
        {
            bool valoreliminar;
            try
            {
                string query = "DELETE FROM tbpropietario WHERE idpropietario = ?param1";
                MySqlCommand cmdEliminar = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmdEliminar.Parameters.Add(new MySqlParameter("param1", pidpropietario));
                valoreliminar = Convert.ToBoolean(cmdEliminar.ExecuteNonQuery());
                if (valoreliminar == true)
                {
                    valoreliminar = true;
                }
                return valoreliminar;
            }
            catch (Exception)
            {
                return valoreliminar = false;
            }
        }        
        #endregion
    }
}
