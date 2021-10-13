using System;
using System.Collections.Generic;
using System.Linq;
using Modelo;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorPrimerUso
    {
        public static int EncontrarUsuario()
        {
            return ModeloPrimerUso.BuscarExistenciaUsuario();
        }
        public static int EncontrarEmpleado()
        {
            return ModeloPrimerUso.BuscarExistenciaEmpleado();
        }
    }
}
