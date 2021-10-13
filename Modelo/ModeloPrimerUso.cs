using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloPrimerUso
    {
        public static int BuscarExistenciaUsuario()
        {
            int valor;
            try
            {
                int activo = 1, bloqueado = 3;
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM tbusuario WHERE idestado_usuario = BINARY ?param1 OR idestado_usuario = BINARY ?param2"), ModeloConexion.Conexion());
                cmd.Parameters.AddWithValue("param1", activo);
                cmd.Parameters.AddWithValue("param2", bloqueado);
                valor = Convert.ToInt16(cmd.ExecuteScalar());
                if (valor >= 1)
                {
                    //Existe usuario
                    valor = 1;
                }
                else if(valor == 0)
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
        public static int BuscarExistenciaEmpleado()
        {
            int valor;
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT * FROM tbempleado"), ModeloConexion.Conexion());
                valor = Convert.ToInt16(cmd.ExecuteScalar());
                if (valor >=1)
                {
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
    }
}
