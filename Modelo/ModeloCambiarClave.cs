using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloCambiarClave
    {
        public static int cambiarClave(string pUsuaurio, string pClaveAntigua, string pNuevaClave)
        {
            int valor;
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM tbusuario WHERE usuario = BINARY ?param1 AND clave = BINARY ?param2"), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", pUsuaurio);
                cmd.Parameters.AddWithValue("param2", pClaveAntigua);
                valor =  Convert.ToInt16(cmd.ExecuteScalar());
                if (valor >= 1)
                {
                    MySqlCommand cmd2 = new MySqlCommand(string.Format("UPDATE tbusuario SET clave = '" + pNuevaClave + "' WHERE usuario = '" + pUsuaurio + "'"), ModeloConexion.Conexion());
                    valor = Convert.ToInt16(cmd2.ExecuteNonQuery());
                    valor = 1;
                }
                return valor;
            }
            catch (Exception)
            {
                return valor = -1;
            }
        }
    }
}
