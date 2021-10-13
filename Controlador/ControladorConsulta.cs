using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Modelo;

namespace Controlador
{
    public class ControladorConsulta
    {
        #region Mostrar
        public static DataTable CargarListaPerro_Controller()
        {
            return ModeloConsulta.CargarListaPerros();
        }
        public static DataTable CargarConsulta_Controller()
        {           
            return ModeloConsulta.CargarConsulta();
        }
        public static DataTable CargarConsultaGeneral_Controller()
        {
            return ModeloConsulta.CargarConsultageneral();
        }
        public static DataTable ObtenerConsulta_Controller()
        {
            DataTable datos = ModeloConsulta.CargarListaConsulta();
            return datos;
        }
        public static DataTable BuscarConsulta_Controller(string valor)
        {
            DataTable datos = ModeloConsulta.BuscarConsulta(valor);
            return datos;
        }
        #endregion

    
        // Atributos
        public static int idconsulta { get; set; }
        public int idperro { get; set; }
        public string diagnostico { get; set; }
        public string receta { get; set; }
        public string tratamiento { get; set; }
        public string fecha_consulta { get; set; }
      

        //Constructor
        public ControladorConsulta( int pidperro, string pdiagnostico, string preceta, string ptratamiento, string pfecha_consulta)
        {
            //Atributo = parametro
            idperro = pidperro;
            diagnostico = pdiagnostico;
            receta = preceta;
            tratamiento = ptratamiento;
            fecha_consulta = pfecha_consulta;
        }
        public ControladorConsulta()
        {

        }
        public List<string> CargarConsultaLista()
        {
            return ModeloConsulta.CargarConsultaLista();
        }
        #region inserción de datos 
        public bool EnviarDatos_Controller()
        {
            return ModeloConsulta.RegistrarConsulta( idperro, diagnostico, receta, tratamiento, fecha_consulta);
        }
        #endregion

        #region Actualización de datos
        public bool ActualizarDatos_Controller()
        {
            return ModeloConsulta.ActualizarConsulta(idconsulta, idperro, diagnostico, receta, tratamiento, fecha_consulta);
        }
        #endregion

        #region Eliminación de datos
        public static int EliminarConsulta_Controller()
        {
            return ModeloConsulta.EliminarConsulta(idconsulta);
        }
        #endregion

    }
    
}
