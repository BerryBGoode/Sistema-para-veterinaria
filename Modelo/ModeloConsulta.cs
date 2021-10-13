using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloConsulta
    {
        #region Mostrar
        public static DataTable CargarListaPerros()
        {
            DataTable data;
            try
            {
                string query = "SELECT tbperro.idperro, tbperro.nombre_perro, tbperro.peso, tbraza.raza, tbpropietario.nombre_propie, tbpropietario.num_doc FROM tbperro INNER JOIN tbraza ON tbperro.idraza = tbraza.idraza INNER JOIN tbpropietario ON tbperro.idpropietario = tbpropietario.idpropietario";
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
            finally
            {
                ModeloConexion.Conexion().Close();
            }            
        }
        public static DataTable CargarConsulta()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT * FROM vwfrmconsultas";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);               
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {

                return data = null;
            }
            finally
            {
                ModeloConexion.Conexion().Close();
            }
        }
        public static DataTable BuscarConsulta(string valor)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM vwfrmconsultasshow WHERE nombre_perro = ?param1 OR num_doc = ?param1 OR fecha_consulta = ?param1 OR diagnostico = ?param1 OR receta = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmdselect.Parameters.Add(new MySqlParameter("param1", valor));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }

            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                ModeloConexion.Conexion().Close();
            }

        }
        public static DataTable CargarConsultageneral()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM vwfrmconsultasshow";
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
            finally
            {
                ModeloConexion.Conexion().Close();
            }
        }
        #endregion
        public static List<string> CargarConsultaLista(/*string idconsulta*/)
        {
            List<string> DatosConsulta = new List<string>();
            try
            {
                string query = "SELECT b.nombre_perro, c.nombre_propie, c.apellido_propie, c.num_doc, a.diagnostico, a.receta, a.tratamiento, a.fecha_consulta FROM tbconsulta a, tbperro b, tbpropietario c WHERE a.idperro = b.idperro AND b.idpropietario = c.idpropietario";//AND idconsulta = ?param1;
                MySqlCommand cmdWrite = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                MySqlDataReader adrWrite = cmdWrite.ExecuteReader();
                while (adrWrite.Read())
                {
                    DatosConsulta.Add(adrWrite.GetString(0));
                    DatosConsulta.Add(adrWrite.GetString(1));
                    DatosConsulta.Add(adrWrite.GetString(2));
                    DatosConsulta.Add(adrWrite.GetString(3));
                    DatosConsulta.Add(adrWrite.GetString(4));
                    DatosConsulta.Add(adrWrite.GetString(5));
                    DatosConsulta.Add(adrWrite.GetString(6));
                    DatosConsulta.Add(adrWrite.GetString(7));
                }
                return DatosConsulta;

            }
            catch (Exception)
            {
                return DatosConsulta = null;
            }
        }

        #region inserción de datos 
        public static bool RegistrarConsulta(int pidperro, string pdiagnostico,  string preceta, string ptratamiento, string pfecha_consulta)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbconsulta( idperro, diagnostico, receta, tratamiento, fecha_consulta) VALUES ('{0}','{1}','{2}','{3}','{4}')",  pidperro, pdiagnostico, preceta, ptratamiento, pfecha_consulta), ModeloConexion.Conexion());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {

                return retorno = false;
            }
        }
        public static DataTable CargarListaConsulta()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbconsulta ";
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
            finally
            {
                ModeloConexion.Conexion().Close();
            }
        }
        #endregion

        #region Actualización de datos
        public static bool ActualizarConsulta(int pidconsulta, int pidperro, string pdiagnostico, string preceta, string ptratamiento, string pfecha_consulta)
        {
            bool retorno;
            try
            {
                string query = "UPDATE tbconsulta SET idperro = '" + pidperro + "', diagnostico = '" + pdiagnostico + "', receta = '" + preceta + "', tratamiento = '" + ptratamiento + "', fecha_consulta = '" + pfecha_consulta + "' WHERE idconsulta = '" + pidconsulta + "'";
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

        #region Eliminación de datos
        public static int EliminarConsulta(int id)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdelete = new MySqlCommand(string.Format("DELETE FROM tbconsulta WHERE idconsulta = '" + id + "'"), ModeloConexion.Conexion());
                retorno = Convert.ToInt16(cmdelete.ExecuteNonQuery());
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
    }
}
