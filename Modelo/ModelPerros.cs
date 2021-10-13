using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelPerros
    {
        public static DataTable ObtenerRaza()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbraza";
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
        public static DataTable Obtenergenero()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbgenero";
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
        public static DataTable obtenerlista_perros()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM vwperros_propietarios";
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
        public static DataTable obtenerListaperros_propietarios()
        {
            DataTable a = new DataTable();
            try
            {
                string query = "SELECT * FROM vwperros_propietariosshow";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(a);
                return a;
            }
            catch (Exception)
            {
                return a = null;
            }
        }
        public static DataTable obtenerListasPerros_PropietarioBuscar(string Busqueda)
        {
            DataTable b = new DataTable();
            try
            {
                string query = "SELECT * FROM vwperros_propietariosshow WHERE nombre_perro = ?param1 OR num_doc = ?param1 OR nombre_propie = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", Busqueda));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(b);
                return b;
            }
            catch (Exception)
            {
                return b = null;
            }
        }
        //Insercion de datos
        public static bool RegistrarPerros(string nombre_perro, string fecha_nacimiento, string peso, string tamano, int idraza, int idgenero, int idpropietario)
        {
            bool retorno;

            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO tbperro(nombre_perro, fecha_nacimiento, peso, tamano, idraza, idgenero, idpropietario) VALUES ('{0}', '{1}', '{2}','{3}', '{4}', '{5}', '{6}')", nombre_perro, fecha_nacimiento, peso, tamano, idraza, idgenero, idpropietario), ModeloConexion.Conexion());
                retorno = Convert.ToBoolean(cmd.ExecuteNonQuery());
                return retorno;


            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        //Actualizacion de datos
        public static DataTable generoInner(string valor)
        {
            DataTable datos = new DataTable();
            try
            {
                string query = "SELECT * FROM tbgenero WHERE genero = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", valor));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(datos);
                return datos;
            }
            catch (Exception)
            {

                return datos = null;
            }
            finally
            {
                ModeloConexion.Conexion().Close();
            }
        }
        public static DataTable razaInner(string valor)
        {
            DataTable datos = new DataTable();
            try
            {
                string query = "SELECT * FROM tbraza WHERE raza = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", valor));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(datos);
                return datos;
            }
            catch (Exception)
            {

                return datos = null;
            }
            finally
            {
                ModeloConexion.Conexion().Close();
            }
        }
        public static bool Actualizarperros(int idperro, string nombre_perro, string fecha_nacimiento, string peso, string tamano, int idraza, int idgenero, int idpropietario)
        {
            bool retorno;
            try
            {
                string query = "UPDATE tbperro SET nombre_perro ='" + nombre_perro + "', fecha_nacimiento ='" + fecha_nacimiento + "', peso ='" + peso + "', tamano ='" + tamano + "', idraza ='" + idraza + "', idgenero ='" + idgenero + "', idpropietario='" + idpropietario + "' WHERE idperro ='" + idperro + "'";
                MySqlCommand cmdupdate = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        //Eliminación de datos       
        public static bool Eliminarperro(int id)
        {
            bool retorno;
            try
            {
                string query = "DELETE FROM tbperro WHERE idperro = '" + id + "'";
                MySqlCommand cmddel = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

    }
}
