using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Controlador
{
    public class ControladorConexion
    {
        public static MySqlConnection connection()
        {
            MySqlConnection conexion = Modelo.ModeloConexion.Conexion();//se llama el valor o resultado de la conexión que tuvo en modelo
            return conexion; //se retorna "conexion" 
        }
    }
}
