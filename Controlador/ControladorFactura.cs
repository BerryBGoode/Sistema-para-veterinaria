using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Modelo;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorFactura
    {
        #region Mostrar
        public static DataTable CargarListaGeneralFactura()
        {
            DataTable datos;
            return datos = ModeloFactura.CargarFacturaShow();
        }
        public static DataTable CargarBusquedaFactura(string busqueda)
        {
            DataTable datos;
            return datos = ModeloFactura.BuscarFactura(busqueda);
        }
        public static DataTable CargarFacturaBuscarfrm(string buscar)
        {
            return ModeloFactura.BuscarFacturaFRM(buscar);
        }
        #endregion
        #region Lectura de datos
        public static DataTable CargarEstadoFactura()
        {
            DataTable cargar = ModeloFactura.CargarEstadoFactura();
            return cargar;
        }
        public static DataTable CargarPropietarios()
        {
            DataTable cargar = ModeloFactura.CargarPropietarios();
            return cargar;
        }
        public static DataTable CargarEmpleados()
        {
            DataTable Cargar = ModeloFactura.CargarUsuarios();
            return Cargar;
        }
        public static DataTable CargarFactura()
        {
            DataTable cargar = ModeloFactura.CagarFactura();
            return cargar;
        }
        #endregion

        //Atributos
        public int idfactura { get; set; }
        public int idpropietario { get; set; }
        public int idestado_factura { get; set; }
        public string totalpaga { get; set; }
        public string fecha_factura { get; set; }
        public int idusuario { get; set; }

        //Métodos
        public int IngresarFactura()
        {
            return ModeloFactura.AgregarFactura(idpropietario, idusuario, totalpaga, fecha_factura, idestado_factura);
        }

        public int ActualizarFactura()
        {
            return ModeloFactura.ActualizarFactura(idfactura, idpropietario, idusuario, totalpaga, fecha_factura, idestado_factura);
        }
        public static DataTable CargarEstadoUPDATE(string valor)
        {
            return ModeloFactura.CargarEstadoUp(valor);
        }

        public int BorrarFactura()
        {
            return ModeloFactura.EliminarFactura(idfactura);
        }
    }
}
