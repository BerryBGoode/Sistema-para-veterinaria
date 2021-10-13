using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModeloConexion
    {
        public static MySqlConnection Conexion()
        {
            MySqlConnection obtenerconexion;
            try
            {
                string server, password, db, user;//variables para crear una conexion
                server = "127.0.0.1";
                password = "";//contraseña (si el usuario utiliza contraseña para ingresar a sql)
                db = "dbveterinaria";//es el nombre del usuario en la base de datos
                user = "root";//es el nombre del usuario en la base de datos
                obtenerconexion = new MySqlConnection("server = " + server + "; database = " + db + "; uid = " + user + "; pwd = " + password); /*El nombre o lo que está entre comllias es
                 en la instancia se le asigna un valor a la sqlConnection                                                                   un valor por defecto */

                obtenerconexion.Open();//se le instruye a la conexion que se abra
                return obtenerconexion; //se retorno "connection" con valor de la instancia
            }
            catch (Exception)
            {

                return obtenerconexion = null;//Si existe algún error en el try se ejecuta el catch y la conexión sera nula
            }
        }
    }
}
