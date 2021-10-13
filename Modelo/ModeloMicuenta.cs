using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModeloMicuenta
    {
        public static int ActualizarDatos(string usuario, string correo)
        {
            int resul;
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE tbusuario SET usuario = '" + usuario + "', correo = '" + correo + "' WHERE usuario = '" + usuario + "'"), ModeloConexion.Conexion());
                resul = Convert.ToInt16(cmd.ExecuteNonQuery());
                if (resul >=1)
                {
                    resul = 1;
                }
                return resul;
            }
            catch (Exception)
            {
                return resul = 0;
            }
        }
        public static bool ActualizarEmpleado(string nombre, string apellido, string documento)
        {
            bool resul;
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE tbempleado SET nombre_emp = '" + nombre + "', apellido_emp = '" + apellido + "', num_doc = '" + documento + "' WHERE num_doc = '"+documento+"'"), ModeloConexion.Conexion());
                resul = Convert.ToBoolean(cmd.ExecuteNonQuery());
                return resul;
            }
            catch (Exception)
            {
                return resul = false;
            }
        }
    }
}
