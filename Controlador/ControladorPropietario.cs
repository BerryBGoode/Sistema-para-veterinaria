using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
    public class ControladorPropietario
    {
        #region Lectura de datos
        public static DataTable CargarTipoDoc()
        {
            DataTable cargar = ModeloPropietario.CargarTipoDoc();
            return cargar;
        }
        public static DataTable cargarEstado()
        {
            DataTable cargar;
            return cargar = ModeloPropietario.cargarEstado();
        }
        public static DataTable cargarDepartamento()
        {
            DataTable cargar = ModeloPropietario.CargarDepartamento();
            return cargar;
        }
        public static DataTable CargarMunicipios()
        {
            DataTable cargar = ModeloPropietario.CargarMunicipio();
            return cargar;
        }
        public static DataTable CargarMunicipioSelect(int pid)
        {
            DataTable cargar = ModeloPropietario.CargarMunicipioSelect(pid);
            return cargar;
        }
        public static DataTable CargarPropietarios()
        {
            DataTable cargar = ModeloPropietario.CargarPropietarios();
            return cargar;
        }
        public static DataTable CargarContacto_Propietario()
        {
            DataTable cargar = ModeloPropietario.CargarContacto_Propietario();
            return cargar;
        }
        public static DataTable CargarBusqueda(string buscar)
        {
            DataTable cargar = ModeloPropietario.BuscarPropietarios(buscar);
            return cargar;
        }
        public static DataTable CargarContacto(string buscar)
        {
            DataTable cargar = ModeloPropietario.BuscarContacto(buscar);
            return cargar;
        }
        #endregion

        //Atributos
        public int idpropietario { get; set; }
        public string nombre_propietario { get; set; }
        public string apellido_propietario { get; set; }
        public string fecha_nacimiento { get; set; }
        public int idtipodocumento { get; set; }
        public string num_documento { get; set; }
        public int idmunicipio { get; set; }
        public int idestado { get; set; }
        public int idnum_telefono { get; set; }
        public string num_telefono { get; set; }

        #region EnviarDatos
        public int AgregarPropietario()
        {
            return ModeloPropietario.AgregarPropietario(nombre_propietario, apellido_propietario, fecha_nacimiento, idtipodocumento, num_documento, idmunicipio, idestado);
        }
        public bool AgregarNumTelefono()
        {
            return ModeloPropietario.AgregarNumTelefono(idpropietario, num_telefono);
        }
        #endregion

        #region Actualización de datos

        public static DataTable cargarTipoDocUPDATE(string id)
        {
            return ModeloPropietario.CargarTipoDocUP(id);
        } 
        public static DataTable cargarEstadoUPDATE(string id)
        {
            return ModeloPropietario.CargarEstadoUp(id);
        }
        public static DataTable cargarDepartamentoUPDATE(string id)
        {
            return ModeloPropietario.CargarDepartamentoUP(id);
        }
        public static DataTable cargarMunicipioUPDATE(string id)
        {
            return ModeloPropietario.CargarMunicipioUP(id);
        }
        public int ActualizarPropietario()
        {
            return ModeloPropietario.ActualizarPropietario(idpropietario, nombre_propietario, apellido_propietario, fecha_nacimiento, idtipodocumento, num_documento, idmunicipio, idestado);
        }
        public bool ActualizaContacto_propietario()
        {
            return ModeloPropietario.ActualizarContacto_Propietario(idnum_telefono, num_telefono);
        }
        #endregion

        #region Eliminación de datos
        public bool EliminarPropietario()
        {
            return ModeloPropietario.EliminarPropietario(idpropietario);
        }
        #endregion
    }
}
