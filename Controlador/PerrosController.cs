using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
    public class PerrosController
    {
        public static DataTable raza_controller()
        {
            return ModelPerros.ObtenerRaza();
        }
        public static DataTable genero_controller()
        {
            return ModelPerros.Obtenergenero();
        }
        public static DataTable Cargarperros_controller()
        {
            return ModelPerros.obtenerlista_perros();
        }        
        public static DataTable cargarpropietarioShow()
        {
            DataTable cargar = ModelPerros.obtenerListaperros_propietarios();
            return cargar;
        }
        public static DataTable BuscarListageneral(string busqueda)
        {
            DataTable cargar = ModelPerros.obtenerListasPerros_PropietarioBuscar(busqueda);
            return cargar;
        }

        public int idperro { get; set; }
        public string nombre_perro { get; set; }
        public string fecha_nacimiento { get; set; }
        public string peso { get; set; }
        public string tamano { get; set; }
        public int idraza { get; set; }
        public int idgenero { get; set; }
        public int idpropietario { get; set; }

        //Inserción
        public bool EnviarPerros_Controller()
        {
            return ModelPerros.RegistrarPerros(nombre_perro, fecha_nacimiento, peso, tamano, idraza, idgenero, idpropietario);
        }
        //Actualización
        public static DataTable generoInnerJoin(string valor)
        {
            return ModelPerros.generoInner(valor);
        }
        public static DataTable razaInnerJoin(string valor)
        {
            return ModelPerros.razaInner(valor);
        }
        public bool Actualizarperros()
        {
            return ModelPerros.Actualizarperros(idperro, nombre_perro, fecha_nacimiento, peso, tamano, idraza, idgenero, idpropietario);
        }
        //Eliminación
        public bool Eliminarperro(int id)
        {
            return ModelPerros.Eliminarperro(id);
        }
    }
}
