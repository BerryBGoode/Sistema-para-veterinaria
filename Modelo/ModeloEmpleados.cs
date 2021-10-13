using System;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloEmpleados
    {
        #region Lectura de datos
        public static DataTable CargarTipoDocumentos()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbtipo_doc";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {

                return data = null;
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
        public static DataTable CargarMunicipio(int pid)
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
        public static DataTable CargarMunicipioInicio()
        {
            DataTable cargar = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM tbmunicipio"), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(cargar);
                return cargar;
            }
            catch (Exception)
            {
                return cargar = null;
            }
        }
        public static DataTable CargarCargo()
        {
            DataTable cargar = new DataTable();
            try
            {
                string query = "SELECT * FROM tbcargo";
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

        public static DataTable CargarListasEmpleados()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM vwfrmempleados";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static DataTable CargarNumTelefono()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM vwcontacto_empleado";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }

        }
        public static DataTable CargarListasEmpleadosGeneral()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM vwfrmempleados";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static DataTable CargarListasEmpleadosGeneralBuscar(string buscar)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM vwfrmempleados WHERE nombre_emp = ?param1 OR num_doc = ?param1 OR cargo = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmdselect.Parameters.AddWithValue("param1", buscar);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        
        #region Inserción de datos empleados
        public static bool RegistrarEmpleado(string pnombre_emp, string papellido_emp, string pfecha_nacimiento, int pidtipodocumento, string pnum_doc, int pidmunicipio, int pidcargo)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbempleado (nombre_emp, apellido_emp, fecha_nacimiento, idtipodocumento, num_doc, idmunicipio, idcargo) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}', '{6}')", pnombre_emp, papellido_emp, pfecha_nacimiento, pidtipodocumento, pnum_doc, pidmunicipio, pidcargo), ModeloConexion.Conexion());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        #endregion

        #region Actualización de datos empleados
        public static DataTable CargarMunicipioInner(string idmunicipio)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbmunicipio WHERE municipio = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idmunicipio));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }

        }
        public static DataTable CargarTipoDocumentoInner(string idtipodocumento)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbtipo_doc WHERE tipodoc = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idtipodocumento));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }

        }
        public static DataTable CargarDepartamentosInner(string iddepartamento)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbdepartamento WHERE departamento = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", iddepartamento));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }

        }
        public static DataTable cargarCargoInner(string idcargo)
        {
            DataTable datos = new DataTable();
            try
            {
                string query = "SELECT * FROM tbcargo WHERE cargo = ?param1";
                MySqlCommand cmdcargo = new MySqlCommand(string.Format(query), Modelo.ModeloConexion.Conexion());
                cmdcargo.Parameters.Add(new MySqlParameter("param1", idcargo));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdcargo);
                adp.Fill(datos);
                return datos;
            }
            catch (Exception)
            {
                return datos = null;
            }
        }
        public static bool ActualizarEmpleado(int idempleado, string pnombre_emp, string papellido_emp, string pfecha_nacimiento, int pidtipodocumento, string pnum_doc, int pidmunicipio, int pidcargo)
        {
            bool retorno;
            try
            {
                string query = "UPDATE tbempleado SET nombre_emp = '" + pnombre_emp + "', apellido_emp = '" + papellido_emp + "', fecha_nacimiento = '" + pfecha_nacimiento + "', idtipodocumento = '" + pidtipodocumento + "', num_doc = '" + pnum_doc + "', idmunicipio = '" + pidmunicipio + "', idcargo = '"+pidcargo+"' WHERE idempleado = '" + idempleado + "'";
                MySqlCommand cmdupdate = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        #endregion

        #region Eliminación de datos empleados
        public static int EliminarEmpleado(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbempleado WHERE idempleado = '" + id + "'"), ModeloConexion.Conexion());
                retorno = Convert.ToInt16(cmddel.ExecuteNonQuery());
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
        #endregion

        #region Inserción de número de teléfono
        public static int BuscarEmpleado(string pdocumento)
        {
            int id;
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT idempleado FROM tbempleado WHERE num_doc = BINARY ?param1"), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", pdocumento);
                id = Convert.ToInt16(cmd.ExecuteScalar());
                if (id >= 1)
                {
                  
                }
                return id; 
            }
            catch (Exception)
            {
                return id = -1;
            }
        }
        public static bool RegistrarTelefono(string pcontacto, int pidempleado)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbcontacto_emp (contacto, idempleado) VALUES ('{0}','{1}')", pcontacto, pidempleado), ModeloConexion.Conexion());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        #endregion

        #region Actualización de número de teléfono
        public static bool ActualizarTelefono(int idcontacto_emp, string pcontacto, int pidempleado)
        {
            bool retorno;
            try
            {
                string query = "UPDATE tbcontacto_emp SET contacto = '" + pcontacto + "', idempleado = '" + pidempleado + "' WHERE idcontacto_emp = '" + idcontacto_emp + "'";
                MySqlCommand cmdupdate = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        #endregion



    }
}
