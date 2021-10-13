using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class ControladorExpediente
    {
        #region Expediente
        //Atributo expediente
        public int NumListaConuslta { get; set; }
        public int IDperro { get; set; }
        public string fecha_consulta { get; set; }
        public string descrip { get; set; }

        //Método
        public int AccesoExpediente()
        {
            ModeloExpediente acceso = new ModeloExpediente();
            return acceso.accesoExpediente(NumListaConuslta);
        }
        public int ComprobarExpediente()
        {
            return ModeloExpediente.ComprobarExpediente(NumListaConuslta);
        }
        //Inserción
        public int AgregarExpediente()
        {
            return ModeloExpediente.AgregarExpediente(descrip, fecha_consulta, NumListaConuslta);
        }
        //Actualización
        public int ActualizarExpediente(string pdescrip, string pfecha_expediente)
        {
            return ModeloExpediente.ActualizarExpediente(pdescrip, pfecha_expediente, AtributosExpediente.IdConsulta);
        }
        //Eliminación
        public bool EliminarExpediente()
        {
            return ModeloExpediente.EliminarExpediente(AtributosExpediente.IdConsulta);
        }
        //Cargar si existe el expediente ingresado
        public List<int> EncontrarConsulta()
        {
            return ModeloExpediente.SelecID(NumListaConuslta);
        }
        public int CargarID(int Idconsulta)
        {
            return ModeloExpediente.CargarIDconsulta(Idconsulta);
        }
        public List<string> CargarDetalle(int idconsulta)
        {
            return ModeloExpediente.cargarDetalle(idconsulta);
        }
        public List<string> CargarFecha(int idconsulta)
        {
            return ModeloExpediente.CargarFechaExpediente(idconsulta);
        }
        public List<string> CargarListaConsulta()
        {
            return ModeloConsulta.CargarConsultaLista();
        }
    }
    public class AtributosExpediente
    {
        public static int IdConsulta { get; set; }
        public static string Confirmarfecha { get; set; }
    }

    #endregion

}

