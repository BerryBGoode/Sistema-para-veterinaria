using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloLogIn
    {
        #region Log In
        public static int AccesoLogIn(string pususario, string pclave)
        {
            int valor = 1;
            try
            {
                int estado = 1;                                                                                                         //Esto agrege 22/9/21
                string query = "SELECT * FROM tbusuario WHERE usuario = BINARY ?param1 AND clave = BINARY ?param2 AND idestado_usuario = BINARY ?param3";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.Add(new MySqlParameter("param1", pususario));
                cmd.Parameters.Add(new MySqlParameter("param2", pclave));
                cmd.Parameters.Add(new MySqlParameter("param3", estado));
                valor = Convert.ToInt16(cmd.ExecuteScalar());
                if (valor >= 1)
                {
                    int intentos = 0;
                    MySqlCommand cmd2 = new MySqlCommand(string.Format("UPDATE tbusuario SET intentos = '" + intentos + "'"), ModeloConexion.Conexion());//restablecer intentos
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
        public static int ErrorAcceso(string pusuario, string pclave)
        {
            int valor, intentos;
            try
            {
                string query = "SELECT * FROM tbusuario WHERE usuario = BINARY ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", pusuario);
                valor = Convert.ToInt16(cmd.ExecuteScalar());
                if (valor >= 1)
                {
                    List<int> lista = new List<int>();
                    string query2 = "SELECT intentos FROM tbusuario WHERE usuario = BINARY ?param1";
                    MySqlCommand cmd2 = new MySqlCommand(string.Format(query2), ModeloConexion.Conexion());
                    cmd2.Parameters.AddWithValue("param1", pusuario);
                    MySqlDataReader leer = cmd2.ExecuteReader();
                    while (leer.Read())
                    {
                        lista.Add(leer.GetInt16(0));
                        int numintentos = lista[0];
                        intentos = numintentos + 1;
                        //Actualizar intentos, si los intentos <= 5
                        if (intentos > 6)
                        {
                            int nuevoEstado = 3;
                            string query3 = "UPDATE tbusuario SET idestado_usuario = '" + nuevoEstado + "' WHERE usuario = '" + pusuario + "'"; //Bloquear usuario
                            MySqlCommand cmd3 = new MySqlCommand(string.Format(query3), ModeloConexion.Conexion());
                            Convert.ToInt16(cmd3.ExecuteNonQuery());
                        }
                        else
                        {
                            string query4 = "UPDATE tbusuario SET intentos = '" + intentos + "' WHERE usuario = '" + pusuario + "'";//Actualizar el número de intentos
                            MySqlCommand cmd4 = new MySqlCommand(string.Format(query4), ModeloConexion.Conexion());
                            Convert.ToInt16(cmd4.ExecuteNonQuery());
                        }
                        //fin del proceso de actualizar intentos o bloquear
                    }
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
        public static List<String> SelecDatos(string pusuario)
        {
            List<string> listusuario = new List<string>();
            try
            {
                string query = "SELECT b.idempleado, b.nombre_emp, b.apellido_emp, a.idtipo_usuario FROM tbusuario a, tbempleado b WHERE a.idempleado = b.idempleado AND a.usuario = ?param1";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", pusuario);
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    listusuario.Add(read.GetString(0));
                    listusuario.Add(read.GetString(1));
                    listusuario.Add(read.GetString(2));
                    listusuario.Add(read.GetString(3));
                }
                return listusuario;
            }
            catch (Exception)
            {
                return listusuario = null;
            }
        }
        public static List<string> MiCuentaDts(string pusuario)
        {
            List<string> lista = new List<string>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT a.nombre_emp, a.apellido_emp, a.num_doc, c.cargo, b.usuario, b.correo FROM tbempleado a, tbusuario b, tbcargo c  WHERE b.idempleado = a.idempleado AND a.idcargo = c.idcargo AND  b.usuario = ?param1"), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", pusuario);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(reader.GetString(0));
                    lista.Add(reader.GetString(1));
                    lista.Add(reader.GetString(2));
                    lista.Add(reader.GetString(3));
                    lista.Add(reader.GetString(4));
                    lista.Add(reader.GetString(5));
                }
                return lista;
            }
            catch (Exception)
            {

                return lista = null;
            }
        }
        #endregion
    }
}
